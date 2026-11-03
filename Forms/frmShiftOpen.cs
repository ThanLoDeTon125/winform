using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmShiftOpen : Form
    {
        public frmShiftOpen()
        {
            InitializeComponent();
        }

        private void frmShiftOpen_Load(object sender, EventArgs e)
        {
            lblShiftOpenError.Visible = false;
            lblOpenTime.Text = $"Thời điểm mở: {DateTime.Now:HH:mm dd/MM/yyyy}";
            // TODO: bind lblUserInfo từ session
            lblUserInfo.Text = "NV: (chưa đăng nhập) — Vai trò";
            txtCounterName.Text = Environment.MachineName;
            nudOpeningCash.Value = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblShiftOpenError.Visible = false;
            // TODO: BLL OpenShift
            MessageBox.Show("TODO: mở ca (BLL).", "Mở ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
