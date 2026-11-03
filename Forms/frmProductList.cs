using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            // TODO: bind cboCategoryFilter + dgvProducts
            lblCount.Text = "0 sản phẩm";
        }

        private void btnSearch_Click(object sender, EventArgs e) { /* TODO */ }
        private void btnRefresh_Click(object sender, EventArgs e) { /* TODO */ }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var dlg = new frmProductEdit();
            if (dlg.ShowDialog(this) == DialogResult.OK) { /* TODO: refresh */ }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) { MessageBox.Show("Chọn một sản phẩm."); return; }
            using var dlg = new frmProductEdit();
            dlg.ShowDialog(this);
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnEdit_Click(sender, e);
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: ngưng/mở bán (BLL).", "Thực đơn");
        }
    }
}
