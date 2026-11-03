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
            components = new System.ComponentModel.Container();
            tlpRoot = new TableLayoutPanel();
            pnlHeader = new Panel();
            picLogo = new PictureBox();
            lblTitle = new Label();
            tlpFields = new TableLayoutPanel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            lblError = new Label();
            pnlButtons = new FlowLayoutPanel();
            btnCancel = new Button();
            btnLogin = new Button();
            stsLogin = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            erpLogin = new ErrorProvider(components);
            tlpRoot.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpFields.SuspendLayout();
            pnlButtons.SuspendLayout();
            stsLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpLogin).BeginInit();
            SuspendLayout();
            // tlpRoot
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(pnlHeader, 0, 0);
            tlpRoot.Controls.Add(tlpFields, 0, 1);
            tlpRoot.Controls.Add(lblError, 0, 2);
            tlpRoot.Controls.Add(pnlButtons, 0, 3);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(12);
            tlpRoot.RowCount = 4;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpRoot.Size = new Size(420, 298);
            // pnlHeader
            pnlHeader.BackColor = Color.FromArgb(245, 238, 230);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(picLogo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(8);
            picLogo.Location = new Point(12, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(48, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabStop = false;
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(72, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Cafe Win — Đăng nhập";
            // tlpFields
            tlpFields.ColumnCount = 2;
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpFields.Controls.Add(lblUsername, 0, 0);
            tlpFields.Controls.Add(txtUsername, 1, 0);
            tlpFields.Controls.Add(lblPassword, 0, 1);
            tlpFields.Controls.Add(txtPassword, 1, 1);
            tlpFields.Controls.Add(chkShowPassword, 1, 2);
            tlpFields.Dock = DockStyle.Fill;
            tlpFields.Name = "tlpFields";
            tlpFields.Padding = new Padding(24, 12, 24, 12);
            tlpFields.RowCount = 3;
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            lblUsername.Anchor = AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Tên đăng nhập";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.TabIndex = 0;
            lblPassword.Anchor = AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Mật khẩu";
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Name = "txtPassword";
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            chkShowPassword.Anchor = AnchorStyles.Left;
            chkShowPassword.AutoSize = true;
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // lblError
            lblError.Dock = DockStyle.Fill;
            lblError.ForeColor = Color.Red;
            lblError.Name = "lblError";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // pnlButtons
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnLogin);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(0, 4, 0, 0);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 36);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // stsLogin
            stsLogin.Items.AddRange(new ToolStripItem[] { lblStatus });
            stsLogin.Name = "stsLogin";
            stsLogin.Dock = DockStyle.Bottom;
            lblStatus.Name = "lblStatus";
            lblStatus.Spring = true;
            lblStatus.Text = "Sẵn sàng";
            erpLogin.ContainerControl = this;
            // frmLogin
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(420, 320);
            Controls.Add(tlpRoot);
            Controls.Add(stsLogin);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmLogin_Load;
            tlpRoot.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpFields.ResumeLayout(false);
            tlpFields.PerformLayout();
            pnlButtons.ResumeLayout(false);
            stsLogin.ResumeLayout(false);
            stsLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblTitle;
        private TableLayoutPanel tlpFields;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Label lblError;
        private FlowLayoutPanel pnlButtons;
        private Button btnLogin;
        private Button btnCancel;
        private StatusStrip stsLogin;
        private ToolStripStatusLabel lblStatus;
        private ErrorProvider erpLogin;
    }
}
