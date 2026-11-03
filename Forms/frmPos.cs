using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmPos : Form
    {
        public frmPos()
        {
            InitializeComponent();
        }

        private void frmPos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            // TODO: kiểm tra ca mở; bind NV/ca; load danh mục + món
            lblCashier.Text = "NV: …";
            lblShift.Text = "Ca: …";
            UpdateClock();
            tmrPosClock.Start();

            if (splPos.Width > 0)
                splPos.SplitterDistance = (int)(splPos.Width * 0.62);

            btnCatAll.Click += (_, _) => MessageBox.Show("TODO: lọc Tất cả", "POS");
            ucProductGrid.ProductSelected += UcProductGrid_ProductSelected;
            WireCartEvents();
        }

        private void WireCartEvents()
        {
            ucCartPanel.RequestPay += (_, _) =>
            {
                using var pay = new frmPayment();
                pay.SetAmountDue(0m); // TODO: lấy tổng từ giỏ
                if (pay.ShowDialog(this) == DialogResult.OK)
                    MessageBox.Show("TODO: thanh toán BLL + clear giỏ", "POS");
            };
            ucCartPanel.RequestCancelOrder += (_, _) =>
            {
                if (MessageBox.Show("Hủy đơn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    MessageBox.Show("TODO: hủy Draft", "POS");
            };
            ucCartPanel.QtyPlus += (_, _) => { /* TODO */ };
            ucCartPanel.QtyMinus += (_, _) => { /* TODO */ };
            ucCartPanel.LineRemoved += (_, _) => { /* TODO */ };
            ucCartPanel.RequestLineNote += (_, _) => MessageBox.Show("TODO: ghi chú dòng", "POS");
            ucCartPanel.RequestSizeTopping += (_, _) => MessageBox.Show("TODO: size/topping", "POS");
            ucCartPanel.RequestFindCustomer += (_, _) => MessageBox.Show("TODO: tìm khách", "POS");
            ucCartPanel.RequestDiscount += (_, _) => MessageBox.Show("TODO: giảm giá", "POS");
        }

        private void UcProductGrid_ProductSelected(object? sender, object e)
        {
            // TODO: thêm vào giỏ
            MessageBox.Show("TODO: thêm món vào giỏ", "POS");
        }

        private void tmrPosClock_Tick(object sender, EventArgs e) => UpdateClock();

        private void UpdateClock() => lblClock.Text = DateTime.Now.ToString("HH:mm:ss");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtProductFilter.Focus();
        }

        private void txtProductFilter_TextChanged(object sender, EventArgs e)
        {
            // TODO: lọc lưới món
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Về menu chính?", "POS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tmrPosClock.Stop();
                Close();
            }
        }

        private void frmPos_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPosClock.Stop();
        }
    }
}
