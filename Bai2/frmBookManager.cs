using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class frmBookManager : Form
    {
        private BindingList<BookModel> _bookList = new BindingList<BookModel>();
        private string _selectedImagePath = "";

        public frmBookManager()
        {
            InitializeComponent();
            _bookList.ListChanged += (s, e) => UpdateStatusStrip();
        }

        private void frmBookManager_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = _bookList;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = $"Thời gian: {DateTime.Now:HH:mm:ss}";
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;
                    picBookCover.ImageLocation = _selectedImagePath;
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(txtPrice.Text, out decimal price);

            _bookList.Add(new BookModel
            {
                BookId = txtBookId.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Price = price,
                ImagePath = Path.GetFileName(_selectedImagePath)
            });

            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuSaveCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV File|*.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("BookId,Title,Author,Price,ImagePath");
                        foreach (var book in _bookList)
                        {
                            sw.WriteLine($"{book.BookId},{book.Title},{book.Author},{book.Price},{book.ImagePath}");
                        }
                    }
                    MessageBox.Show("Xuất CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuOpenCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "CSV File|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _bookList.Clear();
                    var lines = File.ReadAllLines(ofd.FileName);
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var parts = lines[i].Split(',');
                        if (parts.Length >= 5)
                        {
                            decimal.TryParse(parts[3], out decimal price);
                            _bookList.Add(new BookModel
                            {
                                BookId = parts[0],
                                Title = parts[1],
                                Author = parts[2],
                                Price = price,
                                ImagePath = parts[4]
                            });
                        }
                    }
                }
            }
        }

        private void UpdateStatusStrip()
        {
            lblTotalBooks.Text = $"Tổng sách: {_bookList.Count} | ";
            lblTotalPrice.Text = $"Tổng giá trị: {_bookList.Sum(b => b.Price):N0} VNĐ | ";
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}