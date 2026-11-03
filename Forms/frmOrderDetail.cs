using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmOrderDetail : Form
    {
        public int? OrderId { get; set; }

        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            // TODO: BLL load order
            Text = OrderId.HasValue ? $"Chi tiết đơn #{OrderId}" : "Chi tiết đơn";
            lblOrderNo.Text = "Số đơn: …";
            lblOrderTime.Text = "Thời gian: …";
            lblStatus.Text = "Trạng thái: …";
            lblCashier.Text = "Thu ngân: …";
            lblShift.Text = "Ca: …";
            lblCustomer.Text = "Khách: …";
        }

        private void btnReprint_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: in lại hóa đơn.", "Chi tiết đơn");

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy đơn đã thanh toán? Thao tác nhạy cảm.", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            MessageBox.Show("TODO: BLL hủy đơn + hoàn kho.", "Chi tiết đơn");
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
