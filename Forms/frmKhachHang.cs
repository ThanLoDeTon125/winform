using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            lblCount.Text = "0 dòng";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Thêm — gọi BLL.", "Khách hàng");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Sửa — gọi BLL.", "Khách hàng");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Xóa — gọi BLL.", "Khách hàng");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Làm mới — gọi BLL.", "Khách hàng");
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Tìm — gọi BLL.", "Khách hàng");
        }
    }
}
