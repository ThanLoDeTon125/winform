using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmOrderHistory : Form
    {
        public frmOrderHistory()
        {
            InitializeComponent();
        }

        private void frmOrderHistory_Load(object sender, EventArgs e) => btnToday_Click(sender, e);

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            // TODO: search
            lblOrderCount.Text = "0 đơn";
            lblRevenue.Text = "Doanh thu lọc: 0 đ";
        }

        private void btnSearch_Click(object sender, EventArgs e) { /* TODO */ }
        private void btnRefresh_Click(object sender, EventArgs e) => btnSearch_Click(sender, e);

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) { MessageBox.Show("Chọn một đơn."); return; }
            using var dlg = new frmOrderDetail();
            dlg.ShowDialog(this);
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnViewDetail_Click(sender, e);
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: in lại hóa đơn.", "Đơn hàng");
        }
    }
}
