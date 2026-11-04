namespace winform_cuoi_ki
{
    partial class frmLogin
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
            Color mauNau = Color.FromArgb(109, 58, 32);
            Color mauNen = Color.FromArgb(245, 240, 232);

            pnlBanner = new Panel();
            lblTieuDe = new Label();
            lblPhu = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkHienMatKhau = new CheckBox();
            lblError = new Label();
            btnLogin = new Button();
            btnThoat = new Button();
            pnlBanner.SuspendLayout();
            SuspendLayout();

            pnlBanner.BackColor = mauNau;
            pnlBanner.Controls.Add(lblPhu);
            pnlBanner.Controls.Add(lblTieuDe);
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(420, 70);

            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(420, 36);
            lblTieuDe.Text = "CAFE WIN — ĐĂNG NHẬP";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            lblPhu.Dock = DockStyle.Fill;
            lblPhu.ForeColor = Color.FromArgb(255, 235, 210);
            lblPhu.Name = "lblPhu";
            lblPhu.Text = "Hệ thống bán hàng tại quầy";
            lblPhu.TextAlign = ContentAlignment.TopCenter;

            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(40, 100);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Tên đăng nhập";

            txtUsername.Location = new Point(40, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(340, 27);
            txtUsername.TabIndex = 0;

            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 168);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Mật khẩu";

            txtPassword.Location = new Point(40, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;

            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(40, 232);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.TabIndex = 2;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;

            lblError.AutoSize = true;
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(40, 262);
            lblError.Name = "lblError";
            lblError.Visible = false;

            btnLogin.BackColor = mauNau;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            btnThoat.Location = new Point(220, 292);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;

            AcceptButton = btnLogin;
            CancelButton = btnThoat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = mauNen;
            ClientSize = new Size(420, 360);
            Controls.Add(btnThoat);
            Controls.Add(btnLogin);
            Controls.Add(lblError);
            Controls.Add(chkHienMatKhau);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(pnlBanner);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmLogin_Load;

            pnlBanner.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBanner;
        private Label lblTieuDe;
        private Label lblPhu;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkHienMatKhau;
        private Label lblError;
        private Button btnLogin;
        private Button btnThoat;
    }
}
