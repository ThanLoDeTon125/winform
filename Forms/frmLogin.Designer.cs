namespace winform_cuoi_ki
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkHienMatKhau = new CheckBox();
            lblError = new Label();
            btnLogin = new Button();
            btnThoat = new Button();
            SuspendLayout();
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.Location = new Point(90, 24);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "Cafe Win — Đăng nhập";
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(40, 80);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Tên đăng nhập";
            txtUsername.Location = new Point(160, 76);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 0;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Mật khẩu";
            txtPassword.Location = new Point(160, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(160, 156);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.TabIndex = 2;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(40, 196);
            lblError.Name = "lblError";
            lblError.Visible = false;
            btnLogin.Location = new Point(160, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnThoat.Location = new Point(280, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 36);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            AcceptButton = btnLogin;
            CancelButton = btnThoat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 320);
            Controls.Add(btnThoat);
            Controls.Add(btnLogin);
            Controls.Add(lblError);
            Controls.Add(chkHienMatKhau);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTieuDe);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblTieuDe;
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
