namespace winform_cuoi_ki
{
    partial class ucCartPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            tlpCart = new TableLayoutPanel();
            lblCartTitle = new Label();
            dgvCart = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colSize = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colLineTotal = new DataGridViewTextBoxColumn();
            pnlLineActions = new FlowLayoutPanel();
            btnQtyMinus = new Button();
            btnQtyPlus = new Button();
            btnRemoveLine = new Button();
            btnLineNote = new Button();
            btnSizeTopping = new Button();
            tlpTotals = new TableLayoutPanel();
            lblSubTotalCaption = new Label();
            lblSubTotal = new Label();
            lblDiscountCaption = new Label();
            lblDiscount = new Label();
            lblTaxCaption = new Label();
            lblTax = new Label();
            lblTotalCaption = new Label();
            lblTotal = new Label();
            pnlCustomer = new Panel();
            txtCustomerPhone = new TextBox();
            btnFindCustomer = new Button();
            btnClearCustomer = new Button();
            lblCustomerName = new Label();
            pnlPayActions = new TableLayoutPanel();
            btnCancelOrder = new Button();
            btnDiscount = new Button();
            btnPay = new Button();
            tlpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            pnlLineActions.SuspendLayout();
            tlpTotals.SuspendLayout();
            pnlCustomer.SuspendLayout();
            pnlPayActions.SuspendLayout();
            SuspendLayout();
            //
            // tlpCart
            //
            tlpCart.ColumnCount = 1;
            tlpCart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCart.Controls.Add(lblCartTitle, 0, 0);
            tlpCart.Controls.Add(dgvCart, 0, 1);
            tlpCart.Controls.Add(pnlLineActions, 0, 2);
            tlpCart.Controls.Add(tlpTotals, 0, 3);
            tlpCart.Controls.Add(pnlCustomer, 0, 4);
            tlpCart.Controls.Add(pnlPayActions, 0, 5);
            tlpCart.Dock = DockStyle.Fill;
            tlpCart.Location = new Point(0, 0);
            tlpCart.Name = "tlpCart";
            tlpCart.Padding = new Padding(8);
            tlpCart.RowCount = 6;
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpCart.Size = new Size(420, 700);
            tlpCart.TabIndex = 0;
            //
            // lblCartTitle
            //
            lblCartTitle.AutoSize = true;
            lblCartTitle.Dock = DockStyle.Fill;
            lblCartTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCartTitle.Location = new Point(11, 8);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(398, 32);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "Giỏ hàng";
            lblCartTitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // dgvCart
            //
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { colName, colSize, colQty, colUnitPrice, colLineTotal });
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.Location = new Point(11, 43);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(398, 384);
            dgvCart.TabIndex = 1;
            //
            // columns
            //
            colName.HeaderText = "Món";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colSize.HeaderText = "Size";
            colSize.Name = "colSize";
            colSize.ReadOnly = true;
            colQty.FillWeight = 40F;
            colQty.HeaderText = "SL";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            colUnitPrice.HeaderText = "Đơn giá";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            colLineTotal.HeaderText = "Thành tiền";
            colLineTotal.Name = "colLineTotal";
            colLineTotal.ReadOnly = true;
            //
            // pnlLineActions
            //
            pnlLineActions.Controls.Add(btnQtyMinus);
            pnlLineActions.Controls.Add(btnQtyPlus);
            pnlLineActions.Controls.Add(btnRemoveLine);
            pnlLineActions.Controls.Add(btnLineNote);
            pnlLineActions.Controls.Add(btnSizeTopping);
            pnlLineActions.Dock = DockStyle.Fill;
            pnlLineActions.Location = new Point(11, 433);
            pnlLineActions.Name = "pnlLineActions";
            pnlLineActions.Size = new Size(398, 42);
            pnlLineActions.TabIndex = 2;
            pnlLineActions.WrapContents = false;
            //
            // btnQtyMinus
            //
            btnQtyMinus.Location = new Point(3, 3);
            btnQtyMinus.Name = "btnQtyMinus";
            btnQtyMinus.Size = new Size(40, 40);
            btnQtyMinus.TabIndex = 0;
            btnQtyMinus.Text = "−";
            btnQtyMinus.UseVisualStyleBackColor = true;
            btnQtyMinus.Click += btnQtyMinus_Click;
            //
            // btnQtyPlus
            //
            btnQtyPlus.Location = new Point(49, 3);
            btnQtyPlus.Name = "btnQtyPlus";
            btnQtyPlus.Size = new Size(40, 40);
            btnQtyPlus.TabIndex = 1;
            btnQtyPlus.Text = "+";
            btnQtyPlus.UseVisualStyleBackColor = true;
            btnQtyPlus.Click += btnQtyPlus_Click;
            //
            // btnRemoveLine
            //
            btnRemoveLine.Location = new Point(95, 3);
            btnRemoveLine.Name = "btnRemoveLine";
            btnRemoveLine.Size = new Size(80, 36);
            btnRemoveLine.TabIndex = 2;
            btnRemoveLine.Text = "Xóa dòng";
            btnRemoveLine.UseVisualStyleBackColor = true;
            btnRemoveLine.Click += btnRemoveLine_Click;
            //
            // btnLineNote
            //
            btnLineNote.Location = new Point(181, 3);
            btnLineNote.Name = "btnLineNote";
            btnLineNote.Size = new Size(70, 36);
            btnLineNote.TabIndex = 3;
            btnLineNote.Text = "Ghi chú";
            btnLineNote.UseVisualStyleBackColor = true;
            btnLineNote.Click += btnLineNote_Click;
            //
            // btnSizeTopping
            //
            btnSizeTopping.Location = new Point(257, 3);
            btnSizeTopping.Name = "btnSizeTopping";
            btnSizeTopping.Size = new Size(110, 36);
            btnSizeTopping.TabIndex = 4;
            btnSizeTopping.Text = "Size / Topping";
            btnSizeTopping.UseVisualStyleBackColor = true;
            btnSizeTopping.Click += btnSizeTopping_Click;
            //
            // tlpTotals
            //
            tlpTotals.ColumnCount = 2;
            tlpTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTotals.Controls.Add(lblSubTotalCaption, 0, 0);
            tlpTotals.Controls.Add(lblSubTotal, 1, 0);
            tlpTotals.Controls.Add(lblDiscountCaption, 0, 1);
            tlpTotals.Controls.Add(lblDiscount, 1, 1);
            tlpTotals.Controls.Add(lblTaxCaption, 0, 2);
            tlpTotals.Controls.Add(lblTax, 1, 2);
            tlpTotals.Controls.Add(lblTotalCaption, 0, 3);
            tlpTotals.Controls.Add(lblTotal, 1, 3);
            tlpTotals.Dock = DockStyle.Fill;
            tlpTotals.Location = new Point(11, 481);
            tlpTotals.Name = "tlpTotals";
            tlpTotals.RowCount = 4;
            tlpTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpTotals.Size = new Size(398, 94);
            tlpTotals.TabIndex = 3;
            //
            // totals labels
            //
            lblSubTotalCaption.Dock = DockStyle.Fill;
            lblSubTotalCaption.Location = new Point(3, 0);
            lblSubTotalCaption.Name = "lblSubTotalCaption";
            lblSubTotalCaption.Size = new Size(193, 23);
            lblSubTotalCaption.TabIndex = 0;
            lblSubTotalCaption.Text = "Tạm tính";
            lblSubTotalCaption.TextAlign = ContentAlignment.MiddleLeft;
            lblSubTotal.Anchor = AnchorStyles.Right;
            lblSubTotal.Location = new Point(202, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(193, 23);
            lblSubTotal.TabIndex = 1;
            lblSubTotal.Text = "0 đ";
            lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
            lblDiscountCaption.Dock = DockStyle.Fill;
            lblDiscountCaption.Location = new Point(3, 23);
            lblDiscountCaption.Name = "lblDiscountCaption";
            lblDiscountCaption.Size = new Size(193, 23);
            lblDiscountCaption.TabIndex = 2;
            lblDiscountCaption.Text = "Giảm giá";
            lblDiscountCaption.TextAlign = ContentAlignment.MiddleLeft;
            lblDiscount.Anchor = AnchorStyles.Right;
            lblDiscount.Location = new Point(202, 23);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(193, 23);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "0 đ";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            lblTaxCaption.Dock = DockStyle.Fill;
            lblTaxCaption.Location = new Point(3, 46);
            lblTaxCaption.Name = "lblTaxCaption";
            lblTaxCaption.Size = new Size(193, 23);
            lblTaxCaption.TabIndex = 4;
            lblTaxCaption.Text = "Thuế";
            lblTaxCaption.TextAlign = ContentAlignment.MiddleLeft;
            lblTax.Anchor = AnchorStyles.Right;
            lblTax.Location = new Point(202, 46);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(193, 23);
            lblTax.TabIndex = 5;
            lblTax.Text = "0 đ";
            lblTax.TextAlign = ContentAlignment.MiddleRight;
            lblTotalCaption.Dock = DockStyle.Fill;
            lblTotalCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalCaption.Location = new Point(3, 69);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(193, 25);
            lblTotalCaption.TabIndex = 6;
            lblTotalCaption.Text = "Tổng cộng";
            lblTotalCaption.TextAlign = ContentAlignment.MiddleLeft;
            lblTotal.Anchor = AnchorStyles.Right;
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotal.Location = new Point(202, 69);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(193, 25);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "0 đ";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            //
            // pnlCustomer
            //
            pnlCustomer.Controls.Add(lblCustomerName);
            pnlCustomer.Controls.Add(btnClearCustomer);
            pnlCustomer.Controls.Add(btnFindCustomer);
            pnlCustomer.Controls.Add(txtCustomerPhone);
            pnlCustomer.Dock = DockStyle.Fill;
            pnlCustomer.Location = new Point(11, 581);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(398, 66);
            pnlCustomer.TabIndex = 4;
            //
            // txtCustomerPhone
            //
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerPhone.Location = new Point(0, 4);
            txtCustomerPhone.MaxLength = 15;
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.PlaceholderText = "SĐT khách";
            txtCustomerPhone.Size = new Size(200, 25);
            txtCustomerPhone.TabIndex = 0;
            //
            // btnFindCustomer
            //
            btnFindCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFindCustomer.Location = new Point(210, 2);
            btnFindCustomer.Name = "btnFindCustomer";
            btnFindCustomer.Size = new Size(90, 28);
            btnFindCustomer.TabIndex = 1;
            btnFindCustomer.Text = "Gắn khách";
            btnFindCustomer.UseVisualStyleBackColor = true;
            btnFindCustomer.Click += btnFindCustomer_Click;
            //
            // btnClearCustomer
            //
            btnClearCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearCustomer.Location = new Point(306, 2);
            btnClearCustomer.Name = "btnClearCustomer";
            btnClearCustomer.Size = new Size(90, 28);
            btnClearCustomer.TabIndex = 2;
            btnClearCustomer.Text = "Bỏ khách";
            btnClearCustomer.UseVisualStyleBackColor = true;
            btnClearCustomer.Click += btnClearCustomer_Click;
            //
            // lblCustomerName
            //
            lblCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerName.Location = new Point(0, 36);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(398, 23);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Chưa gắn khách";
            //
            // pnlPayActions
            //
            pnlPayActions.ColumnCount = 3;
            pnlPayActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlPayActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlPayActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlPayActions.Controls.Add(btnCancelOrder, 0, 0);
            pnlPayActions.Controls.Add(btnDiscount, 1, 0);
            pnlPayActions.Controls.Add(btnPay, 2, 0);
            pnlPayActions.Dock = DockStyle.Fill;
            pnlPayActions.Location = new Point(11, 653);
            pnlPayActions.Name = "pnlPayActions";
            pnlPayActions.RowCount = 1;
            pnlPayActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlPayActions.Size = new Size(398, 50);
            pnlPayActions.TabIndex = 5;
            //
            // btnCancelOrder
            //
            btnCancelOrder.Dock = DockStyle.Fill;
            btnCancelOrder.Location = new Point(3, 3);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(113, 44);
            btnCancelOrder.TabIndex = 0;
            btnCancelOrder.Text = "Hủy đơn";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            //
            // btnDiscount
            //
            btnDiscount.Dock = DockStyle.Fill;
            btnDiscount.Location = new Point(122, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(113, 44);
            btnDiscount.TabIndex = 1;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            //
            // btnPay
            //
            btnPay.Dock = DockStyle.Fill;
            btnPay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPay.Location = new Point(241, 3);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(154, 44);
            btnPay.TabIndex = 2;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            //
            // ucCartPanel
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpCart);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(360, 480);
            Name = "ucCartPanel";
            Size = new Size(420, 700);
            tlpCart.ResumeLayout(false);
            tlpCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            pnlLineActions.ResumeLayout(false);
            tlpTotals.ResumeLayout(false);
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            pnlPayActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCart;
        private Label lblCartTitle;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSize;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colLineTotal;
        private FlowLayoutPanel pnlLineActions;
        private Button btnQtyMinus;
        private Button btnQtyPlus;
        private Button btnRemoveLine;
        private Button btnLineNote;
        private Button btnSizeTopping;
        private TableLayoutPanel tlpTotals;
        private Label lblSubTotalCaption;
        private Label lblSubTotal;
        private Label lblDiscountCaption;
        private Label lblDiscount;
        private Label lblTaxCaption;
        private Label lblTax;
        private Label lblTotalCaption;
        private Label lblTotal;
        private Panel pnlCustomer;
        private TextBox txtCustomerPhone;
        private Button btnFindCustomer;
        private Button btnClearCustomer;
        private Label lblCustomerName;
        private TableLayoutPanel pnlPayActions;
        private Button btnCancelOrder;
        private Button btnDiscount;
        private Button btnPay;
    }
}
