using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            if (cboReportType.Items.Count > 0) cboReportType.SelectedIndex = 0;
            ApplyFilterVisibility();
        }

        private void cboReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterVisibility();
            dgvReport.DataSource = null;
            lblReportTitle.Text = "";
            lblReportSummary.Text = "";
        }

        private void ApplyFilterVisibility()
        {
            var t = cboReportType.SelectedItem?.ToString() ?? "";
            var needShift = t.Contains("ca");
            var needCat = t.Contains("món") || t.Contains("danh mục") || t.Contains("Top");
            lblShiftFilter.Visible = cboShiftFilter.Visible = needShift;
            lblCategoryFilter.Visible = cboCategoryFilter.Visible = needCat;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("Từ ngày phải ≤ Đến ngày.");
                return;
            }
            lblReportTitle.Text = $"{cboReportType.Text} ({dtpFrom.Value:dd/MM/yyyy} – {dtpTo.Value:dd/MM/yyyy})";
            lblReportSummary.Text = "Tổng: …";
            lblReportHint.Text = "TODO: BLL chạy báo cáo và bind dgvReport";
            MessageBox.Show("TODO: BLL trả DataTable/DTO → bind grid.", "Báo cáo");
        }

        private void btnPrintPreview_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: PrintPreview sau khi đã Xem báo cáo.", "Báo cáo");

        private void btnExportExcel_Click(object sender, EventArgs e) =>
            MessageBox.Show("Sẽ có ở giai đoạn sau.", "Xuất Excel");
    }
}
