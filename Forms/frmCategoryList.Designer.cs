namespace winform_cuoi_ki
{
    partial class frmCategoryList
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlToolbar = new Panel();
            flpToolbar = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnToggleActive = new Button();
            btnMoveUp = new Button();
            btnMoveDown = new Button();
            btnRefresh = new Button();
            splCat = new SplitContainer();
            dgvCategories = new DataGridView();
            colCatName = new DataGridViewTextBoxColumn();
            colSort = new DataGridViewTextBoxColumn();
            colCatStatus = new DataGridViewTextBoxColumn();
            pnlDetail = new Panel();
            lblName = new Label();
            txtName = new TextBox();
            lblSort = new Label();
            nudSortOrder = new NumericUpDown();
            chkIsActive = new CheckBox();
            lblNote = new Label();
            txtNote = new TextBox();
            btnSaveDetail = new Button();
            stsCat = new StatusStrip();
            lblCatCount = new ToolStripStatusLabel();
            erpCat = new ErrorProvider(components);
            pnlToolbar.SuspendLayout();
            flpToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splCat).BeginInit();
            splCat.Panel1.SuspendLayout();
            splCat.Panel2.SuspendLayout();
            splCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSortOrder).BeginInit();
            stsCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpCat).BeginInit();
            SuspendLayout();
            // toolbar
            pnlToolbar.Controls.Add(flpToolbar);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(8);
            pnlToolbar.Size = new Size(800, 44);
            flpToolbar.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnToggleActive, btnMoveUp, btnMoveDown, btnRefresh });
            flpToolbar.Dock = DockStyle.Fill;
            flpToolbar.Name = "flpToolbar";
            flpToolbar.WrapContents = false;
            btnAdd.Name = "btnAdd"; btnAdd.Size = new Size(70, 28); btnAdd.Text = "Thêm"; btnAdd.UseVisualStyleBackColor = true; btnAdd.Click += btnAdd_Click;
            btnEdit.Name = "btnEdit"; btnEdit.Size = new Size(70, 28); btnEdit.Text = "Sửa"; btnEdit.UseVisualStyleBackColor = true; btnEdit.Click += btnEdit_Click;
            btnToggleActive.Name = "btnToggleActive"; btnToggleActive.Size = new Size(100, 28); btnToggleActive.Text = "Ngưng dùng"; btnToggleActive.UseVisualStyleBackColor = true; btnToggleActive.Click += btnToggleActive_Click;
            btnMoveUp.Name = "btnMoveUp"; btnMoveUp.Size = new Size(60, 28); btnMoveUp.Text = "Lên"; btnMoveUp.UseVisualStyleBackColor = true; btnMoveUp.Click += btnMoveUp_Click;
            btnMoveDown.Name = "btnMoveDown"; btnMoveDown.Size = new Size(70, 28); btnMoveDown.Text = "Xuống"; btnMoveDown.UseVisualStyleBackColor = true; btnMoveDown.Click += btnMoveDown_Click;
            btnRefresh.Name = "btnRefresh"; btnRefresh.Size = new Size(80, 28); btnRefresh.Text = "Làm mới"; btnRefresh.UseVisualStyleBackColor = true; btnRefresh.Click += btnRefresh_Click;
            // split
            splCat.Dock = DockStyle.Fill;
            splCat.Location = new Point(0, 44);
            splCat.Name = "splCat";
            splCat.Panel1.Controls.Add(dgvCategories);
            splCat.Panel2.Controls.Add(pnlDetail);
            splCat.Panel2MinSize = 240;
            splCat.Size = new Size(800, 434);
            splCat.SplitterDistance = 500;
            // grid
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { colCatName, colSort, colCatStatus });
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            colCatName.HeaderText = "Tên"; colCatName.Name = "colCatName"; colCatName.ReadOnly = true;
            colSort.HeaderText = "Thứ tự"; colSort.Name = "colSort"; colSort.ReadOnly = true;
            colCatStatus.HeaderText = "Trạng thái"; colCatStatus.Name = "colCatStatus"; colCatStatus.ReadOnly = true;
            // detail
            pnlDetail.Controls.Add(btnSaveDetail);
            pnlDetail.Controls.Add(txtNote);
            pnlDetail.Controls.Add(lblNote);
            pnlDetail.Controls.Add(chkIsActive);
            pnlDetail.Controls.Add(nudSortOrder);
            pnlDetail.Controls.Add(lblSort);
            pnlDetail.Controls.Add(txtName);
            pnlDetail.Controls.Add(lblName);
            pnlDetail.Dock = DockStyle.Fill;
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Padding = new Padding(12);
            lblName.Location = new Point(12, 12); lblName.AutoSize = true; lblName.Name = "lblName"; lblName.Text = "Tên danh mục";
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; txtName.Location = new Point(12, 36); txtName.MaxLength = 100; txtName.Name = "txtName"; txtName.Size = new Size(250, 23);
            lblSort.Location = new Point(12, 72); lblSort.AutoSize = true; lblSort.Name = "lblSort"; lblSort.Text = "Thứ tự";
            nudSortOrder.Location = new Point(12, 96); nudSortOrder.Maximum = 9999; nudSortOrder.Name = "nudSortOrder";
            chkIsActive.AutoSize = true; chkIsActive.Location = new Point(12, 136); chkIsActive.Name = "chkIsActive"; chkIsActive.Text = "Đang dùng"; chkIsActive.Checked = true;
            lblNote.Location = new Point(12, 172); lblNote.AutoSize = true; lblNote.Name = "lblNote"; lblNote.Text = "Ghi chú";
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; txtNote.Location = new Point(12, 196); txtNote.Multiline = true; txtNote.Name = "txtNote"; txtNote.Size = new Size(250, 80);
            btnSaveDetail.Location = new Point(12, 290); btnSaveDetail.Name = "btnSaveDetail"; btnSaveDetail.Size = new Size(100, 32); btnSaveDetail.Text = "Lưu"; btnSaveDetail.UseVisualStyleBackColor = true; btnSaveDetail.Click += btnSaveDetail_Click;
            // status
            stsCat.Items.AddRange(new ToolStripItem[] { lblCatCount });
            stsCat.Location = new Point(0, 478);
            stsCat.Name = "stsCat";
            stsCat.Size = new Size(800, 22);
            lblCatCount.Name = "lblCatCount"; lblCatCount.Spring = true; lblCatCount.Text = "0 danh mục";
            erpCat.ContainerControl = this;
            // form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(splCat);
            Controls.Add(pnlToolbar);
            Controls.Add(stsCat);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(640, 420);
            Name = "frmCategoryList";
            Text = "Danh mục thực đơn";
            Load += frmCategoryList_Load;
            pnlToolbar.ResumeLayout(false);
            flpToolbar.ResumeLayout(false);
            splCat.Panel1.ResumeLayout(false);
            splCat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splCat).EndInit();
            splCat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSortOrder).EndInit();
            stsCat.ResumeLayout(false);
            stsCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel pnlToolbar;
        private FlowLayoutPanel flpToolbar;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnToggleActive;
        private Button btnMoveUp;
        private Button btnMoveDown;
        private Button btnRefresh;
        private SplitContainer splCat;
        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn colCatName;
        private DataGridViewTextBoxColumn colSort;
        private DataGridViewTextBoxColumn colCatStatus;
        private Panel pnlDetail;
        private Label lblName;
        private TextBox txtName;
        private Label lblSort;
        private NumericUpDown nudSortOrder;
        private CheckBox chkIsActive;
        private Label lblNote;
        private TextBox txtNote;
        private Button btnSaveDetail;
        private StatusStrip stsCat;
        private ToolStripStatusLabel lblCatCount;
        private ErrorProvider erpCat;
    }
}
