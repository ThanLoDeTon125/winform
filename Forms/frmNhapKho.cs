using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmNhapKho : Form
    {
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            lblCount.Text = "0 dòng";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Thêm — gọi BLL.", "Nhập kho");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Sửa — gọi BLL.", "Nhập kho");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Xóa — gọi BLL.", "Nhập kho");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Làm mới — gọi BLL.", "Nhập kho");
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Tìm — gọi BLL.", "Nhập kho");
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Xác nhận nhập.", "Nhập kho");
        }
    }
}
