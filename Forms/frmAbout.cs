using System;
using System.Reflection;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            var ver = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Text = ver != null ? $"Phiên bản {ver}" : "Phiên bản 1.0.0";
            lblRuntime.Text = $"Runtime: .NET {Environment.Version}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
