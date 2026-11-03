namespace winform_cuoi_ki
{
    partial class frmPayment
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
            lblAmountDueCaption = new Label();
            lblAmountDue = new Label();
            tlpPayFields = new TableLayoutPanel();
            lblMethod = new Label();
            cboPaymentMethod = new ComboBox();
            lblReceived = new Label();
            txtAmountReceived = new TextBox();
            lblChangeCaption = new Label();
            lblChange = new Label();
            lblPayNote = new Label();
            txtPayNote = new TextBox();
            chkPrintReceipt = new CheckBox();
            flpQuickCash = new FlowLayoutPanel();
            btnCashExact = new Button();
            btnCash50 = new Button();
            btnCash100 = new Button();
            btnCash200 = new Button();
            btnCash500 = new Button();
            lblPayError = new Label();
            pnlButtons = new FlowLayoutPanel();
            btnCancel = new Button();
            btnConfirm = new Button();
            erpPay = new ErrorProvider(components);
            tlpRoot.SuspendLayout();
            tlpPayFields.SuspendLayout();
            flpQuickCash.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpPay).BeginInit();
            SuspendLayout();
            //
            // tlpRoot
            //
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(lblAmountDueCaption, 0, 0);
            tlpRoot.Controls.Add(lblAmountDue, 0, 1);
            tlpRoot.Controls.Add(tlpPayFields, 0, 2);
            tlpRoot.Controls.Add(flpQuickCash, 0, 3);
            tlpRoot.Controls.Add(lblPayError, 0, 4);
            tlpRoot.Controls.Add(pnlButtons, 0, 5);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(16);
            tlpRoot.RowCount = 6;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpRoot.Size = new Size(480, 420);
            tlpRoot.TabIndex = 0;
            //
            // labels due
            //
            lblAmountDueCaption.AutoSize = true;
            lblAmountDueCaption.Location = new Point(19, 16);
            lblAmountDueCaption.Name = "lblAmountDueCaption";
            lblAmountDueCaption.Size = new Size(100, 19);
            lblAmountDueCaption.TabIndex = 0;
            lblAmountDueCaption.Text = "Khách cần trả";
            lblAmountDue.AutoSize = true;
            lblAmountDue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAmountDue.Location = new Point(19, 40);
            lblAmountDue.Name = "lblAmountDue";
            lblAmountDue.Size = new Size(70, 32);
            lblAmountDue.TabIndex = 1;
            lblAmountDue.Text = "0 đ";
            //
            // tlpPayFields
            //
            tlpPayFields.ColumnCount = 2;
            tlpPayFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpPayFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpPayFields.Controls.Add(lblMethod, 0, 0);
            tlpPayFields.Controls.Add(cboPaymentMethod, 1, 0);
            tlpPayFields.Controls.Add(lblReceived, 0, 1);
            tlpPayFields.Controls.Add(txtAmountReceived, 1, 1);
            tlpPayFields.Controls.Add(lblChangeCaption, 0, 2);
            tlpPayFields.Controls.Add(lblChange, 1, 2);
            tlpPayFields.Controls.Add(lblPayNote, 0, 3);
            tlpPayFields.Controls.Add(txtPayNote, 1, 3);
            tlpPayFields.SetColumnSpan(chkPrintReceipt, 2);
            tlpPayFields.Controls.Add(chkPrintReceipt, 0, 4);
            tlpPayFields.Dock = DockStyle.Fill;
            tlpPayFields.Location = new Point(19, 83);
            tlpPayFields.Name = "tlpPayFields";
            tlpPayFields.RowCount = 5;
            tlpPayFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpPayFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpPayFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpPayFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpPayFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpPayFields.Size = new Size(442, 190);
            tlpPayFields.TabIndex = 2;
            //
            // fields
            //
            lblMethod.Anchor = AnchorStyles.Left;
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(3, 8);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(90, 19);
            lblMethod.TabIndex = 0;
            lblMethod.Text = "Phương thức";
            cboPaymentMethod.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ" });
            cboPaymentMethod.Location = new Point(157, 5);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(282, 25);
            cboPaymentMethod.TabIndex = 0;
            cboPaymentMethod.SelectedIndexChanged += cboPaymentMethod_SelectedIndexChanged;
            lblReceived.Anchor = AnchorStyles.Left;
            lblReceived.AutoSize = true;
            lblReceived.Location = new Point(3, 44);
            lblReceived.Name = "lblReceived";
            lblReceived.Size = new Size(110, 19);
            lblReceived.TabIndex = 2;
            lblReceived.Text = "Tiền khách đưa";
            txtAmountReceived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAmountReceived.Location = new Point(157, 41);
            txtAmountReceived.Name = "txtAmountReceived";
            txtAmountReceived.Size = new Size(282, 25);
            txtAmountReceived.TabIndex = 1;
            txtAmountReceived.TextChanged += txtAmountReceived_TextChanged;
            lblChangeCaption.Anchor = AnchorStyles.Left;
            lblChangeCaption.AutoSize = true;
            lblChangeCaption.Location = new Point(3, 80);
            lblChangeCaption.Name = "lblChangeCaption";
            lblChangeCaption.Size = new Size(70, 19);
            lblChangeCaption.TabIndex = 4;
            lblChangeCaption.Text = "Tiền thừa";
            lblChange.Anchor = AnchorStyles.Left;
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChange.Location = new Point(157, 80);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(36, 19);
            lblChange.TabIndex = 5;
            lblChange.Text = "0 đ";
            lblPayNote.Anchor = AnchorStyles.Left;
            lblPayNote.AutoSize = true;
            lblPayNote.Location = new Point(3, 116);
            lblPayNote.Name = "lblPayNote";
            lblPayNote.Size = new Size(55, 19);
            lblPayNote.TabIndex = 6;
            lblPayNote.Text = "Ghi chú";
            txtPayNote.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPayNote.Location = new Point(157, 113);
            txtPayNote.MaxLength = 200;
            txtPayNote.Name = "txtPayNote";
            txtPayNote.Size = new Size(282, 25);
            txtPayNote.TabIndex = 2;
            chkPrintReceipt.AutoSize = true;
            chkPrintReceipt.Checked = true;
            chkPrintReceipt.CheckState = CheckState.Checked;
            chkPrintReceipt.Location = new Point(3, 147);
            chkPrintReceipt.Name = "chkPrintReceipt";
            chkPrintReceipt.Size = new Size(200, 23);
            chkPrintReceipt.TabIndex = 3;
            chkPrintReceipt.Text = "In hóa đơn sau thanh toán";
            chkPrintReceipt.UseVisualStyleBackColor = true;
            //
            // flpQuickCash
            //
            flpQuickCash.Controls.Add(btnCashExact);
            flpQuickCash.Controls.Add(btnCash50);
            flpQuickCash.Controls.Add(btnCash100);
            flpQuickCash.Controls.Add(btnCash200);
            flpQuickCash.Controls.Add(btnCash500);
            flpQuickCash.Dock = DockStyle.Fill;
            flpQuickCash.Location = new Point(19, 279);
            flpQuickCash.Name = "flpQuickCash";
            flpQuickCash.Size = new Size(442, 42);
            flpQuickCash.TabIndex = 3;
            //
            // quick cash buttons
            //
            btnCashExact.Location = new Point(3, 3);
            btnCashExact.Name = "btnCashExact";
            btnCashExact.Size = new Size(60, 32);
            btnCashExact.TabIndex = 0;
            btnCashExact.Text = "Đủ";
            btnCashExact.UseVisualStyleBackColor = true;
            btnCashExact.Click += btnCashExact_Click;
            btnCash50.Location = new Point(69, 3);
            btnCash50.Name = "btnCash50";
            btnCash50.Size = new Size(70, 32);
            btnCash50.TabIndex = 1;
            btnCash50.Text = "50.000";
            btnCash50.UseVisualStyleBackColor = true;
            btnCash50.Click += btnCash50_Click;
            btnCash100.Location = new Point(145, 3);
            btnCash100.Name = "btnCash100";
            btnCash100.Size = new Size(80, 32);
            btnCash100.TabIndex = 2;
            btnCash100.Text = "100.000";
            btnCash100.UseVisualStyleBackColor = true;
            btnCash100.Click += btnCash100_Click;
            btnCash200.Location = new Point(231, 3);
            btnCash200.Name = "btnCash200";
            btnCash200.Size = new Size(80, 32);
            btnCash200.TabIndex = 3;
            btnCash200.Text = "200.000";
            btnCash200.UseVisualStyleBackColor = true;
            btnCash200.Click += btnCash200_Click;
            btnCash500.Location = new Point(317, 3);
            btnCash500.Name = "btnCash500";
            btnCash500.Size = new Size(80, 32);
            btnCash500.TabIndex = 4;
            btnCash500.Text = "500.000";
            btnCash500.UseVisualStyleBackColor = true;
            btnCash500.Click += btnCash500_Click;
            //
            // lblPayError
            //
            lblPayError.AutoSize = true;
            lblPayError.ForeColor = Color.Red;
            lblPayError.Location = new Point(19, 327);
            lblPayError.Name = "lblPayError";
            lblPayError.Size = new Size(0, 19);
            lblPayError.TabIndex = 4;
            lblPayError.Visible = false;
            //
            // pnlButtons
            //
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnConfirm);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Location = new Point(19, 355);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(442, 46);
            pnlButtons.TabIndex = 5;
            //
            // btnCancel / btnConfirm
            //
            btnCancel.Location = new Point(339, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            btnConfirm.Location = new Point(213, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 36);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            //
            // erpPay
            //
            erpPay.ContainerControl = this;
            //
            // frmPayment
            //
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(480, 420);
            Controls.Add(tlpRoot);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPayment";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thanh toán";
            Load += frmPayment_Load;
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            tlpPayFields.ResumeLayout(false);
            tlpPayFields.PerformLayout();
            flpQuickCash.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpPay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Label lblAmountDueCaption;
        private Label lblAmountDue;
        private TableLayoutPanel tlpPayFields;
        private Label lblMethod;
        private ComboBox cboPaymentMethod;
        private Label lblReceived;
        private TextBox txtAmountReceived;
        private Label lblChangeCaption;
        private Label lblChange;
        private Label lblPayNote;
        private TextBox txtPayNote;
        private CheckBox chkPrintReceipt;
        private FlowLayoutPanel flpQuickCash;
        private Button btnCashExact;
        private Button btnCash50;
        private Button btnCash100;
        private Button btnCash200;
        private Button btnCash500;
        private Label lblPayError;
        private FlowLayoutPanel pnlButtons;
        private Button btnConfirm;
        private Button btnCancel;
        private ErrorProvider erpPay;
    }
}
