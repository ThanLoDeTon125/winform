using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            lblCount.Text = "0 dòng";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Thêm — gọi BLL.", "Hóa đơn");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Sửa — gọi BLL.", "Hóa đơn");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Xóa — gọi BLL.", "Hóa đơn");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Làm mới — gọi BLL.", "Hóa đơn");
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Tìm — gọi BLL.", "Hóa đơn");
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Xem chi tiết.", "Hóa đơn");
        }
    }
}
