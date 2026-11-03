using System;
using System.Drawing;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmMain : Form
    {
        private Button? _activeNav;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            // TODO: đọc session → lblUserRole, lblStoreName; ApplyRoleToNav
            lblStoreName.Text = "Cửa hàng Demo";
            lblUserRole.Text = "Người dùng — Vai trò";
            lblShiftInfo.Text = "Chưa mở ca";
            btnOpenShift.Visible = true;
            btnCloseShift.Visible = false;
            tmrClock.Start();
            UpdateClock();
        }

        private void tmrClock_Tick(object sender, EventArgs e) => UpdateClock();

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void HighlightNav(Button btn)
        {
            if (_activeNav != null)
                _activeNav.BackColor = SystemColors.Control;
            _activeNav = btn;
            btn.BackColor = Color.FromArgb(220, 210, 200);
        }

        private void ShowContent(Form child)
        {
            pnlContent.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(child);
            child.Show();
        }

        private void btnNavPos_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavPos);
            // TODO: kiểm tra ca mở
            using var pos = new frmPos();
            pos.ShowDialog(this);
        }

        private void btnNavMenu_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavMenu);
            ShowContent(new frmProductList());
        }

        private void btnNavStock_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavStock);
            ShowContent(new frmIngredientList());
        }

        private void btnNavOrders_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavOrders);
            ShowContent(new frmOrderHistory());
        }

        private void btnNavStaff_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavStaff);
            ShowContent(new frmEmployeeList());
        }

        private void btnNavShift_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavShift);
            using var dlg = new frmShiftOpen();
            dlg.ShowDialog(this);
            // TODO: refresh lblShiftInfo
        }

        private void btnNavCustomers_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavCustomers);
            ShowContent(new frmCustomerList());
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavReports);
            ShowContent(new frmReports());
        }

        private void btnNavSettings_Click(object sender, EventArgs e)
        {
            HighlightNav(btnNavSettings);
            ShowContent(new frmSettings());
        }

        private void btnOpenShift_Click(object sender, EventArgs e)
        {
            using var dlg = new frmShiftOpen();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                // TODO: refresh shift UI
                lblShiftInfo.Text = "Ca đang mở";
                btnOpenShift.Visible = false;
                btnCloseShift.Visible = true;
            }
        }

        private void btnCloseShift_Click(object sender, EventArgs e)
        {
            using var dlg = new frmShiftClose();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                lblShiftInfo.Text = "Chưa mở ca";
                btnOpenShift.Visible = true;
                btnCloseShift.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) => DoLogout();
        private void mnuFileLogout_Click(object sender, EventArgs e) => DoLogout();

        private void DoLogout()
        {
            if (MessageBox.Show("Đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tmrClock.Stop();
                Close();
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            using var about = new frmAbout();
            about.ShowDialog(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrClock.Stop();
        }
    }
}
