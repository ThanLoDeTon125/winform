using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmStockAdjust : Form
    {
        private decimal _systemQty;

        public frmStockAdjust()
        {
            InitializeComponent();
        }

        public void SetIngredient(object? id)
        {
            // TODO: preselect combo from id
        }

        private void frmStockAdjust_Load(object sender, EventArgs e)
        {
            lblAdjustError.Visible = false;
            txtReasonOther.Visible = false;
            rdoByCounted.Checked = true;
            ApplyMode();
            if (cboReason.Items.Count > 0) cboReason.SelectedIndex = 0;
        }

        private void cboIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: load system qty + unit
            lblUnitValue.Text = "g";
            _systemQty = 0;
            lblSystemQtyValue.Text = "0";
            RecalcResult();
        }

        private void rdoByCounted_CheckedChanged(object sender, EventArgs e) => ApplyMode();
        private void rdoByDelta_CheckedChanged(object sender, EventArgs e) => ApplyMode();

        private void ApplyMode()
        {
            nudCountedQty.Enabled = rdoByCounted.Checked;
            nudDeltaQty.Enabled = rdoByDelta.Checked;
            RecalcResult();
        }

        private void nudCountedQty_ValueChanged(object sender, EventArgs e) => RecalcResult();
        private void nudDeltaQty_ValueChanged(object sender, EventArgs e) => RecalcResult();

        private void RecalcResult()
        {
            decimal result = rdoByCounted.Checked ? nudCountedQty.Value : _systemQty + nudDeltaQty.Value;
            lblResultQty.Text = $"Tồn sau điều chỉnh: {result}";
            if (result < 0) lblResultQty.ForeColor = System.Drawing.Color.Red;
            else lblResultQty.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void cboReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReasonOther.Visible = cboReason.SelectedItem?.ToString() == "Khác";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblAdjustError.Visible = false;
            erpAdjust.Clear();
            if (cboIngredient.SelectedItem == null)
            {
                erpAdjust.SetError(cboIngredient, "Chọn nguyên liệu");
                return;
            }
            if (cboReason.SelectedItem?.ToString() == "Khác" && string.IsNullOrWhiteSpace(txtReasonOther.Text))
            {
                erpAdjust.SetError(txtReasonOther, "Nhập lý do");
                return;
            }
            MessageBox.Show("TODO: BLL điều chỉnh tồn + audit.", "Điều chỉnh tồn");
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
