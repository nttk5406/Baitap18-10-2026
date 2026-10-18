namespace GymManagement
{
    partial class frmGymMemberManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMemberId = new Label();
            txtMemberId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblPackage = new Label();
            cboPackage = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblFee = new Label();
            txtFee = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvMembers = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            grpInfo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblMemberId
            // 
            lblMemberId.Location = new Point(15, 25);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(100, 23);
            lblMemberId.TabIndex = 0;
            lblMemberId.Text = "Mã hội viên:";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(121, 22);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(159, 27);
            txtMemberId.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(15, 55);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ và tên:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(121, 52);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(159, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(15, 85);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(121, 82);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(159, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblPackage
            // 
            lblPackage.Location = new Point(310, 25);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(100, 23);
            lblPackage.TabIndex = 6;
            lblPackage.Text = "Gói tập:";
            // 
            // cboPackage
            // 
            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPackage.FormattingEnabled = true;
            cboPackage.Items.AddRange(new object[] { "Theo tháng", "6 tháng", "1 năm" });
            cboPackage.Location = new Point(416, 22);
            cboPackage.Name = "cboPackage";
            cboPackage.Size = new Size(164, 28);
            cboPackage.TabIndex = 7;
            // 
            // lblStartDate
            // 
            lblStartDate.Location = new Point(310, 55);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 23);
            lblStartDate.TabIndex = 8;
            lblStartDate.Text = "Ngày đăng ký:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(416, 52);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(164, 27);
            dtpStartDate.TabIndex = 9;
            // 
            // lblFee
            // 
            lblFee.Location = new Point(310, 85);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(100, 23);
            lblFee.TabIndex = 10;
            lblFee.Text = "Phí dịch vụ:";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(416, 82);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(164, 27);
            txtFee.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm mới";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(145, 180);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 30);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa thông tin";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(278, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa hội viên";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(411, 180);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 30);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(12, 220);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvMembers.Size = new Size(600, 220);
            dgvMembers.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblMemberId);
            grpInfo.Controls.Add(txtMemberId);
            grpInfo.Controls.Add(lblFullName);
            grpInfo.Controls.Add(txtFullName);
            grpInfo.Controls.Add(lblPhone);
            grpInfo.Controls.Add(txtPhone);
            grpInfo.Controls.Add(lblPackage);
            grpInfo.Controls.Add(cboPackage);
            grpInfo.Controls.Add(lblStartDate);
            grpInfo.Controls.Add(dtpStartDate);
            grpInfo.Controls.Add(lblFee);
            grpInfo.Controls.Add(txtFee);
            grpInfo.Location = new Point(12, 12);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(600, 160);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin hội viên";
            // 
            // frmGymMemberManager
            // 
            ClientSize = new Size(624, 450);
            Controls.Add(grpInfo);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvMembers);
            Name = "frmGymMemberManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Dịch vụ Phòng Gym & Hội viên";
            Load += frmGymMemberManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}