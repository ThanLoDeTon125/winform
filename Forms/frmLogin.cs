using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            erpLogin.Clear();
            lblError.Visible = false;
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                erpLogin.SetError(txtUsername, "Nhập tên đăng nhập");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                erpLogin.SetError(txtPassword, "Nhập mật khẩu");
                return;
            }
            // TODO: gọi auth BLL
            MessageBox.Show("TODO: xác thực đăng nhập (BLL).", "Đăng nhập",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
