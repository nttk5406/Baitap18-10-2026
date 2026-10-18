using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class frmGymMemberManager : Form
    {
        private BindingList<MemberModel> _memberList = new BindingList<MemberModel>();
        private BindingSource _bindingSource = new BindingSource();
        private int _autoSeq = 1;

        public frmGymMemberManager()
        {
            InitializeComponent();
        }

        private void frmGymMemberManager_Load(object sender, EventArgs e)
        {
            SetupGridColumns();
            InitData();
            SetupBinding();
        }

        private void SetupGridColumns()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.ReadOnly = true;

            dgvMembers.Columns.Clear();
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MemberId", HeaderText = "Mã HV" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Tên hội viên" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "SĐT" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Package", HeaderText = "Gói tập" });

            var colDate = new DataGridViewTextBoxColumn { DataPropertyName = "StartDate", HeaderText = "Ngày ĐK" };
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvMembers.Columns.Add(colDate);

            var colFee = new DataGridViewTextBoxColumn { DataPropertyName = "Fee", HeaderText = "Phí dịch vụ" };
            colFee.DefaultCellStyle.Format = "N0";
            dgvMembers.Columns.Add(colFee);
        }

        private void InitData()
        {
            _memberList.Add(new MemberModel { MemberId = GenerateMemberId(), FullName = "Nguyễn Văn A", Phone = "0987654321", Package = "Theo tháng", StartDate = DateTime.Now, Fee = 500000 });
            _memberList.Add(new MemberModel { MemberId = GenerateMemberId(), FullName = "Trần Thị B", Phone = "0912345678", Package = "1 năm", StartDate = DateTime.Now.AddDays(-10), Fee = 4500000 });
        }

        private string GenerateMemberId()
        {
            return $"HV{_autoSeq++:D3}";
        }

        private void SetupBinding()
        {
            _bindingSource.DataSource = _memberList;
            dgvMembers.DataSource = _bindingSource;

            // Clear existing bindings
            txtMemberId.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            cboPackage.DataBindings.Clear();
            dtpStartDate.DataBindings.Clear();
            txtFee.DataBindings.Clear();

            // Bind controls (OnPropertyChanged ensures 2-way sync on edit)
            txtMemberId.DataBindings.Add("Text", _bindingSource, "MemberId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", _bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPhone.DataBindings.Add("Text", _bindingSource, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);
            cboPackage.DataBindings.Add("Text", _bindingSource, "Package", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpStartDate.DataBindings.Add("Value", _bindingSource, "StartDate", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFee.DataBindings.Add("Text", _bindingSource, "Fee", true, DataSourceUpdateMode.OnPropertyChanged, "0", "N0");
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            errorProvider1.Clear();

            // Validate FullName
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || !Regex.IsMatch(txtFullName.Text, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                errorProvider1.SetError(txtFullName, "Tên hội viên không được trống và không chứa ký tự đặc biệt.");
                isValid = false;
            }

            // Validate Phone
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{10}$"))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại phải đúng 10 chữ số.");
                isValid = false;
            }

            // Validate Fee
            if (!decimal.TryParse(txtFee.Text.Replace(".", "").Replace(",", ""), out decimal fee) || fee <= 0)
            {
                errorProvider1.SetError(txtFee, "Phí dịch vụ phải là số nguyên dương.");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var newMember = new MemberModel
            {
                MemberId = GenerateMemberId(),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.SelectedItem?.ToString() ?? "Theo tháng",
                StartDate = dtpStartDate.Value,
                Fee = decimal.Parse(txtFee.Text.Replace(".", "").Replace(",", ""))
            };

            _memberList.Add(newMember);
            _bindingSource.MoveLast();
            MessageBox.Show("Thêm hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            _bindingSource.EndEdit();
            dgvMembers.Refresh();
            MessageBox.Show("Cập nhật thông tin hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null) return;

            var dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hội viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                _bindingSource.RemoveCurrent();
                MessageBox.Show("Đã xóa hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMemberId.Text = GenerateMemberId();
            txtFullName.Clear();
            txtPhone.Clear();
            cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            txtFee.Clear();
            errorProvider1.Clear();
        }
    }
}