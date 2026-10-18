namespace BookManagement
{
    partial class frmBookManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuOpenCSV = new ToolStripMenuItem();
            menuSaveCSV = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbAdd = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblTotalBooks = new ToolStripStatusLabel();
            lblTotalPrice = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            picBookCover = new PictureBox();
            btnLoadImage = new Button();
            dgvBooks = new DataGridView();
            lblBookId = new Label();
            txtBookId = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip1.Location = new Point(0, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(624, 28);
            menuStrip1.TabIndex = 0;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpenCSV, menuSaveCSV, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuOpenCSV
            // 
            menuOpenCSV.Name = "menuOpenCSV";
            menuOpenCSV.Size = new Size(171, 26);
            menuOpenCSV.Text = "Mở file CSV";
            menuOpenCSV.Click += menuOpenCSV_Click;
            // 
            // menuSaveCSV
            // 
            menuSaveCSV.Name = "menuSaveCSV";
            menuSaveCSV.Size = new Size(171, 26);
            menuSaveCSV.Text = "Lưu file CSV";
            menuSaveCSV.Click += menuSaveCSV_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(171, 26);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave, tsbAdd });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(624, 27);
            toolStrip1.TabIndex = 1;
            // 
            // tsbOpen
            // 
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(60, 24);
            tsbOpen.Text = "Mở file";
            tsbOpen.Click += menuOpenCSV_Click;
            // 
            // tsbSave
            // 
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(62, 24);
            tsbSave.Text = "Lưu file";
            tsbSave.Click += menuSaveCSV_Click;
            // 
            // tsbAdd
            // 
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(80, 24);
            tsbAdd.Text = "Thêm mới";
            tsbAdd.Click += btnAddBook_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalBooks, lblTotalPrice, lblClock });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(624, 26);
            statusStrip1.TabIndex = 2;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(103, 20);
            lblTotalBooks.Text = "Tổng sách: 0 | ";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(148, 20);
            lblTotalPrice.Text = "Tổng giá trị: 0 VNĐ | ";
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(132, 20);
            lblClock.Text = "Thời gian: 00:00:00";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // picBookCover
            // 
            picBookCover.BorderStyle = BorderStyle.FixedSingle;
            picBookCover.Location = new Point(12, 60);
            picBookCover.Name = "picBookCover";
            picBookCover.Size = new Size(120, 150);
            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            picBookCover.TabIndex = 3;
            picBookCover.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(12, 218);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(120, 25);
            btnLoadImage.TabIndex = 4;
            btnLoadImage.Text = "Tải ảnh bìa";
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Location = new Point(12, 255);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(600, 170);
            dgvBooks.TabIndex = 13;
            // 
            // lblBookId
            // 
            lblBookId.Location = new Point(150, 60);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(100, 23);
            lblBookId.TabIndex = 5;
            lblBookId.Text = "Mã sách:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(256, 56);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(200, 27);
            txtBookId.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(150, 95);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Tên sách:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(256, 91);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 8;
            // 
            // lblAuthor
            // 
            lblAuthor.Location = new Point(150, 130);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(100, 23);
            lblAuthor.TabIndex = 9;
            lblAuthor.Text = "Tác giả:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(256, 124);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 27);
            txtAuthor.TabIndex = 10;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(150, 165);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Giá sách:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(256, 161);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 12;
            // 
            // frmBookManager
            // 
            ClientSize = new Size(624, 451);
            Controls.Add(menuStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(picBookCover);
            Controls.Add(btnLoadImage);
            Controls.Add(lblBookId);
            Controls.Add(txtBookId);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblAuthor);
            Controls.Add(txtAuthor);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(dgvBooks);
            MainMenuStrip = menuStrip1;
            Name = "frmBookManager";
            Text = "Quản lý Tài liệu Sách & Báo cáo";
            Load += frmBookManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile, menuOpenCSV, menuSaveCSV, menuExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen, tsbSave, tsbAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalBooks, lblTotalPrice, lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.PictureBox picBookCover;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblBookId, lblTitle, lblAuthor, lblPrice;
        private System.Windows.Forms.TextBox txtBookId, txtTitle, txtAuthor, txtPrice;
    }
}