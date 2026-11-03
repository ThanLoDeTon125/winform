using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            lblTrangThai.Text = "Sẵn sàng — TODO: hiện NV / ca";
        }

        private void ShowChild(Form child)
        {
            pnlContent.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(child);
            child.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            using var f = new frmBanHang();
            f.ShowDialog(this);
        }

        private void btnSanPham_Click(object sender, EventArgs e) => ShowChild(new frmSanPham());
        private void btnDanhMuc_Click(object sender, EventArgs e) => ShowChild(new frmDanhMuc());
        private void btnNguyenLieu_Click(object sender, EventArgs e) => ShowChild(new frmNguyenLieu());
        private void btnNhapKho_Click(object sender, EventArgs e) => ShowChild(new frmNhapKho());
        private void btnHoaDon_Click(object sender, EventArgs e) => ShowChild(new frmHoaDon());
        private void btnNhanVien_Click(object sender, EventArgs e) => ShowChild(new frmNhanVien());
        private void btnKhachHang_Click(object sender, EventArgs e) => ShowChild(new frmKhachHang());

        private void btnMoCa_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: mở ca (bảng CaLamViec).", "Ca làm việc");

        private void btnChotCa_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: chốt ca.", "Ca làm việc");

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}
