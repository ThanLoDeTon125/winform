namespace winform_cuoi_ki
{
    partial class frmOrderDetail
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
            pnlHeader = new Panel();
            tlpHeader = new TableLayoutPanel();
            lblOrderNo = new Label();
            lblOrderTime = new Label();
            lblStatus = new Label();
            lblCashier = new Label();
            lblShift = new Label();
            lblCustomer = new Label();
            dgvOrderLines = new DataGridView();
            colOdName = new DataGridViewTextBoxColumn();
            colOdSize = new DataGridViewTextBoxColumn();
            colOdTopping = new DataGridViewTextBoxColumn();
            colOdQty = new DataGridViewTextBoxColumn();
            colOdPrice = new DataGridViewTextBoxColumn();
            colOdLineTotal = new DataGridViewTextBoxColumn();
            colOdNote = new DataGridViewTextBoxColumn();
            pnlTotals = new Panel();
            lblSubTotal = new Label();
            lblDiscount = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            lblPayMethod = new Label();
            lblPayReceived = new Label();
            lblPayChange = new Label();
            btnReprint = new Button();
            btnCancelOrder = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderLines).BeginInit();
            pnlTotals.SuspendLayout();
            SuspendLayout();
            pnlHeader.Controls.Add(tlpHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(720, 72);
            tlpHeader.ColumnCount = 3;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpHeader.Controls.Add(lblOrderNo, 0, 0);
            tlpHeader.Controls.Add(lblOrderTime, 1, 0);
            tlpHeader.Controls.Add(lblStatus, 2, 0);
            tlpHeader.Controls.Add(lblCashier, 0, 1);
            tlpHeader.Controls.Add(lblShift, 1, 1);
            tlpHeader.Controls.Add(lblCustomer, 2, 1);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Name = "tlpHeader";
            tlpHeader.Padding = new Padding(12);
            tlpHeader.RowCount = 2;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lblOrderNo.AutoSize = true; lblOrderNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblOrderNo.Name = "lblOrderNo"; lblOrderNo.Text = "Số đơn: …";
            lblOrderTime.AutoSize = true; lblOrderTime.Name = "lblOrderTime"; lblOrderTime.Text = "Thời gian: …";
            lblStatus.AutoSize = true; lblStatus.Name = "lblStatus"; lblStatus.Text = "Trạng thái: …";
            lblCashier.AutoSize = true; lblCashier.Name = "lblCashier"; lblCashier.Text = "Thu ngân: …";
            lblShift.AutoSize = true; lblShift.Name = "lblShift"; lblShift.Text = "Ca: …";
            lblCustomer.AutoSize = true; lblCustomer.Name = "lblCustomer"; lblCustomer.Text = "Khách: …";
            dgvOrderLines.AllowUserToAddRows = false;
            dgvOrderLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderLines.Columns.AddRange(new DataGridViewColumn[] { colOdName, colOdSize, colOdTopping, colOdQty, colOdPrice, colOdLineTotal, colOdNote });
            dgvOrderLines.Dock = DockStyle.Fill;
            dgvOrderLines.Name = "dgvOrderLines";
            dgvOrderLines.ReadOnly = true;
            dgvOrderLines.RowHeadersVisible = false;
            dgvOrderLines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colOdName.HeaderText = "Món"; colOdName.Name = "colOdName"; colOdName.ReadOnly = true;
            colOdSize.HeaderText = "Size"; colOdSize.Name = "colOdSize"; colOdSize.ReadOnly = true;
            colOdTopping.HeaderText = "Topping"; colOdTopping.Name = "colOdTopping"; colOdTopping.ReadOnly = true;
            colOdQty.HeaderText = "SL"; colOdQty.Name = "colOdQty"; colOdQty.ReadOnly = true;
            colOdPrice.HeaderText = "Đơn giá"; colOdPrice.Name = "colOdPrice"; colOdPrice.ReadOnly = true;
            colOdLineTotal.HeaderText = "Thành tiền"; colOdLineTotal.Name = "colOdLineTotal"; colOdLineTotal.ReadOnly = true;
            colOdNote.HeaderText = "Ghi chú"; colOdNote.Name = "colOdNote"; colOdNote.ReadOnly = true;
            pnlTotals.Controls.AddRange(new Control[] { btnClose, btnCancelOrder, btnReprint, lblPayChange, lblPayReceived, lblPayMethod, lblTotal, lblTax, lblDiscount, lblSubTotal });
            pnlTotals.Dock = DockStyle.Bottom;
            pnlTotals.Name = "pnlTotals";
            pnlTotals.Size = new Size(720, 130);
            lblSubTotal.AutoSize = true; lblSubTotal.Location = new Point(12, 12); lblSubTotal.Name = "lblSubTotal"; lblSubTotal.Text = "Tạm tính: 0 đ";
            lblDiscount.AutoSize = true; lblDiscount.Location = new Point(12, 36); lblDiscount.Name = "lblDiscount"; lblDiscount.Text = "Giảm giá: 0 đ";
            lblTax.AutoSize = true; lblTax.Location = new Point(200, 12); lblTax.Name = "lblTax"; lblTax.Text = "Thuế: 0 đ";
            lblTotal.AutoSize = true; lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblTotal.Location = new Point(200, 36); lblTotal.Name = "lblTotal"; lblTotal.Text = "Tổng: 0 đ";
            lblPayMethod.AutoSize = true; lblPayMethod.Location = new Point(400, 12); lblPayMethod.Name = "lblPayMethod"; lblPayMethod.Text = "PTTT: …";
            lblPayReceived.AutoSize = true; lblPayReceived.Location = new Point(400, 36); lblPayReceived.Name = "lblPayReceived"; lblPayReceived.Text = "Tiền khách: …";
            lblPayChange.AutoSize = true; lblPayChange.Location = new Point(400, 60); lblPayChange.Name = "lblPayChange"; lblPayChange.Text = "Tiền thừa: …";
            btnReprint.Location = new Point(12, 88); btnReprint.Name = "btnReprint"; btnReprint.Size = new Size(130, 32); btnReprint.Text = "In lại hóa đơn"; btnReprint.UseVisualStyleBackColor = true; btnReprint.Click += btnReprint_Click;
            btnCancelOrder.Location = new Point(152, 88); btnCancelOrder.Name = "btnCancelOrder"; btnCancelOrder.Size = new Size(100, 32); btnCancelOrder.Text = "Hủy đơn"; btnCancelOrder.UseVisualStyleBackColor = true; btnCancelOrder.Click += btnCancelOrder_Click;
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right; btnClose.Location = new Point(600, 88); btnClose.Name = "btnClose"; btnClose.Size = new Size(100, 32); btnClose.Text = "Đóng"; btnClose.UseVisualStyleBackColor = true; btnClose.Click += btnClose_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(720, 560);
            Controls.Add(dgvOrderLines);
            Controls.Add(pnlHeader);
            Controls.Add(pnlTotals);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = false;
            MinimumSize = new Size(640, 480);
            Name = "frmOrderDetail";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết đơn";
            Load += frmOrderDetail_Load;
            pnlHeader.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            tlpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderLines).EndInit();
            pnlTotals.ResumeLayout(false);
            pnlTotals.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlHeader;
        private TableLayoutPanel tlpHeader;
        private Label lblOrderNo;
        private Label lblOrderTime;
        private Label lblStatus;
        private Label lblCashier;
        private Label lblShift;
        private Label lblCustomer;
        private DataGridView dgvOrderLines;
        private DataGridViewTextBoxColumn colOdName;
        private DataGridViewTextBoxColumn colOdSize;
        private DataGridViewTextBoxColumn colOdTopping;
        private DataGridViewTextBoxColumn colOdQty;
        private DataGridViewTextBoxColumn colOdPrice;
        private DataGridViewTextBoxColumn colOdLineTotal;
        private DataGridViewTextBoxColumn colOdNote;
        private Panel pnlTotals;
        private Label lblSubTotal;
        private Label lblDiscount;
        private Label lblTax;
        private Label lblTotal;
        private Label lblPayMethod;
        private Label lblPayReceived;
        private Label lblPayChange;
        private Button btnReprint;
        private Button btnCancelOrder;
        private Button btnClose;
    }
}
