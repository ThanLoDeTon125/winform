using System;
using System.Drawing;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmShiftClose : Form
    {
        private decimal _expectedCash;

        public frmShiftClose()
        {
            InitializeComponent();
        }

        private void frmShiftClose_Load(object sender, EventArgs e)
        {
            lblShiftCloseError.Visible = false;
            lblDraftWarn.Visible = false;
            // TODO: BLL tổng hợp ca
            lblShiftTitle.Text = "Ca #… — …";
            lblShiftRange.Text = $"Mở … → {DateTime.Now:HH:mm}";
            _expectedCash = 0;
            nudCountedCash.Value = 0;
            UpdateDifference();
        }

        private void nudCountedCash_ValueChanged(object sender, EventArgs e) => UpdateDifference();

        private void UpdateDifference()
        {
            var diff = nudCountedCash.Value - _expectedCash;
            lblDifference.Text = $"Chênh lệch: {diff:N0} đ";
            lblDifference.ForeColor = diff == 0 ? SystemColors.ControlText : Color.Red;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận chốt ca?", "Chốt ca", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            MessageBox.Show("TODO: BLL CloseShift" + (chkPrintShiftReport.Checked ? " + in biên bản" : "") + ".", "Chốt ca");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
