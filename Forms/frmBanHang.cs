using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    /// <summary>
    /// Dialog POS (cùng layout Counter-Service với frmMain).
    /// Form chính sau login vẫn là frmMain; form này dùng khi cần mở POS riêng.
    /// </summary>
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
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

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}
