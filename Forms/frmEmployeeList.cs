using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmEmployeeList : Form
    {
        private bool _passwordMode;

        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            SetPasswordVisible(false);
            lblEmpCount.Text = "0 nhân viên";
            if (cboRole.Items.Count > 0) cboRole.SelectedIndex = 0;
        }

        private void SetPasswordVisible(bool visible)
        {
            _passwordMode = visible;
            lblPassword.Visible = visible;
            txtPassword.Visible = visible;
            lblPasswordConfirm.Visible = visible;
            txtPasswordConfirm.Visible = visible;
            if (!visible)
            {
                txtPassword.Clear();
                txtPasswordConfirm.Clear();
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e) => SetPasswordVisible(false);
        private void btnSearch_Click(object sender, EventArgs e) { /* TODO */ }
        private void btnRefresh_Click(object sender, EventArgs e) { /* TODO */ }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFullName.Clear(); txtPhone.Clear(); txtUsername.Clear(); txtNote.Clear();
            chkIsActive.Checked = true;
            SetPasswordVisible(true);
            txtFullName.Focus();
        }

        private void btnResetPassword_Click(object sender, EventArgs e) => SetPasswordVisible(true);

        private void btnSave_Click(object sender, EventArgs e)
        {
            erpEmp.Clear();
            if (string.IsNullOrWhiteSpace(txtFullName.Text)) { erpEmp.SetError(txtFullName, "Nhập họ tên"); return; }
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) { erpEmp.SetError(txtUsername, "Nhập tên đăng nhập"); return; }
            if (_passwordMode)
            {
                if (txtPassword.Text.Length < 4) { erpEmp.SetError(txtPassword, "Mật khẩu quá ngắn"); return; }
                if (txtPassword.Text != txtPasswordConfirm.Text) { erpEmp.SetError(txtPasswordConfirm, "Không khớp"); return; }
            }
            MessageBox.Show("TODO: BLL lưu NV (hash mật khẩu).", "Nhân viên");
        }

        private void btnToggleLock_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: khóa/mở tài khoản.", "Nhân viên");
    }
}
