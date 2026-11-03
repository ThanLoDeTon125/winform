using System;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class frmCategoryList : Form
    {
        public frmCategoryList()
        {
            InitializeComponent();
        }

        private void frmCategoryList_Load(object sender, EventArgs e)
        {
            // TODO: load categories
            lblCatCount.Text = "0 danh mục";
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            // TODO: bind detail
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            nudSortOrder.Value = 0;
            chkIsActive.Checked = true;
            txtNote.Clear();
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e) => txtName.Focus();
        private void btnToggleActive_Click(object sender, EventArgs e) => MessageBox.Show("TODO: ngưng/mở danh mục", "Danh mục");
        private void btnMoveUp_Click(object sender, EventArgs e) => MessageBox.Show("TODO: đổi thứ tự lên", "Danh mục");
        private void btnMoveDown_Click(object sender, EventArgs e) => MessageBox.Show("TODO: đổi thứ tự xuống", "Danh mục");
        private void btnRefresh_Click(object sender, EventArgs e) { /* TODO */ }

        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            erpCat.Clear();
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                erpCat.SetError(txtName, "Nhập tên danh mục");
                return;
            }
            MessageBox.Show("TODO: lưu danh mục (BLL).", "Danh mục");
        }
    }
}
