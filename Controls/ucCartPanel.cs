using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class ucCartPanel : UserControl
    {
        public event EventHandler? QtyPlus;
        public event EventHandler? QtyMinus;
        public event EventHandler? LineRemoved;
        public event EventHandler? RequestLineNote;
        public event EventHandler? RequestSizeTopping;
        public event EventHandler? RequestFindCustomer;
        public event EventHandler? RequestClearCustomer;
        public event EventHandler? RequestDiscount;
        public event EventHandler? RequestPay;
        public event EventHandler? RequestCancelOrder;

        public ucCartPanel()
        {
            InitializeComponent();
        }

        public void SetCustomer(string displayName)
        {
            lblCustomerName.Text = string.IsNullOrWhiteSpace(displayName) ? "Chưa gắn khách" : displayName;
        }

        public void SetTotals(string subTotal, string discount, string tax, string total)
        {
            lblSubTotal.Text = subTotal;
            lblDiscount.Text = discount;
            lblTax.Text = tax;
            lblTotal.Text = total;
        }

        public void SetDiscountButtonVisible(bool visible) => btnDiscount.Visible = visible;
        public void SetTaxVisible(bool visible)
        {
            lblTaxCaption.Visible = visible;
            lblTax.Visible = visible;
        }

        private void btnQtyPlus_Click(object sender, EventArgs e) => QtyPlus?.Invoke(this, EventArgs.Empty);
        private void btnQtyMinus_Click(object sender, EventArgs e) => QtyMinus?.Invoke(this, EventArgs.Empty);
        private void btnRemoveLine_Click(object sender, EventArgs e) => LineRemoved?.Invoke(this, EventArgs.Empty);
        private void btnLineNote_Click(object sender, EventArgs e) => RequestLineNote?.Invoke(this, EventArgs.Empty);
        private void btnSizeTopping_Click(object sender, EventArgs e) => RequestSizeTopping?.Invoke(this, EventArgs.Empty);
        private void btnFindCustomer_Click(object sender, EventArgs e) => RequestFindCustomer?.Invoke(this, EventArgs.Empty);
        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            SetCustomer("");
            RequestClearCustomer?.Invoke(this, EventArgs.Empty);
        }
        private void btnDiscount_Click(object sender, EventArgs e) => RequestDiscount?.Invoke(this, EventArgs.Empty);
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống.", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RequestPay?.Invoke(this, EventArgs.Empty);
        }
        private void btnCancelOrder_Click(object sender, EventArgs e) => RequestCancelOrder?.Invoke(this, EventArgs.Empty);
    }
}
