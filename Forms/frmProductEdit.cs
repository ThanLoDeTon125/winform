using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmProductEdit : Form
    {
        public frmProductEdit()
        {
            InitializeComponent();
        }

        private void frmProductEdit_Load(object sender, EventArgs e)
        {
            lblEditError.Visible = false;
            Text = "Thêm sản phẩm"; // TODO: đổi khi Edit
            chkIsActive.Checked = true;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog { Filter = "Ảnh|*.png;*.jpg;*.jpeg;*.bmp" };
            if (ofd.ShowDialog(this) == DialogResult.OK)
                picImage.ImageLocation = ofd.FileName;
        }

        private void btnClearImage_Click(object sender, EventArgs e) => picImage.Image = null;

        private void btnAddVariant_Click(object sender, EventArgs e) => dgvVariants.Rows.Add("M", "0", false);
        private void btnRemoveVariant_Click(object sender, EventArgs e)
        {
            if (dgvVariants.CurrentRow != null) dgvVariants.Rows.Remove(dgvVariants.CurrentRow);
        }
        private void btnAddTopping_Click(object sender, EventArgs e) => dgvToppings.Rows.Add("", "0", true);
        private void btnRemoveTopping_Click(object sender, EventArgs e)
        {
            if (dgvToppings.CurrentRow != null) dgvToppings.Rows.Remove(dgvToppings.CurrentRow);
        }
        private void btnAddRecipeLine_Click(object sender, EventArgs e) => MessageBox.Show("TODO: chọn nguyên liệu", "Công thức");
        private void btnRemoveRecipeLine_Click(object sender, EventArgs e)
        {
            if (dgvRecipe.CurrentRow != null) dgvRecipe.Rows.Remove(dgvRecipe.CurrentRow);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            erpEdit.Clear();
            lblEditError.Visible = false;
            if (string.IsNullOrWhiteSpace(txtCode.Text)) { erpEdit.SetError(txtCode, "Nhập mã"); return; }
            if (string.IsNullOrWhiteSpace(txtName.Text)) { erpEdit.SetError(txtName, "Nhập tên"); return; }
            // TODO: BLL Save
            MessageBox.Show("TODO: lưu sản phẩm (BLL).", "Sản phẩm");
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
