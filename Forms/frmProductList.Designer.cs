namespace winform_cuoi_ki
{
    partial class frmProductList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlToolbar = new Panel();
            flpToolbar = new FlowLayoutPanel();
            lblCategoryFilter = new Label();
            cboCategoryFilter = new ComboBox();
            lblStatusFilter = new Label();
            cboStatusFilter = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnToggleActive = new Button();
            dgvProducts = new DataGridView();
            colCode = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colBasePrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colUpdated = new DataGridViewTextBoxColumn();
            stsList = new StatusStrip();
            lblCount = new ToolStripStatusLabel();
            pnlToolbar.SuspendLayout();
            flpToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            stsList.SuspendLayout();
            SuspendLayout();
            //
            // pnlToolbar
            //
            pnlToolbar.Controls.Add(flpToolbar);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 0);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(8);
            pnlToolbar.Size = new Size(1000, 48);
            pnlToolbar.TabIndex = 0;
            //
            // flpToolbar
            //
            flpToolbar.Controls.Add(lblCategoryFilter);
            flpToolbar.Controls.Add(cboCategoryFilter);
            flpToolbar.Controls.Add(lblStatusFilter);
            flpToolbar.Controls.Add(cboStatusFilter);
            flpToolbar.Controls.Add(txtSearch);
            flpToolbar.Controls.Add(btnSearch);
            flpToolbar.Controls.Add(btnRefresh);
            flpToolbar.Controls.Add(btnAdd);
            flpToolbar.Controls.Add(btnEdit);
            flpToolbar.Controls.Add(btnToggleActive);
            flpToolbar.Dock = DockStyle.Fill;
            flpToolbar.Location = new Point(8, 8);
            flpToolbar.Name = "flpToolbar";
            flpToolbar.Size = new Size(984, 32);
            flpToolbar.TabIndex = 0;
            flpToolbar.WrapContents = false;
            //
            // filters
            //
            lblCategoryFilter.AutoSize = true;
            lblCategoryFilter.Name = "lblCategoryFilter";
            lblCategoryFilter.Padding = new Padding(0, 6, 0, 0);
            lblCategoryFilter.Text = "Danh mục";
            cboCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoryFilter.Items.AddRange(new object[] { "Tất cả" });
            cboCategoryFilter.Name = "cboCategoryFilter";
            cboCategoryFilter.Size = new Size(160, 23);
            cboCategoryFilter.SelectedIndex = 0;
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Padding = new Padding(0, 6, 0, 0);
            lblStatusFilter.Text = "Trạng thái";
            cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusFilter.Items.AddRange(new object[] { "Tất cả", "Đang bán", "Tạm ngưng" });
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(120, 23);
            cboStatusFilter.SelectedIndex = 0;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tên/mã";
            txtSearch.Size = new Size(180, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 28);
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 28);
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 28);
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(70, 28);
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new Size(90, 28);
            btnToggleActive.Text = "Ngưng bán";
            btnToggleActive.UseVisualStyleBackColor = true;
            btnToggleActive.Click += btnToggleActive_Click;
            //
            // dgvProducts
            //
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colCode, colName, colCategory, colBasePrice, colStatus, colUpdated });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 48);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1000, 530);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            colCode.HeaderText = "Mã";
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            colName.HeaderText = "Tên";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colCategory.HeaderText = "Danh mục";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colBasePrice.HeaderText = "Giá cơ bản";
            colBasePrice.Name = "colBasePrice";
            colBasePrice.ReadOnly = true;
            colStatus.HeaderText = "Trạng thái";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colUpdated.HeaderText = "Cập nhật";
            colUpdated.Name = "colUpdated";
            colUpdated.ReadOnly = true;
            //
            // stsList
            //
            stsList.Items.AddRange(new ToolStripItem[] { lblCount });
            stsList.Location = new Point(0, 578);
            stsList.Name = "stsList";
            stsList.Size = new Size(1000, 22);
            stsList.TabIndex = 2;
            lblCount.Name = "lblCount";
            lblCount.Spring = true;
            lblCount.Text = "0 sản phẩm";
            //
            // frmProductList
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvProducts);
            Controls.Add(pnlToolbar);
            Controls.Add(stsList);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(800, 500);
            Name = "frmProductList";
            Text = "Thực đơn — Sản phẩm";
            Load += frmProductList_Load;
            pnlToolbar.ResumeLayout(false);
            flpToolbar.ResumeLayout(false);
            flpToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            stsList.ResumeLayout(false);
            stsList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlToolbar;
        private FlowLayoutPanel flpToolbar;
        private Label lblCategoryFilter;
        private ComboBox cboCategoryFilter;
        private Label lblStatusFilter;
        private ComboBox cboStatusFilter;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnToggleActive;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colBasePrice;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colUpdated;
        private StatusStrip stsList;
        private ToolStripStatusLabel lblCount;
    }
}
