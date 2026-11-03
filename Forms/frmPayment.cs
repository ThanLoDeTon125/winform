using System;
using System.Globalization;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmPayment : Form
    {
        private decimal _amountDue;

        public decimal AmountReceived { get; private set; }
        public decimal ChangeAmount { get; private set; }
        public string PaymentMethod => cboPaymentMethod.SelectedItem?.ToString() ?? "Tiền mặt";
        public string PayNote => txtPayNote.Text.Trim();
        public bool PrintReceipt => chkPrintReceipt.Checked;

        public frmPayment()
        {
            InitializeComponent();
        }

        public void SetAmountDue(decimal amount)
        {
            _amountDue = amount;
            lblAmountDue.Text = amount.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblPayError.Visible = false;
            if (cboPaymentMethod.Items.Count > 0)
                cboPaymentMethod.SelectedIndex = 0;
            ApplyMethodUi();
            txtAmountReceived.Focus();
        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e) => ApplyMethodUi();

        private void ApplyMethodUi()
        {
            var cash = cboPaymentMethod.SelectedItem?.ToString() == "Tiền mặt";
            txtAmountReceived.Enabled = cash;
            flpQuickCash.Visible = cash;
            if (!cash)
            {
                txtAmountReceived.Text = _amountDue.ToString("0");
                lblChange.Text = "0 đ";
            }
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e) => RecalcChange();

        private void RecalcChange()
        {
            if (!decimal.TryParse(txtAmountReceived.Text.Replace(".", "").Replace(",", ""), out var received))
            {
                lblChange.Text = "0 đ";
                return;
            }
            var change = received - _amountDue;
            lblChange.Text = (change < 0 ? 0 : change).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
        }

        private void SetReceived(decimal value)
        {
            txtAmountReceived.Text = value.ToString("0");
            RecalcChange();
        }

        private void btnCashExact_Click(object sender, EventArgs e) => SetReceived(_amountDue);
        private void btnCash50_Click(object sender, EventArgs e) => SetReceived(50000);
        private void btnCash100_Click(object sender, EventArgs e) => SetReceived(100000);
        private void btnCash200_Click(object sender, EventArgs e) => SetReceived(200000);
        private void btnCash500_Click(object sender, EventArgs e) => SetReceived(500000);

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblPayError.Visible = false;
            erpPay.Clear();
            var cash = PaymentMethod == "Tiền mặt";
            if (cash)
            {
                if (!decimal.TryParse(txtAmountReceived.Text.Replace(".", "").Replace(",", ""), out var received) || received < _amountDue)
                {
                    lblPayError.Text = "Tiền khách không đủ";
                    lblPayError.Visible = true;
                    erpPay.SetError(txtAmountReceived, "Tiền khách không đủ");
                    return;
                }
                AmountReceived = received;
                ChangeAmount = received - _amountDue;
            }
            else
            {
                AmountReceived = _amountDue;
                ChangeAmount = 0;
            }
            // TODO: caller BLL — không trừ kho trên Form
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
