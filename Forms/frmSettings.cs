using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            lblSettingsMsg.Text = "";
            // TODO: BLL load settings
            if (cboRoundMode.Items.Count > 0) cboRoundMode.SelectedIndex = 0;
            if (cboPaperWidth.Items.Count > 0) cboPaperWidth.SelectedIndex = 1;
            chkAuditEnabled.Checked = true;
        }

        private void btnBrowseLogo_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog { Filter = "Ảnh|*.png;*.jpg;*.jpeg;*.bmp" };
            if (ofd.ShowDialog(this) == DialogResult.OK)
                picStoreLogo.ImageLocation = ofd.FileName;
        }

        private void btnClearLogo_Click(object sender, EventArgs e) => picStoreLogo.Image = null;

        private void btnRefreshPrinters_Click(object sender, EventArgs e)
        {
            cboPrinter.Items.Clear();
            // TODO: InstalledPrinters
            MessageBox.Show("TODO: nạp danh sách máy in Windows.", "Máy in");
        }

        private void btnTestPrint_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: in thử theo khổ đã chọn.", "Máy in");

        private void btnSave_Click(object sender, EventArgs e)
        {
            erpSettings.Clear();
            if (string.IsNullOrWhiteSpace(txtStoreName.Text))
            {
                erpSettings.SetError(txtStoreName, "Nhập tên cửa hàng");
                tabSettings.SelectedTab = tabStore;
                return;
            }
            MessageBox.Show("TODO: BLL Save settings.", "Cấu hình");
            lblSettingsMsg.Text = "Đã lưu";
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: reload settings từ DB.", "Cấu hình");
            lblSettingsMsg.Text = "Đã hoàn tác";
        }

        private void btnBackup_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: BLL sao lưu dữ liệu.", "Hệ thống");

        private void btnOpenBackupFolder_Click(object sender, EventArgs e) =>
            MessageBox.Show("TODO: mở thư mục sao lưu.", "Hệ thống");
    }
}
