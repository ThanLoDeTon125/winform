namespace winform_cuoi_ki
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileLogout = new ToolStripMenuItem();
            mnuFileExit = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuHelpAbout = new ToolStripMenuItem();
            stsMain = new StatusStrip();
            lblStatusMsg = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            lblDbHint = new ToolStripStatusLabel();
            tmrClock = new System.Windows.Forms.Timer(components);
            pnlSidebar = new Panel();
            flpNav = new FlowLayoutPanel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            btnNavPos = new Button();
            btnNavMenu = new Button();
            btnNavStock = new Button();
            btnNavOrders = new Button();
            btnNavStaff = new Button();
            btnNavShift = new Button();
            btnNavCustomers = new Button();
            btnNavReports = new Button();
            btnNavSettings = new Button();
            pnlRight = new Panel();
            pnlHeader = new Panel();
            lblStoreName = new Label();
            lblUserRole = new Label();
            lblShiftInfo = new Label();
            btnOpenShift = new Button();
            btnCloseShift = new Button();
            btnLogout = new Button();
            pnlContent = new Panel();
            mnuMain.SuspendLayout();
            stsMain.SuspendLayout();
            pnlSidebar.SuspendLayout();
            flpNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRight.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            //
            // mnuMain
            //
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuHelp });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1280, 24);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "mnuMain";
            //
            // mnuFile
            //
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileLogout, mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(69, 20);
            mnuFile.Text = "Hệ thống";
            //
            // mnuFileLogout
            //
            mnuFileLogout.Name = "mnuFileLogout";
            mnuFileLogout.Size = new Size(140, 22);
            mnuFileLogout.Text = "Đăng xuất";
            mnuFileLogout.Click += mnuFileLogout_Click;
            //
            // mnuFileExit
            //
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(140, 22);
            mnuFileExit.Text = "Thoát";
            mnuFileExit.Click += mnuFileExit_Click;
            //
            // mnuHelp
            //
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuHelpAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(65, 20);
            mnuHelp.Text = "Trợ giúp";
            //
            // mnuHelpAbout
            //
            mnuHelpAbout.Name = "mnuHelpAbout";
            mnuHelpAbout.Size = new Size(140, 22);
            mnuHelpAbout.Text = "Giới thiệu";
            mnuHelpAbout.Click += mnuHelpAbout_Click;
            //
            // stsMain
            //
            stsMain.Items.AddRange(new ToolStripItem[] { lblStatusMsg, lblClock, lblDbHint });
            stsMain.Location = new Point(0, 698);
            stsMain.Name = "stsMain";
            stsMain.Size = new Size(1280, 22);
            stsMain.TabIndex = 1;
            //
            // lblStatusMsg
            //
            lblStatusMsg.Name = "lblStatusMsg";
            lblStatusMsg.Size = new Size(1090, 17);
            lblStatusMsg.Spring = true;
            lblStatusMsg.Text = "Sẵn sàng";
            lblStatusMsg.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblClock
            //
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(55, 17);
            lblClock.Text = "00:00:00";
            //
            // lblDbHint
            //
            lblDbHint.Name = "lblDbHint";
            lblDbHint.Size = new Size(45, 17);
            lblDbHint.Text = "LocalDB";
            //
            // tmrClock
            //
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            //
            // pnlSidebar
            //
            pnlSidebar.Controls.Add(flpNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 24);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(8);
            pnlSidebar.Size = new Size(220, 674);
            pnlSidebar.TabIndex = 2;
            //
            // flpNav
            //
            flpNav.Controls.Add(picLogo);
            flpNav.Controls.Add(lblAppName);
            flpNav.Controls.Add(btnNavPos);
            flpNav.Controls.Add(btnNavMenu);
            flpNav.Controls.Add(btnNavStock);
            flpNav.Controls.Add(btnNavOrders);
            flpNav.Controls.Add(btnNavStaff);
            flpNav.Controls.Add(btnNavShift);
            flpNav.Controls.Add(btnNavCustomers);
            flpNav.Controls.Add(btnNavReports);
            flpNav.Controls.Add(btnNavSettings);
            flpNav.Dock = DockStyle.Fill;
            flpNav.FlowDirection = FlowDirection.TopDown;
            flpNav.Location = new Point(8, 8);
            flpNav.Name = "flpNav";
            flpNav.Size = new Size(204, 658);
            flpNav.TabIndex = 0;
            flpNav.WrapContents = false;
            //
            // picLogo
            //
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(64, 64);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // lblAppName
            //
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAppName.Location = new Point(3, 74);
            lblAppName.Margin = new Padding(3, 4, 3, 8);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(74, 20);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Cafe Win";
            //
            // nav buttons helper style
            //
            ConfigureNavButton(btnNavPos, "btnNavPos", "Bán hàng (POS)", btnNavPos_Click);
            ConfigureNavButton(btnNavMenu, "btnNavMenu", "Thực đơn", btnNavMenu_Click);
            ConfigureNavButton(btnNavStock, "btnNavStock", "Kho nguyên liệu", btnNavStock_Click);
            ConfigureNavButton(btnNavOrders, "btnNavOrders", "Đơn hàng", btnNavOrders_Click);
            ConfigureNavButton(btnNavStaff, "btnNavStaff", "Nhân viên", btnNavStaff_Click);
            ConfigureNavButton(btnNavShift, "btnNavShift", "Ca làm việc", btnNavShift_Click);
            ConfigureNavButton(btnNavCustomers, "btnNavCustomers", "Khách hàng", btnNavCustomers_Click);
            ConfigureNavButton(btnNavReports, "btnNavReports", "Báo cáo", btnNavReports_Click);
            ConfigureNavButton(btnNavSettings, "btnNavSettings", "Cấu hình", btnNavSettings_Click);
            //
            // pnlRight
            //
            pnlRight.Controls.Add(pnlContent);
            pnlRight.Controls.Add(pnlHeader);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(220, 24);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1060, 674);
            pnlRight.TabIndex = 3;
            //
            // pnlHeader
            //
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(btnCloseShift);
            pnlHeader.Controls.Add(btnOpenShift);
            pnlHeader.Controls.Add(lblShiftInfo);
            pnlHeader.Controls.Add(lblUserRole);
            pnlHeader.Controls.Add(lblStoreName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(12, 8, 12, 8);
            pnlHeader.Size = new Size(1060, 48);
            pnlHeader.TabIndex = 0;
            //
            // lblStoreName
            //
            lblStoreName.AutoSize = true;
            lblStoreName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStoreName.Location = new Point(12, 14);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(110, 19);
            lblStoreName.TabIndex = 0;
            lblStoreName.Text = "Cửa hàng Demo";
            //
            // lblUserRole
            //
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(200, 16);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(120, 15);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "User — Vai trò";
            //
            // lblShiftInfo
            //
            lblShiftInfo.AutoSize = true;
            lblShiftInfo.Location = new Point(400, 16);
            lblShiftInfo.Name = "lblShiftInfo";
            lblShiftInfo.Size = new Size(80, 15);
            lblShiftInfo.TabIndex = 2;
            lblShiftInfo.Text = "Chưa mở ca";
            //
            // btnOpenShift
            //
            btnOpenShift.Location = new Point(560, 10);
            btnOpenShift.Name = "btnOpenShift";
            btnOpenShift.Size = new Size(80, 28);
            btnOpenShift.TabIndex = 3;
            btnOpenShift.Text = "Mở ca";
            btnOpenShift.UseVisualStyleBackColor = true;
            btnOpenShift.Click += btnOpenShift_Click;
            //
            // btnCloseShift
            //
            btnCloseShift.Location = new Point(648, 10);
            btnCloseShift.Name = "btnCloseShift";
            btnCloseShift.Size = new Size(80, 28);
            btnCloseShift.TabIndex = 4;
            btnCloseShift.Text = "Chốt ca";
            btnCloseShift.UseVisualStyleBackColor = true;
            btnCloseShift.Visible = false;
            btnCloseShift.Click += btnCloseShift_Click;
            //
            // btnLogout
            //
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(948, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 28);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            //
            // pnlContent
            //
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 48);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1060, 626);
            pnlContent.TabIndex = 1;
            //
            // frmMain
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlRight);
            Controls.Add(pnlSidebar);
            Controls.Add(stsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = mnuMain;
            MinimumSize = new Size(1024, 640);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cafe";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            stsMain.ResumeLayout(false);
            stsMain.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            flpNav.ResumeLayout(false);
            flpNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigureNavButton(Button btn, string name, string text, EventHandler onClick)
        {
            btn.Margin = new Padding(4);
            btn.Name = name;
            btn.Size = new Size(200, 40);
            btn.Text = text;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = true;
            btn.Click += onClick;
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileLogout;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuHelpAbout;
        private StatusStrip stsMain;
        private ToolStripStatusLabel lblStatusMsg;
        private ToolStripStatusLabel lblClock;
        private ToolStripStatusLabel lblDbHint;
        private System.Windows.Forms.Timer tmrClock;
        private Panel pnlSidebar;
        private FlowLayoutPanel flpNav;
        private PictureBox picLogo;
        private Label lblAppName;
        private Button btnNavPos;
        private Button btnNavMenu;
        private Button btnNavStock;
        private Button btnNavOrders;
        private Button btnNavStaff;
        private Button btnNavShift;
        private Button btnNavCustomers;
        private Button btnNavReports;
        private Button btnNavSettings;
        private Panel pnlRight;
        private Panel pnlHeader;
        private Label lblStoreName;
        private Label lblUserRole;
        private Label lblShiftInfo;
        private Button btnOpenShift;
        private Button btnCloseShift;
        private Button btnLogout;
        private Panel pnlContent;
    }
}
