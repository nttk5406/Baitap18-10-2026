namespace HospitalManagement
{
    partial class formHospitalMain
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuSystem = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            menuReload = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            menuManagement = new ToolStripMenuItem();
            menuPatients = new ToolStripMenuItem();
            menuDoctors = new ToolStripMenuItem();
            menuDepartments = new ToolStripMenuItem();
            menuWindow = new ToolStripMenuItem();
            menuCascade = new ToolStripMenuItem();
            menuTileHorizontal = new ToolStripMenuItem();
            menuTileVertical = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuCloseAll = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            pbarStatus = new ToolStripProgressBar();
            lblStatusTime = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSystem, menuManagement, menuWindow });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 28);
            menuStrip1.TabIndex = 1;
            // 
            // menuSystem
            // 
            menuSystem.DropDownItems.AddRange(new ToolStripItem[] { menuLogout, menuReload, toolStripSeparator1, menuExit });
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(85, 24);
            menuSystem.Text = "&Hệ thống";
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(190, 26);
            menuLogout.Text = "&Đăng xuất";
            // 
            // menuReload
            // 
            menuReload.Name = "menuReload";
            menuReload.Size = new Size(190, 26);
            menuReload.Text = "&Nạp lại dữ liệu";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(190, 26);
            menuExit.Text = "T&hoát";
            // 
            // menuManagement
            // 
            menuManagement.DropDownItems.AddRange(new ToolStripItem[] { menuPatients, menuDoctors, menuDepartments });
            menuManagement.Name = "menuManagement";
            menuManagement.Size = new Size(73, 24);
            menuManagement.Text = "&Quản lý";
            // 
            // menuPatients
            // 
            menuPatients.Name = "menuPatients";
            menuPatients.Size = new Size(245, 26);
            menuPatients.Text = "&Hồ sơ Bệnh nhân";
            // 
            // menuDoctors
            // 
            menuDoctors.Name = "menuDoctors";
            menuDoctors.Size = new Size(245, 26);
            menuDoctors.Text = "Lịch trực &Bác sĩ";
            // 
            // menuDepartments
            // 
            menuDepartments.Name = "menuDepartments";
            menuDepartments.Size = new Size(245, 26);
            menuDepartments.Text = "Danh mục &Khoa/Phòng";
            // 
            // menuWindow
            // 
            menuWindow.DropDownItems.AddRange(new ToolStripItem[] { menuCascade, menuTileHorizontal, menuTileVertical, toolStripSeparator2, menuCloseAll });
            menuWindow.Name = "menuWindow";
            menuWindow.Size = new Size(68, 24);
            menuWindow.Text = "&Cửa sổ";
            // 
            // menuCascade
            // 
            menuCascade.Name = "menuCascade";
            menuCascade.Size = new Size(306, 26);
            menuCascade.Text = "Xếp &tầng (Cascade)";
            // 
            // menuTileHorizontal
            // 
            menuTileHorizontal.Name = "menuTileHorizontal";
            menuTileHorizontal.Size = new Size(306, 26);
            menuTileHorizontal.Text = "Sắp xếp &Dọc (Tile Vertical)";
            // 
            // menuTileVertical
            // 
            menuTileVertical.Name = "menuTileVertical";
            menuTileVertical.Size = new Size(306, 26);
            menuTileVertical.Text = "Sắp xếp &Ngang (Tile Horizontal)";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(303, 6);
            // 
            // menuCloseAll
            // 
            menuCloseAll.Name = "menuCloseAll";
            menuCloseAll.Size = new Size(306, 26);
            menuCloseAll.Text = "&Đóng tất cả";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusUser, pbarStatus, lblStatusTime });
            statusStrip1.Location = new Point(0, 725);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 26);
            statusStrip1.TabIndex = 0;
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(250, 20);
            lblStatusUser.Text = "Bác sĩ trực: BS. CKII Nguyễn Văn Bình";
            // 
            // pbarStatus
            // 
            pbarStatus.Name = "pbarStatus";
            pbarStatus.Size = new Size(150, 18);
            pbarStatus.Value = 100;
            // 
            // lblStatusTime
            // 
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(767, 20);
            lblStatusTime.Spring = true;
            lblStatusTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timerClock
            // 
            timerClock.Interval = 1000;
            // 
            // formHospitalMain
            // 
            ClientSize = new Size(1184, 751);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "formHospitalMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Bệnh Viện & Truy Xuất Hồ Sơ Bệnh Án (MDI System)";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;

        private System.Windows.Forms.ToolStripMenuItem menuManagement;
        private System.Windows.Forms.ToolStripMenuItem menuPatients;
        private System.Windows.Forms.ToolStripMenuItem menuDoctors;
        private System.Windows.Forms.ToolStripMenuItem menuDepartments;

        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuCloseAll;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ToolStripProgressBar pbarStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer timerClock;
    }
}