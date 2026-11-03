namespace winform_cuoi_ki
{
    partial class frmReports
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
            pnlReportParams = new Panel();
            tlpParams = new TableLayoutPanel();
            lblReportType = new Label();
            cboReportType = new ComboBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            lblShiftFilter = new Label();
            cboShiftFilter = new ComboBox();
            lblCategoryFilter = new Label();
            cboCategoryFilter = new ComboBox();
            btnRun = new Button();
            btnPrintPreview = new Button();
            btnExportExcel = new Button();
            lblReportTitle = new Label();
            dgvReport = new DataGridView();
            pnlReportFooter = new Panel();
            lblReportSummary = new Label();
            stsReport = new StatusStrip();
            lblReportHint = new ToolStripStatusLabel();
            pnlReportParams.SuspendLayout();
            tlpParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            pnlReportFooter.SuspendLayout();
            stsReport.SuspendLayout();
            SuspendLayout();
            pnlReportParams.Controls.Add(tlpParams);
            pnlReportParams.Dock = DockStyle.Top;
            pnlReportParams.Name = "pnlReportParams";
            pnlReportParams.Size = new Size(1100, 100);
            tlpParams.ColumnCount = 6;
            for (int i = 0; i < 6; i++) tlpParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            tlpParams.Controls.Add(lblReportType, 0, 0);
            tlpParams.Controls.Add(cboReportType, 1, 0);
            tlpParams.SetColumnSpan(cboReportType, 3);
            tlpParams.Controls.Add(lblFrom, 0, 1);
            tlpParams.Controls.Add(dtpFrom, 1, 1);
            tlpParams.Controls.Add(lblTo, 2, 1);
            tlpParams.Controls.Add(dtpTo, 3, 1);
            tlpParams.Controls.Add(lblShiftFilter, 4, 1);
            tlpParams.Controls.Add(cboShiftFilter, 5, 1);
            tlpParams.Controls.Add(lblCategoryFilter, 0, 2);
            tlpParams.Controls.Add(cboCategoryFilter, 1, 2);
            tlpParams.Controls.Add(btnRun, 2, 2);
            tlpParams.Controls.Add(btnPrintPreview, 3, 2);
            tlpParams.Controls.Add(btnExportExcel, 4, 2);
            tlpParams.Dock = DockStyle.Fill;
            tlpParams.Name = "tlpParams";
            tlpParams.Padding = new Padding(8);
            tlpParams.RowCount = 3;
            tlpParams.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tlpParams.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tlpParams.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            lblReportType.Text = "Loại báo cáo"; lblReportType.AutoSize = true; lblReportType.Anchor = AnchorStyles.Left; lblReportType.Name = "lblReportType";
            cboReportType.DropDownStyle = ComboBoxStyle.DropDownList; cboReportType.Anchor = AnchorStyles.Left | AnchorStyles.Right; cboReportType.Name = "cboReportType";
            cboReportType.Items.AddRange(new object[] {
                "Doanh thu theo ngày", "Doanh thu theo khoảng ngày", "Doanh thu theo ca",
                "Doanh thu theo phương thức thanh toán", "Doanh thu theo món / danh mục",
                "Top bán chạy", "Tồn kho nguyên liệu", "Nguyên liệu dưới mức tối thiểu" });
            cboReportType.SelectedIndexChanged += cboReportType_SelectedIndexChanged;
            lblFrom.Text = "Từ ngày"; lblFrom.AutoSize = true; lblFrom.Name = "lblFrom";
            dtpFrom.Format = DateTimePickerFormat.Short; dtpFrom.Name = "dtpFrom";
            lblTo.Text = "Đến ngày"; lblTo.AutoSize = true; lblTo.Name = "lblTo";
            dtpTo.Format = DateTimePickerFormat.Short; dtpTo.Name = "dtpTo";
            lblShiftFilter.Text = "Ca"; lblShiftFilter.AutoSize = true; lblShiftFilter.Name = "lblShiftFilter";
            cboShiftFilter.DropDownStyle = ComboBoxStyle.DropDownList; cboShiftFilter.Items.Add("Tất cả"); cboShiftFilter.Name = "cboShiftFilter"; cboShiftFilter.SelectedIndex = 0;
            lblCategoryFilter.Text = "Danh mục"; lblCategoryFilter.AutoSize = true; lblCategoryFilter.Name = "lblCategoryFilter";
            cboCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList; cboCategoryFilter.Items.Add("Tất cả"); cboCategoryFilter.Name = "cboCategoryFilter"; cboCategoryFilter.SelectedIndex = 0;
            btnRun.Name = "btnRun"; btnRun.Size = new Size(110, 28); btnRun.Text = "Xem báo cáo"; btnRun.UseVisualStyleBackColor = true; btnRun.Click += btnRun_Click;
            btnPrintPreview.Name = "btnPrintPreview"; btnPrintPreview.Size = new Size(110, 28); btnPrintPreview.Text = "In xem trước"; btnPrintPreview.UseVisualStyleBackColor = true; btnPrintPreview.Click += btnPrintPreview_Click;
            btnExportExcel.Name = "btnExportExcel"; btnExportExcel.Size = new Size(100, 28); btnExportExcel.Text = "Xuất Excel"; btnExportExcel.Enabled = false; btnExportExcel.UseVisualStyleBackColor = true; btnExportExcel.Click += btnExportExcel_Click;
            lblReportTitle.Dock = DockStyle.Top; lblReportTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblReportTitle.Height = 28; lblReportTitle.Name = "lblReportTitle"; lblReportTitle.Padding = new Padding(8, 4, 0, 0);
            dgvReport.AllowUserToAddRows = false; dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dgvReport.Dock = DockStyle.Fill; dgvReport.Name = "dgvReport"; dgvReport.ReadOnly = true; dgvReport.RowHeadersVisible = false;
            pnlReportFooter.Controls.Add(lblReportSummary); pnlReportFooter.Dock = DockStyle.Bottom; pnlReportFooter.Name = "pnlReportFooter"; pnlReportFooter.Size = new Size(1100, 40);
            lblReportSummary.AutoSize = true; lblReportSummary.Location = new Point(12, 12); lblReportSummary.Name = "lblReportSummary"; lblReportSummary.Text = "Tổng: …";
            stsReport.Items.AddRange(new ToolStripItem[] { lblReportHint }); stsReport.Name = "stsReport"; stsReport.Dock = DockStyle.Bottom;
            lblReportHint.Name = "lblReportHint"; lblReportHint.Spring = true; lblReportHint.Text = "Chọn loại báo cáo rồi bấm Xem";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 680);
            Controls.Add(dgvReport);
            Controls.Add(lblReportTitle);
            Controls.Add(pnlReportFooter);
            Controls.Add(pnlReportParams);
            Controls.Add(stsReport);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(900, 560);
            Name = "frmReports";
            Text = "Báo cáo";
            Load += frmReports_Load;
            pnlReportParams.ResumeLayout(false);
            tlpParams.ResumeLayout(false);
            tlpParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            pnlReportFooter.ResumeLayout(false);
            pnlReportFooter.PerformLayout();
            stsReport.ResumeLayout(false);
            stsReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel pnlReportParams;
        private TableLayoutPanel tlpParams;
        private Label lblReportType;
        private ComboBox cboReportType;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Label lblShiftFilter;
        private ComboBox cboShiftFilter;
        private Label lblCategoryFilter;
        private ComboBox cboCategoryFilter;
        private Button btnRun;
        private Button btnPrintPreview;
        private Button btnExportExcel;
        private Label lblReportTitle;
        private DataGridView dgvReport;
        private Panel pnlReportFooter;
        private Label lblReportSummary;
        private StatusStrip stsReport;
        private ToolStripStatusLabel lblReportHint;
    }
}
