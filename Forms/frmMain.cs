using System;
using System.Drawing;
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
            lblMaDon.Text = "Đơn hàng: HD" + DateTime.Now.ToString("yyyyMMddHHmm");
            if (cboLoaiDon.Items.Count > 0)
                cboLoaiDon.SelectedIndex = 0;
            CapNhatTongTien();
            // TODO: load món vào flpMon từ BLL
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[colThanhTien.Index].Value != null &&
                    decimal.TryParse(row.Cells[colThanhTien.Index].Value.ToString(), out var v))
                    tong += v;
            }

            decimal giam = nudGiamGia.Value;
            decimal phaiTra = tong * (1 - giam / 100m);
            if (phaiTra < 0) phaiTra = 0;

            lblTongTienHang.Text = tong.ToString("N0") + " đ";
            lblKhachCanTra.Text = phaiTra.ToString("N0") + " đ";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // TODO: lọc nút món theo tên
        }

        private void btnDonMoi_Click(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
            txtGhiChu.Clear();
            nudGiamGia.Value = 0;
            lblMaDon.Text = "Đơn hàng: HD" + DateTime.Now.ToString("yyyyMMddHHmm");
            CapNhatTongTien();
        }

        private void nudGiamGia_ValueChanged(object sender, EventArgs e) => CapNhatTongTien();

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có món trong hóa đơn.", "Thanh toán",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("TODO: lưu đơn + thanh toán (BLL).", "Thanh toán");
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null && !dgvHoaDon.CurrentRow.IsNewRow)
            {
                dgvHoaDon.Rows.Remove(dgvHoaDon.CurrentRow);
                CapNhatTongTien();
            }
        }

        // ===== Menu =====
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất?", "Hệ thống", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void mnuThoat_Click(object sender, EventArgs e) => Application.Exit();

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            using var f = new frmSanPham();
            f.ShowDialog(this);
        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {
            using var f = new frmDanhMuc();
            f.ShowDialog(this);
        }

        private void mnuNguyenLieu_Click(object sender, EventArgs e)
        {
            using var f = new frmNguyenLieu();
            f.ShowDialog(this);
        }

        private void mnuNhapKho_Click(object sender, EventArgs e)
        {
            using var f = new frmNhapKho();
            f.ShowDialog(this);
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            using var f = new frmHoaDon();
            f.ShowDialog(this);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            using var f = new frmNhanVien();
            f.ShowDialog(this);
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            using var f = new frmKhachHang();
            f.ShowDialog(this);
        }

        private void mnuMoCa_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: mở ca (CaLamViec).", "Ca làm việc");

        private void mnuChotCa_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: chốt ca.", "Ca làm việc");

        private void mnuTroGiup_Click(object sender, EventArgs e) =>
            MessageBox.Show("Cafe Win — POS tại quầy\n15 bảng / 10 form", "Trợ giúp");
    }
}
