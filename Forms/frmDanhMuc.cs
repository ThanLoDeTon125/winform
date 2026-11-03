using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            lblCount.Text = "0 dòng";
            // TODO: load lưới từ BLL
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Thêm — gọi BLL.", "Danh mục");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Sửa — gọi BLL.", "Danh mục");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Xóa — gọi BLL.", "Danh mục");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Làm mới — gọi BLL.", "Danh mục");
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Tìm — gọi BLL.", "Danh mục");
        }
    }
}
