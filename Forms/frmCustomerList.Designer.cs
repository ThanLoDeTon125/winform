namespace winform_cuoi_ki
{
    partial class frmCustomerList
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            splCust = new SplitContainer();
            dgvCustomers = new DataGridView();
            colCustName = new DataGridViewTextBoxColumn();
            colCustPhone = new DataGridViewTextBoxColumn();
            colTier = new DataGridViewTextBoxColumn();
            colPoints = new DataGridViewTextBoxColumn();
            pnlCustDetail = new Panel();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            chkIsMember = new CheckBox();
            lblTier = new Label();
            cboTier = new ComboBox();
            lblPointsCaption = new Label();
            lblPoints = new Label();
            lblNote = new Label();
            txtNote = new TextBox();
            lblLastVisit = new Label();
            stsCust = new StatusStrip();
            lblCustCount = new ToolStripStatusLabel();
            erpCust = new ErrorProvider(components);
            pnlToolbar.SuspendLayout();
            flpToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splCust).BeginInit();
            splCust.Panel1.SuspendLayout();
            splCust.Panel2.SuspendLayout();
            splCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            pnlCustDetail.SuspendLayout();
            stsCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpCust).BeginInit();
            SuspendLayout();
            pnlToolbar.Controls.Add(flpToolbar);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(8);
            pnlToolbar.Size = new Size(1000, 44);
            flpToolbar.Controls.AddRange(new Control[] { txtSearch, btnSearch, btnRefresh, btnAdd, btnSave });
            flpToolbar.Dock = DockStyle.Fill;
            flpToolbar.Name = "flpToolbar";
            flpToolbar.WrapContents = false;
            txtSearch.Name = "txtSearch"; txtSearch.Size = new Size(200, 23); txtSearch.PlaceholderText = "SĐT / tên";
            btnSearch.Name = "btnSearch"; btnSearch.Size = new Size(100, 28); btnSearch.Text = "Tìm SĐT/tên"; btnSearch.UseVisualStyleBackColor = true; btnSearch.Click += btnSearch_Click;
            btnRefresh.Name = "btnRefresh"; btnRefresh.Size = new Size(80, 28); btnRefresh.Text = "Làm mới"; btnRefresh.UseVisualStyleBackColor = true; btnRefresh.Click += btnRefresh_Click;
            btnAdd.Name = "btnAdd"; btnAdd.Size = new Size(70, 28); btnAdd.Text = "Thêm"; btnAdd.UseVisualStyleBackColor = true; btnAdd.Click += btnAdd_Click;
            btnSave.Name = "btnSave"; btnSave.Size = new Size(70, 28); btnSave.Text = "Lưu"; btnSave.UseVisualStyleBackColor = true; btnSave.Click += btnSave_Click;
            splCust.Dock = DockStyle.Fill;
            splCust.Location = new Point(0, 44);
            splCust.Name = "splCust";
            splCust.Panel1.Controls.Add(dgvCustomers);
            splCust.Panel2.Controls.Add(pnlCustDetail);
            splCust.Size = new Size(1000, 534);
            splCust.SplitterDistance = 680;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCustName, colCustPhone, colTier, colPoints });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            colCustName.HeaderText = "Họ tên"; colCustName.Name = "colCustName"; colCustName.ReadOnly = true;
            colCustPhone.HeaderText = "SĐT"; colCustPhone.Name = "colCustPhone"; colCustPhone.ReadOnly = true;
            colTier.HeaderText = "Hạng"; colTier.Name = "colTier"; colTier.ReadOnly = true;
            colPoints.HeaderText = "Điểm"; colPoints.Name = "colPoints"; colPoints.ReadOnly = true;
            pnlCustDetail.Controls.AddRange(new Control[] { lblLastVisit, txtNote, lblNote, lblPoints, lblPointsCaption, cboTier, lblTier, chkIsMember, txtPhone, lblPhone, txtFullName, lblFullName });
            pnlCustDetail.Dock = DockStyle.Fill;
            pnlCustDetail.Name = "pnlCustDetail";
            pnlCustDetail.Padding = new Padding(12);
            int y = 12;
            void L(Label l, string t) { l.AutoSize = true; l.Location = new Point(12, y); l.Text = t; y += 22; }
            void C(Control c, int h = 28) { c.Location = new Point(12, y); c.Width = 260; y += h + 6; }
            lblFullName.Name = "lblFullName"; L(lblFullName, "Họ tên");
            txtFullName.Name = "txtFullName"; txtFullName.MaxLength = 150; C(txtFullName);
            lblPhone.Name = "lblPhone"; L(lblPhone, "Số điện thoại");
            txtPhone.Name = "txtPhone"; txtPhone.MaxLength = 15; C(txtPhone);
            chkIsMember.Name = "chkIsMember"; chkIsMember.AutoSize = true; chkIsMember.Checked = true; chkIsMember.Text = "Thành viên"; chkIsMember.CheckedChanged += chkIsMember_CheckedChanged; C(chkIsMember, 24);
            lblTier.Name = "lblTier"; L(lblTier, "Hạng");
            cboTier.Name = "cboTier"; cboTier.DropDownStyle = ComboBoxStyle.DropDownList; cboTier.Items.AddRange(new object[] { "Đồng", "Bạc", "Vàng" }); C(cboTier);
            lblPointsCaption.Name = "lblPointsCaption"; L(lblPointsCaption, "Điểm hiện tại");
            lblPoints.Name = "lblPoints"; lblPoints.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblPoints.Text = "0"; C(lblPoints, 24);
            lblNote.Name = "lblNote"; L(lblNote, "Ghi chú");
            txtNote.Name = "txtNote"; txtNote.MaxLength = 300; C(txtNote);
            lblLastVisit.Name = "lblLastVisit"; lblLastVisit.AutoSize = true; lblLastVisit.Location = new Point(12, y); lblLastVisit.Text = "Mua gần nhất: —";
            stsCust.Items.AddRange(new ToolStripItem[] { lblCustCount });
            stsCust.Name = "stsCust";
            stsCust.Dock = DockStyle.Bottom;
            lblCustCount.Name = "lblCustCount"; lblCustCount.Spring = true; lblCustCount.Text = "0 khách";
            erpCust.ContainerControl = this;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(splCust);
            Controls.Add(pnlToolbar);
            Controls.Add(stsCust);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(800, 500);
            Name = "frmCustomerList";
            Text = "Khách hàng";
            Load += frmCustomerList_Load;
            pnlToolbar.ResumeLayout(false);
            flpToolbar.ResumeLayout(false);
            flpToolbar.PerformLayout();
            splCust.Panel1.ResumeLayout(false);
            splCust.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splCust).EndInit();
            splCust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            pnlCustDetail.ResumeLayout(false);
            pnlCustDetail.PerformLayout();
            stsCust.ResumeLayout(false);
            stsCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpCust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel pnlToolbar;
        private FlowLayoutPanel flpToolbar;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnSave;
        private SplitContainer splCust;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colCustName;
        private DataGridViewTextBoxColumn colCustPhone;
        private DataGridViewTextBoxColumn colTier;
        private DataGridViewTextBoxColumn colPoints;
        private Panel pnlCustDetail;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblPhone;
        private TextBox txtPhone;
        private CheckBox chkIsMember;
        private Label lblTier;
        private ComboBox cboTier;
        private Label lblPointsCaption;
        private Label lblPoints;
        private Label lblNote;
        private TextBox txtNote;
        private Label lblLastVisit;
        private StatusStrip stsCust;
        private ToolStripStatusLabel lblCustCount;
        private ErrorProvider erpCust;
    }
}
