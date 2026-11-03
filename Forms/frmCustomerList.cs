using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            lblCustCount.Text = "0 khách";
            if (cboTier.Items.Count > 0) cboTier.SelectedIndex = 0;
            ApplyMemberUi();
        }

        private void chkIsMember_CheckedChanged(object sender, EventArgs e) => ApplyMemberUi();

        private void ApplyMemberUi() => cboTier.Enabled = chkIsMember.Checked;

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e) { /* TODO bind */ }
        private void btnSearch_Click(object sender, EventArgs e) { /* TODO */ }
        private void btnRefresh_Click(object sender, EventArgs e) { /* TODO */ }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFullName.Clear(); txtPhone.Clear(); txtNote.Clear();
            chkIsMember.Checked = true; lblPoints.Text = "0";
            lblLastVisit.Text = "Mua gần nhất: —";
            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            erpCust.Clear();
            if (string.IsNullOrWhiteSpace(txtFullName.Text)) { erpCust.SetError(txtFullName, "Nhập họ tên"); return; }
            if (string.IsNullOrWhiteSpace(txtPhone.Text)) { erpCust.SetError(txtPhone, "Nhập SĐT"); return; }
            MessageBox.Show("TODO: BLL lưu khách (điểm không sửa tay).", "Khách hàng");
        }
    }
}
