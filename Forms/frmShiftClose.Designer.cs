namespace winform_cuoi_ki
{
    partial class frmShiftClose
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
            components = new System.ComponentModel.Container();
            tlpRoot = new TableLayoutPanel();
            lblShiftTitle = new Label();
            lblShiftRange = new Label();
            tlpSummary = new TableLayoutPanel();
            lblOrderCountCaption = new Label();
            lblOrderCount = new Label();
            lblCashSalesCaption = new Label();
            lblCashSales = new Label();
            lblTransferSalesCaption = new Label();
            lblTransferSales = new Label();
            lblCardSalesCaption = new Label();
            lblCardSales = new Label();
            lblTotalSalesCaption = new Label();
            lblTotalSales = new Label();
            lblOpeningCashCaption = new Label();
            lblOpeningCash = new Label();
            lblExpectedCashCaption = new Label();
            lblExpectedCash = new Label();
            lblCountedCash = new Label();
            nudCountedCash = new NumericUpDown();
            lblDifference = new Label();
            lblCloseNote = new Label();
            txtCloseNote = new TextBox();
            chkPrintShiftReport = new CheckBox();
            lblDraftWarn = new Label();
            lblShiftCloseError = new Label();
            pnlButtons = new FlowLayoutPanel();
            btnCancel = new Button();
            btnConfirm = new Button();
            erpShiftClose = new ErrorProvider(components);
            tlpRoot.SuspendLayout();
            tlpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCountedCash).BeginInit();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpShiftClose).BeginInit();
            SuspendLayout();
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(lblShiftTitle, 0, 0);
            tlpRoot.Controls.Add(lblShiftRange, 0, 1);
            tlpRoot.Controls.Add(tlpSummary, 0, 2);
            tlpRoot.Controls.Add(lblCountedCash, 0, 3);
            tlpRoot.Controls.Add(nudCountedCash, 0, 4);
            tlpRoot.Controls.Add(lblDifference, 0, 5);
            tlpRoot.Controls.Add(lblCloseNote, 0, 6);
            tlpRoot.Controls.Add(txtCloseNote, 0, 7);
            tlpRoot.Controls.Add(chkPrintShiftReport, 0, 8);
            tlpRoot.Controls.Add(lblDraftWarn, 0, 9);
            tlpRoot.Controls.Add(lblShiftCloseError, 0, 10);
            tlpRoot.Controls.Add(pnlButtons, 0, 11);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(16);
            tlpRoot.RowCount = 12;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            lblShiftTitle.AutoSize = true; lblShiftTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblShiftTitle.Name = "lblShiftTitle"; lblShiftTitle.Text = "Ca #… — …";
            lblShiftRange.AutoSize = true; lblShiftRange.Name = "lblShiftRange"; lblShiftRange.Text = "Mở … → …";
            tlpSummary.ColumnCount = 2;
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpSummary.Dock = DockStyle.Fill;
            tlpSummary.Name = "tlpSummary";
            tlpSummary.RowCount = 7;
            string[] caps = { "Số đơn đã thanh toán", "Doanh thu tiền mặt", "Chuyển khoản", "Thẻ", "Tổng doanh thu", "Tiền đầu ca", "Tiền mặt lý thuyết" };
            Label[] vals = { lblOrderCount, lblCashSales, lblTransferSales, lblCardSales, lblTotalSales, lblOpeningCash, lblExpectedCash };
            Label[] capL = { lblOrderCountCaption, lblCashSalesCaption, lblTransferSalesCaption, lblCardSalesCaption, lblTotalSalesCaption, lblOpeningCashCaption, lblExpectedCashCaption };
            for (int i = 0; i < 7; i++)
            {
                tlpSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
                capL[i].Text = caps[i]; capL[i].AutoSize = true; capL[i].Dock = DockStyle.Fill; capL[i].TextAlign = ContentAlignment.MiddleLeft;
                vals[i].Text = i == 0 ? "0" : "0 đ"; vals[i].Dock = DockStyle.Fill; vals[i].TextAlign = ContentAlignment.MiddleRight;
                if (i == 4 || i == 6) { capL[i].Font = new Font("Segoe UI", 9F, FontStyle.Bold); vals[i].Font = new Font("Segoe UI", 9F, FontStyle.Bold); }
                tlpSummary.Controls.Add(capL[i], 0, i);
                tlpSummary.Controls.Add(vals[i], 1, i);
            }
            lblCountedCash.AutoSize = true; lblCountedCash.Name = "lblCountedCash"; lblCountedCash.Text = "Tiền mặt thực đếm";
            nudCountedCash.Name = "nudCountedCash"; nudCountedCash.Maximum = 100000000; nudCountedCash.ThousandsSeparator = true; nudCountedCash.Anchor = AnchorStyles.Left | AnchorStyles.Right; nudCountedCash.TabIndex = 0; nudCountedCash.ValueChanged += nudCountedCash_ValueChanged;
            lblDifference.AutoSize = true; lblDifference.Name = "lblDifference"; lblDifference.Text = "Chênh lệch: 0 đ";
            lblCloseNote.AutoSize = true; lblCloseNote.Name = "lblCloseNote"; lblCloseNote.Text = "Ghi chú chốt ca";
            txtCloseNote.Name = "txtCloseNote"; txtCloseNote.MaxLength = 300; txtCloseNote.Multiline = true; txtCloseNote.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            chkPrintShiftReport.AutoSize = true; chkPrintShiftReport.Name = "chkPrintShiftReport"; chkPrintShiftReport.Text = "In biên bản chốt ca";
            lblDraftWarn.AutoSize = true; lblDraftWarn.ForeColor = Color.DarkOrange; lblDraftWarn.Name = "lblDraftWarn"; lblDraftWarn.Text = "Còn đơn nháp — không thể chốt ca"; lblDraftWarn.Visible = false;
            lblShiftCloseError.AutoSize = true; lblShiftCloseError.ForeColor = Color.Red; lblShiftCloseError.Name = "lblShiftCloseError"; lblShiftCloseError.Visible = false;
            pnlButtons.Controls.Add(btnCancel); pnlButtons.Controls.Add(btnConfirm);
            pnlButtons.Dock = DockStyle.Fill; pnlButtons.FlowDirection = FlowDirection.RightToLeft; pnlButtons.Name = "pnlButtons";
            btnCancel.Name = "btnCancel"; btnCancel.Size = new Size(100, 36); btnCancel.Text = "Hủy"; btnCancel.UseVisualStyleBackColor = true; btnCancel.Click += btnCancel_Click;
            btnConfirm.Name = "btnConfirm"; btnConfirm.Size = new Size(120, 36); btnConfirm.Text = "Chốt ca"; btnConfirm.UseVisualStyleBackColor = true; btnConfirm.Click += btnConfirm_Click;
            erpShiftClose.ContainerControl = this;
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(520, 520);
            Controls.Add(tlpRoot);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShiftClose";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chốt ca";
            Load += frmShiftClose_Load;
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            tlpSummary.ResumeLayout(false);
            tlpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCountedCash).EndInit();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpShiftClose).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel tlpRoot;
        private Label lblShiftTitle;
        private Label lblShiftRange;
        private TableLayoutPanel tlpSummary;
        private Label lblOrderCountCaption;
        private Label lblOrderCount;
        private Label lblCashSalesCaption;
        private Label lblCashSales;
        private Label lblTransferSalesCaption;
        private Label lblTransferSales;
        private Label lblCardSalesCaption;
        private Label lblCardSales;
        private Label lblTotalSalesCaption;
        private Label lblTotalSales;
        private Label lblOpeningCashCaption;
        private Label lblOpeningCash;
        private Label lblExpectedCashCaption;
        private Label lblExpectedCash;
        private Label lblCountedCash;
        private NumericUpDown nudCountedCash;
        private Label lblDifference;
        private Label lblCloseNote;
        private TextBox txtCloseNote;
        private CheckBox chkPrintShiftReport;
        private Label lblDraftWarn;
        private Label lblShiftCloseError;
        private FlowLayoutPanel pnlButtons;
        private Button btnConfirm;
        private Button btnCancel;
        private ErrorProvider erpShiftClose;
    }
}
