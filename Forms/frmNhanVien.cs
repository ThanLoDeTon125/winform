using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            lblCount.Text = "0 dòng";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Thêm — gọi BLL.", "Nhân viên");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Sửa — gọi BLL.", "Nhân viên");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Xóa — gọi BLL.", "Nhân viên");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Làm mới — gọi BLL.", "Nhân viên");
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Tìm — gọi BLL.", "Nhân viên");
        }
    }
}
