namespace winform_cuoi_ki
{
    partial class frmOrderHistory
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
            pnlFilter = new Panel();
            flpFilter = new FlowLayoutPanel();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            lblShift = new Label();
            cboShift = new ComboBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblPayMethod = new Label();
            cboPayMethod = new ComboBox();
            lblOrderNo = new Label();
            txtOrderNo = new TextBox();
            btnSearch = new Button();
            btnToday = new Button();
            btnRefresh = new Button();
            dgvOrders = new DataGridView();
            colOrderNo = new DataGridViewTextBoxColumn();
            colOrderTime = new DataGridViewTextBoxColumn();
            colCashier = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colPayMethod = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colOrderStatus = new DataGridViewTextBoxColumn();
            pnlActions = new Panel();
            btnViewDetail = new Button();
            btnReprint = new Button();
            lblRevenue = new Label();
            stsOrders = new StatusStrip();
            lblOrderCount = new ToolStripStatusLabel();
            pnlFilter.SuspendLayout();
            flpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            pnlActions.SuspendLayout();
            stsOrders.SuspendLayout();
            SuspendLayout();
            pnlFilter.Controls.Add(flpFilter);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1100, 80);
            flpFilter.Controls.AddRange(new Control[] { lblFrom, dtpFrom, lblTo, dtpTo, lblShift, cboShift, lblStatus, cboStatus, lblPayMethod, cboPayMethod, lblOrderNo, txtOrderNo, btnSearch, btnToday, btnRefresh });
            flpFilter.Dock = DockStyle.Fill;
            flpFilter.Name = "flpFilter";
            flpFilter.Padding = new Padding(8);
            flpFilter.WrapContents = true;
            lblFrom.AutoSize = true; lblFrom.Name = "lblFrom"; lblFrom.Text = "Từ ngày"; lblFrom.Padding = new Padding(0, 6, 0, 0);
            dtpFrom.Format = DateTimePickerFormat.Short; dtpFrom.Name = "dtpFrom"; dtpFrom.Width = 120;
            lblTo.AutoSize = true; lblTo.Name = "lblTo"; lblTo.Text = "Đến ngày"; lblTo.Padding = new Padding(0, 6, 0, 0);
            dtpTo.Format = DateTimePickerFormat.Short; dtpTo.Name = "dtpTo"; dtpTo.Width = 120;
            lblShift.AutoSize = true; lblShift.Name = "lblShift"; lblShift.Text = "Ca"; lblShift.Padding = new Padding(0, 6, 0, 0);
            cboShift.DropDownStyle = ComboBoxStyle.DropDownList; cboShift.Items.Add("Tất cả"); cboShift.Name = "cboShift"; cboShift.Size = new Size(120, 23); cboShift.SelectedIndex = 0;
            lblStatus.AutoSize = true; lblStatus.Name = "lblStatus"; lblStatus.Text = "Trạng thái"; lblStatus.Padding = new Padding(0, 6, 0, 0);
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList; cboStatus.Items.AddRange(new object[] { "Tất cả", "Nháp", "Đã thanh toán", "Hoàn thành", "Đã hủy" }); cboStatus.Name = "cboStatus"; cboStatus.Size = new Size(130, 23); cboStatus.SelectedIndex = 0;
            lblPayMethod.AutoSize = true; lblPayMethod.Name = "lblPayMethod"; lblPayMethod.Text = "PTTT"; lblPayMethod.Padding = new Padding(0, 6, 0, 0);
            cboPayMethod.DropDownStyle = ComboBoxStyle.DropDownList; cboPayMethod.Items.AddRange(new object[] { "Tất cả", "Tiền mặt", "Chuyển khoản", "Thẻ" }); cboPayMethod.Name = "cboPayMethod"; cboPayMethod.Size = new Size(120, 23); cboPayMethod.SelectedIndex = 0;
            lblOrderNo.AutoSize = true; lblOrderNo.Name = "lblOrderNo"; lblOrderNo.Text = "Số đơn"; lblOrderNo.Padding = new Padding(0, 6, 0, 0);
            txtOrderNo.Name = "txtOrderNo"; txtOrderNo.Size = new Size(120, 23);
            btnSearch.Name = "btnSearch"; btnSearch.Size = new Size(60, 28); btnSearch.Text = "Tìm"; btnSearch.UseVisualStyleBackColor = true; btnSearch.Click += btnSearch_Click;
            btnToday.Name = "btnToday"; btnToday.Size = new Size(80, 28); btnToday.Text = "Hôm nay"; btnToday.UseVisualStyleBackColor = true; btnToday.Click += btnToday_Click;
            btnRefresh.Name = "btnRefresh"; btnRefresh.Size = new Size(80, 28); btnRefresh.Text = "Làm mới"; btnRefresh.UseVisualStyleBackColor = true; btnRefresh.Click += btnRefresh_Click;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderNo, colOrderTime, colCashier, colCustomer, colPayMethod, colTotal, colOrderStatus });
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
            colOrderNo.HeaderText = "Số đơn"; colOrderNo.Name = "colOrderNo"; colOrderNo.ReadOnly = true;
            colOrderTime.HeaderText = "Giờ"; colOrderTime.Name = "colOrderTime"; colOrderTime.ReadOnly = true;
            colCashier.HeaderText = "Thu ngân"; colCashier.Name = "colCashier"; colCashier.ReadOnly = true;
            colCustomer.HeaderText = "Khách"; colCustomer.Name = "colCustomer"; colCustomer.ReadOnly = true;
            colPayMethod.HeaderText = "PTTT"; colPayMethod.Name = "colPayMethod"; colPayMethod.ReadOnly = true;
            colTotal.HeaderText = "Tổng tiền"; colTotal.Name = "colTotal"; colTotal.ReadOnly = true;
            colOrderStatus.HeaderText = "Trạng thái"; colOrderStatus.Name = "colOrderStatus"; colOrderStatus.ReadOnly = true;
            pnlActions.Controls.Add(lblRevenue);
            pnlActions.Controls.Add(btnReprint);
            pnlActions.Controls.Add(btnViewDetail);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1100, 48);
            btnViewDetail.Location = new Point(12, 10); btnViewDetail.Name = "btnViewDetail"; btnViewDetail.Size = new Size(110, 28); btnViewDetail.Text = "Xem chi tiết"; btnViewDetail.UseVisualStyleBackColor = true; btnViewDetail.Click += btnViewDetail_Click;
            btnReprint.Location = new Point(130, 10); btnReprint.Name = "btnReprint"; btnReprint.Size = new Size(90, 28); btnReprint.Text = "In lại"; btnReprint.UseVisualStyleBackColor = true; btnReprint.Click += btnReprint_Click;
            lblRevenue.Anchor = AnchorStyles.Top | AnchorStyles.Right; lblRevenue.Location = new Point(800, 14); lblRevenue.Name = "lblRevenue"; lblRevenue.Size = new Size(280, 23); lblRevenue.Text = "Doanh thu lọc: 0 đ"; lblRevenue.TextAlign = ContentAlignment.MiddleRight;
            stsOrders.Items.AddRange(new ToolStripItem[] { lblOrderCount });
            stsOrders.Name = "stsOrders";
            stsOrders.Dock = DockStyle.Bottom;
            lblOrderCount.Name = "lblOrderCount"; lblOrderCount.Spring = true; lblOrderCount.Text = "0 đơn";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 640);
            Controls.Add(dgvOrders);
            Controls.Add(pnlActions);
            Controls.Add(pnlFilter);
            Controls.Add(stsOrders);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(900, 520);
            Name = "frmOrderHistory";
            Text = "Đơn hàng";
            Load += frmOrderHistory_Load;
            pnlFilter.ResumeLayout(false);
            flpFilter.ResumeLayout(false);
            flpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            pnlActions.ResumeLayout(false);
            stsOrders.ResumeLayout(false);
            stsOrders.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel pnlFilter;
        private FlowLayoutPanel flpFilter;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Label lblShift;
        private ComboBox cboShift;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Label lblPayMethod;
        private ComboBox cboPayMethod;
        private Label lblOrderNo;
        private TextBox txtOrderNo;
        private Button btnSearch;
        private Button btnToday;
        private Button btnRefresh;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn colOrderNo;
        private DataGridViewTextBoxColumn colOrderTime;
        private DataGridViewTextBoxColumn colCashier;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colPayMethod;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colOrderStatus;
        private Panel pnlActions;
        private Button btnViewDetail;
        private Button btnReprint;
        private Label lblRevenue;
        private StatusStrip stsOrders;
        private ToolStripStatusLabel lblOrderCount;
    }
}
