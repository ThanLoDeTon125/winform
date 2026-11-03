using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            lblTong.Text = "0 đ";
            // TODO: load danh mục + món đang bán
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: thêm món đang chọn vào giỏ (BLL).", "Bán hàng");
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvGio.CurrentRow != null)
                dgvGio.Rows.Remove(dgvGio.CurrentRow);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvGio.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ trống.");
                return;
            }
            MessageBox.Show("TODO: lưu DonHang + ChiTietDonHang + ThanhToan + trừ kho theo CongThuc.", "Thanh toán");
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy đơn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvGio.Rows.Clear();
                lblTong.Text = "0 đ";
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}
