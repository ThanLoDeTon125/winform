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
            Color mauNau = Color.FromArgb(125, 68, 39);
            Color mauCamNhat = Color.FromArgb(242, 201, 160);
            Color mauNen = Color.FromArgb(250, 244, 235);
            Color mauDo = Color.FromArgb(180, 45, 45);

            pnlBanner = new Panel();
            lblTieuDe = new Label();
            lblPhu = new Label();
            pnlCard = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkHienMatKhau = new CheckBox();
            lblError = new Label();
            btnLogin = new Button();
            btnThoat = new Button();
            pnlBanner.SuspendLayout();
            pnlCard.SuspendLayout();
            SuspendLayout();

            pnlBanner.BackColor = mauNau;
            pnlBanner.Controls.Add(lblPhu);
            pnlBanner.Controls.Add(lblTieuDe);
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(440, 78);

            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(440, 42);
            lblTieuDe.Text = "CAFE WIN — ĐĂNG NHẬP";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            lblPhu.Dock = DockStyle.Fill;
            lblPhu.Font = new Font("Segoe UI", 9F);
            lblPhu.ForeColor = Color.FromArgb(255, 235, 210);
            lblPhu.Name = "lblPhu";
            lblPhu.Text = "Hệ thống bán hàng tại quầy (Counter-Service POS)";
            lblPhu.TextAlign = ContentAlignment.TopCenter;

            pnlCard.BackColor = mauCamNhat;
            pnlCard.Controls.Add(btnThoat);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lblError);
            pnlCard.Controls.Add(chkHienMatKhau);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblUsername);
            pnlCard.Location = new Point(28, 100);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(384, 270);

            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = mauNau;
            lblUsername.Location = new Point(24, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Tên đăng nhập";

            txtUsername.Location = new Point(24, 46);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(336, 27);
            txtUsername.TabIndex = 0;

            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = mauNau;
            lblPassword.Location = new Point(24, 88);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Mật khẩu";

            txtPassword.Location = new Point(24, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(336, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;

            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.ForeColor = mauNau;
            chkHienMatKhau.Location = new Point(24, 152);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.TabIndex = 2;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;

            lblError.AutoSize = true;
            lblError.ForeColor = mauDo;
            lblError.Location = new Point(24, 182);
            lblError.Name = "lblError";
            lblError.Visible = false;

            btnLogin.BackColor = mauNau;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(24, 212);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            btnThoat.BackColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderColor = mauNau;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = mauNau;
            btnThoat.Location = new Point(200, 212);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 42);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;

            AcceptButton = btnLogin;
            CancelButton = btnThoat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = mauNen;
            ClientSize = new Size(440, 400);
            Controls.Add(pnlCard);
            Controls.Add(pnlBanner);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập — Cafe Win";
            Load += frmLogin_Load;

            pnlBanner.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBanner;
        private Label lblTieuDe;
        private Label lblPhu;
        private Panel pnlCard;
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
