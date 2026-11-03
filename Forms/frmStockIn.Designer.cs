namespace winform_cuoi_ki
{
    partial class frmStockIn
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
            pnlHeader = new Panel();
            tlpHeader = new TableLayoutPanel();
            lblDate = new Label();
            dtpStockInDate = new DateTimePicker();
            lblSupplier = new Label();
            txtSupplier = new TextBox();
            lblHeaderNote = new Label();
            txtHeaderNote = new TextBox();
            lblVoucherNo = new Label();
            pnlLineTools = new Panel();
            flpLineTools = new FlowLayoutPanel();
            lblIngredient = new Label();
            cboIngredient = new ComboBox();
            lblQty = new Label();
            nudQty = new NumericUpDown();
            lblUnitCost = new Label();
            nudUnitCost = new NumericUpDown();
            btnAddLine = new Button();
            btnRemoveLine = new Button();
            dgvStockInLines = new DataGridView();
            colLineIng = new DataGridViewTextBoxColumn();
            colLineUnit = new DataGridViewTextBoxColumn();
            colLineQty = new DataGridViewTextBoxColumn();
            colLineCost = new DataGridViewTextBoxColumn();
            colLineAmount = new DataGridViewTextBoxColumn();
            pnlFooter = new Panel();
            lblLinesTotalCaption = new Label();
            lblGrandTotal = new Label();
            lblStockInError = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            erpStockIn = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            tlpHeader.SuspendLayout();
            pnlLineTools.SuspendLayout();
            flpLineTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockInLines).BeginInit();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpStockIn).BeginInit();
            SuspendLayout();
            // header
            pnlHeader.Controls.Add(tlpHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(960, 72);
            tlpHeader.ColumnCount = 4;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHeader.Controls.Add(lblDate, 0, 0);
            tlpHeader.Controls.Add(dtpStockInDate, 1, 0);
            tlpHeader.Controls.Add(lblSupplier, 2, 0);
            tlpHeader.Controls.Add(txtSupplier, 3, 0);
            tlpHeader.Controls.Add(lblHeaderNote, 0, 1);
            tlpHeader.Controls.Add(txtHeaderNote, 1, 1);
            tlpHeader.Controls.Add(lblVoucherNo, 2, 1);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Name = "tlpHeader";
            tlpHeader.Padding = new Padding(8);
            tlpHeader.RowCount = 2;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lblDate.Text = "Ngày nhập"; lblDate.AutoSize = true; lblDate.Anchor = AnchorStyles.Left; lblDate.Name = "lblDate";
            dtpStockInDate.Format = DateTimePickerFormat.Short; dtpStockInDate.Name = "dtpStockInDate"; dtpStockInDate.Anchor = AnchorStyles.Left;
            lblSupplier.Text = "Nhà cung cấp"; lblSupplier.AutoSize = true; lblSupplier.Anchor = AnchorStyles.Left; lblSupplier.Name = "lblSupplier";
            txtSupplier.Name = "txtSupplier"; txtSupplier.MaxLength = 150; txtSupplier.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblHeaderNote.Text = "Ghi chú phiếu"; lblHeaderNote.AutoSize = true; lblHeaderNote.Anchor = AnchorStyles.Left; lblHeaderNote.Name = "lblHeaderNote";
            txtHeaderNote.Name = "txtHeaderNote"; txtHeaderNote.MaxLength = 300; txtHeaderNote.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblVoucherNo.Text = "Phiếu: (chưa lưu)"; lblVoucherNo.AutoSize = true; lblVoucherNo.Anchor = AnchorStyles.Left; lblVoucherNo.Name = "lblVoucherNo";
            // line tools
            pnlLineTools.Controls.Add(flpLineTools);
            pnlLineTools.Dock = DockStyle.Top;
            pnlLineTools.Name = "pnlLineTools";
            pnlLineTools.Size = new Size(960, 44);
            flpLineTools.Controls.AddRange(new Control[] { lblIngredient, cboIngredient, lblQty, nudQty, lblUnitCost, nudUnitCost, btnAddLine, btnRemoveLine });
            flpLineTools.Dock = DockStyle.Fill;
            flpLineTools.Name = "flpLineTools";
            flpLineTools.Padding = new Padding(8, 6, 8, 0);
            flpLineTools.WrapContents = false;
            lblIngredient.AutoSize = true; lblIngredient.Name = "lblIngredient"; lblIngredient.Text = "Nguyên liệu"; lblIngredient.Padding = new Padding(0, 6, 0, 0);
            cboIngredient.DropDownStyle = ComboBoxStyle.DropDownList; cboIngredient.Name = "cboIngredient"; cboIngredient.Size = new Size(200, 23);
            lblQty.AutoSize = true; lblQty.Name = "lblQty"; lblQty.Text = "Số lượng"; lblQty.Padding = new Padding(0, 6, 0, 0);
            nudQty.Name = "nudQty"; nudQty.DecimalPlaces = 2; nudQty.Minimum = 0.01M; nudQty.Maximum = 100000000; nudQty.Value = 1; nudQty.Width = 100;
            lblUnitCost.AutoSize = true; lblUnitCost.Name = "lblUnitCost"; lblUnitCost.Text = "Đơn giá"; lblUnitCost.Padding = new Padding(0, 6, 0, 0);
            nudUnitCost.Name = "nudUnitCost"; nudUnitCost.Maximum = 100000000; nudUnitCost.Width = 100;
            btnAddLine.Name = "btnAddLine"; btnAddLine.Size = new Size(100, 28); btnAddLine.Text = "Thêm dòng"; btnAddLine.UseVisualStyleBackColor = true; btnAddLine.Click += btnAddLine_Click;
            btnRemoveLine.Name = "btnRemoveLine"; btnRemoveLine.Size = new Size(90, 28); btnRemoveLine.Text = "Xóa dòng"; btnRemoveLine.UseVisualStyleBackColor = true; btnRemoveLine.Click += btnRemoveLine_Click;
            // grid
            dgvStockInLines.AllowUserToAddRows = false;
            dgvStockInLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockInLines.Columns.AddRange(new DataGridViewColumn[] { colLineIng, colLineUnit, colLineQty, colLineCost, colLineAmount });
            dgvStockInLines.Dock = DockStyle.Fill;
            dgvStockInLines.MultiSelect = false;
            dgvStockInLines.Name = "dgvStockInLines";
            dgvStockInLines.ReadOnly = true;
            dgvStockInLines.RowHeadersVisible = false;
            dgvStockInLines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colLineIng.HeaderText = "Nguyên liệu"; colLineIng.Name = "colLineIng"; colLineIng.ReadOnly = true;
            colLineUnit.HeaderText = "Đơn vị"; colLineUnit.Name = "colLineUnit"; colLineUnit.ReadOnly = true;
            colLineQty.HeaderText = "SL"; colLineQty.Name = "colLineQty"; colLineQty.ReadOnly = true;
            colLineCost.HeaderText = "Đơn giá"; colLineCost.Name = "colLineCost"; colLineCost.ReadOnly = true;
            colLineAmount.HeaderText = "Thành tiền"; colLineAmount.Name = "colLineAmount"; colLineAmount.ReadOnly = true;
            // footer
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnConfirm);
            pnlFooter.Controls.Add(lblStockInError);
            pnlFooter.Controls.Add(lblGrandTotal);
            pnlFooter.Controls.Add(lblLinesTotalCaption);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(960, 88);
            lblLinesTotalCaption.AutoSize = true; lblLinesTotalCaption.Location = new Point(12, 12); lblLinesTotalCaption.Name = "lblLinesTotalCaption"; lblLinesTotalCaption.Text = "Tổng cộng";
            lblGrandTotal.AutoSize = true; lblGrandTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblGrandTotal.Location = new Point(120, 10); lblGrandTotal.Name = "lblGrandTotal"; lblGrandTotal.Text = "0 đ";
            lblStockInError.AutoSize = true; lblStockInError.ForeColor = Color.Red; lblStockInError.Location = new Point(12, 48); lblStockInError.Name = "lblStockInError"; lblStockInError.Visible = false;
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right; btnConfirm.Location = new Point(680, 36); btnConfirm.Name = "btnConfirm"; btnConfirm.Size = new Size(140, 36); btnConfirm.Text = "Xác nhận nhập"; btnConfirm.UseVisualStyleBackColor = true; btnConfirm.Click += btnConfirm_Click;
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right; btnCancel.Location = new Point(832, 36); btnCancel.Name = "btnCancel"; btnCancel.Size = new Size(100, 36); btnCancel.Text = "Hủy"; btnCancel.UseVisualStyleBackColor = true; btnCancel.Click += btnCancel_Click;
            erpStockIn.ContainerControl = this;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 620);
            Controls.Add(dgvStockInLines);
            Controls.Add(pnlLineTools);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFooter);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(860, 540);
            Name = "frmStockIn";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập kho";
            Load += frmStockIn_Load;
            pnlHeader.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            tlpHeader.PerformLayout();
            pnlLineTools.ResumeLayout(false);
            flpLineTools.ResumeLayout(false);
            flpLineTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockInLines).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpStockIn).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlHeader;
        private TableLayoutPanel tlpHeader;
        private Label lblDate;
        private DateTimePicker dtpStockInDate;
        private Label lblSupplier;
        private TextBox txtSupplier;
        private Label lblHeaderNote;
        private TextBox txtHeaderNote;
        private Label lblVoucherNo;
        private Panel pnlLineTools;
        private FlowLayoutPanel flpLineTools;
        private Label lblIngredient;
        private ComboBox cboIngredient;
        private Label lblQty;
        private NumericUpDown nudQty;
        private Label lblUnitCost;
        private NumericUpDown nudUnitCost;
        private Button btnAddLine;
        private Button btnRemoveLine;
        private DataGridView dgvStockInLines;
        private DataGridViewTextBoxColumn colLineIng;
        private DataGridViewTextBoxColumn colLineUnit;
        private DataGridViewTextBoxColumn colLineQty;
        private DataGridViewTextBoxColumn colLineCost;
        private DataGridViewTextBoxColumn colLineAmount;
        private Panel pnlFooter;
        private Label lblLinesTotalCaption;
        private Label lblGrandTotal;
        private Label lblStockInError;
        private Button btnConfirm;
        private Button btnCancel;
        private ErrorProvider erpStockIn;
    }
}
