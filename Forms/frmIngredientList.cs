using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmIngredientList : Form
    {
        public frmIngredientList()
        {
            InitializeComponent();
        }

        private void frmIngredientList_Load(object sender, EventArgs e)
        {
            lblIngCount.Text = "0 nguyên liệu";
            lblBelowMinHint.Text = "0 dưới mức min";
        }

        private void btnSearch_Click(object sender, EventArgs e) { /* TODO */ }
        private void btnRefresh_Click(object sender, EventArgs e) { /* TODO */ }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCode.Clear(); txtName.Clear(); nudMinStock.Value = 0;
            chkIsActive.Checked = true; lblQtyOnHand.Text = "0"; txtName.Focus();
        }
        private void btnEdit_Click(object sender, EventArgs e) => txtName.Focus();
        private void btnOpenStockIn_Click(object sender, EventArgs e)
        {
            using var f = new frmStockIn();
            f.ShowDialog(this);
        }
        private void btnOpenStockAdjust_Click(object sender, EventArgs e)
        {
            using var f = new frmStockAdjust();
            f.ShowDialog(this);
        }
        private void chkOnlyBelowMin_CheckedChanged(object sender, EventArgs e) { /* TODO filter */ }
        private void dgvIngredients_SelectionChanged(object sender, EventArgs e) { /* TODO bind */ }
        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            erpIng.Clear();
            if (string.IsNullOrWhiteSpace(txtName.Text)) { erpIng.SetError(txtName, "Nhập tên"); return; }
            MessageBox.Show("TODO: lưu nguyên liệu (BLL).", "Kho");
        }
    }
}
