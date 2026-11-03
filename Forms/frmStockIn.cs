using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmStockIn : Form
    {
        public frmStockIn()
        {
            InitializeComponent();
        }

        private void frmStockIn_Load(object sender, EventArgs e)
        {
            dtpStockInDate.Value = DateTime.Today;
            lblStockInError.Visible = false;
            lblGrandTotal.Text = "0 đ";
            // TODO: bind cboIngredient
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (cboIngredient.SelectedItem == null || nudQty.Value <= 0)
            {
                MessageBox.Show("Chọn nguyên liệu và số lượng > 0.");
                return;
            }
            var amount = nudQty.Value * nudUnitCost.Value;
            dgvStockInLines.Rows.Add(cboIngredient.Text, "", nudQty.Value, nudUnitCost.Value, amount);
            RecalcTotal();
        }

        private void btnRemoveLine_Click(object sender, EventArgs e)
        {
            if (dgvStockInLines.CurrentRow != null)
            {
                dgvStockInLines.Rows.Remove(dgvStockInLines.CurrentRow);
                RecalcTotal();
            }
        }

        private void RecalcTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvStockInLines.Rows)
            {
                if (row.Cells[colLineAmount.Index].Value != null &&
                    decimal.TryParse(row.Cells[colLineAmount.Index].Value.ToString(), out var v))
                    total += v;
            }
            lblGrandTotal.Text = $"{total:N0} đ";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblStockInError.Visible = false;
            if (dgvStockInLines.Rows.Count == 0)
            {
                lblStockInError.Text = "Chưa có dòng nhập";
                lblStockInError.Visible = true;
                return;
            }
            if (MessageBox.Show("Xác nhận nhập kho?", "Nhập kho", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            MessageBox.Show("TODO: BLL transaction nhập kho.", "Nhập kho");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvStockInLines.Rows.Count > 0 &&
                MessageBox.Show("Bỏ phiếu nhập?", "Hủy", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            Close();
        }
    }
}
