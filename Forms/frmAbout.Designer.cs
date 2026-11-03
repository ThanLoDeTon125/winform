namespace winform_cuoi_ki
{
    partial class frmAbout
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
            tlpRoot = new TableLayoutPanel();
            picAboutLogo = new PictureBox();
            lblAppName = new Label();
            lblVersion = new Label();
            lblDescription = new Label();
            lblCopyright = new Label();
            lblRuntime = new Label();
            pnlButtons = new FlowLayoutPanel();
            btnOK = new Button();
            tlpRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAboutLogo).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            //
            // tlpRoot
            //
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(picAboutLogo, 0, 0);
            tlpRoot.Controls.Add(lblAppName, 1, 0);
            tlpRoot.Controls.Add(lblVersion, 1, 1);
            tlpRoot.SetColumnSpan(lblDescription, 2);
            tlpRoot.Controls.Add(lblDescription, 0, 2);
            tlpRoot.SetColumnSpan(lblCopyright, 2);
            tlpRoot.Controls.Add(lblCopyright, 0, 3);
            tlpRoot.SetColumnSpan(lblRuntime, 2);
            tlpRoot.Controls.Add(lblRuntime, 0, 4);
            tlpRoot.SetColumnSpan(pnlButtons, 2);
            tlpRoot.Controls.Add(pnlButtons, 0, 5);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(20);
            tlpRoot.RowCount = 6;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRoot.Size = new Size(400, 280);
            tlpRoot.TabIndex = 0;
            //
            // picAboutLogo
            //
            picAboutLogo.Location = new Point(23, 23);
            picAboutLogo.Name = "picAboutLogo";
            picAboutLogo.Size = new Size(64, 64);
            picAboutLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picAboutLogo.TabIndex = 0;
            picAboutLogo.TabStop = false;
            //
            // lblAppName
            //
            lblAppName.Anchor = AnchorStyles.Left;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAppName.Location = new Point(103, 28);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(95, 25);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Cafe Win";
            //
            // lblVersion
            //
            lblVersion.Anchor = AnchorStyles.Left;
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(103, 65);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(110, 15);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Phiên bản 1.0.0";
            //
            // lblDescription
            //
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Location = new Point(23, 88);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(354, 68);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Ứng dụng quản lý cửa hàng cafe — WinForms";
            //
            // lblCopyright
            //
            lblCopyright.AutoSize = true;
            lblCopyright.Location = new Point(23, 159);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(49, 15);
            lblCopyright.TabIndex = 4;
            lblCopyright.Text = "© 2026";
            //
            // lblRuntime
            //
            lblRuntime.AutoSize = true;
            lblRuntime.ForeColor = Color.Gray;
            lblRuntime.Location = new Point(23, 187);
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Size = new Size(80, 15);
            lblRuntime.TabIndex = 5;
            lblRuntime.Text = "Runtime: …";
            //
            // pnlButtons
            //
            pnlButtons.Controls.Add(btnOK);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Location = new Point(23, 215);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(354, 42);
            pnlButtons.TabIndex = 6;
            //
            // btnOK
            //
            btnOK.Location = new Point(251, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 32);
            btnOK.TabIndex = 0;
            btnOK.Text = "Đóng";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            //
            // frmAbout
            //
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOK;
            ClientSize = new Size(400, 280);
            Controls.Add(tlpRoot);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Giới thiệu";
            Load += frmAbout_Load;
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAboutLogo).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private PictureBox picAboutLogo;
        private Label lblAppName;
        private Label lblVersion;
        private Label lblDescription;
        private Label lblCopyright;
        private Label lblRuntime;
        private FlowLayoutPanel pnlButtons;
        private Button btnOK;
    }
}
