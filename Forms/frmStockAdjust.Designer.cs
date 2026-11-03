namespace winform_cuoi_ki
{
    partial class frmStockAdjust
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
            tlpRoot = new TableLayoutPanel();
            lblIngredient = new Label();
            cboIngredient = new ComboBox();
            lblUnit = new Label();
            lblUnitValue = new Label();
            lblSystemQty = new Label();
            lblSystemQtyValue = new Label();
            rdoByCounted = new RadioButton();
            rdoByDelta = new RadioButton();
            lblCounted = new Label();
            nudCountedQty = new NumericUpDown();
            lblDelta = new Label();
            nudDeltaQty = new NumericUpDown();
            lblResultQty = new Label();
            lblReason = new Label();
            cboReason = new ComboBox();
            txtReasonOther = new TextBox();
            lblAdjustNote = new Label();
            txtAdjustNote = new TextBox();
            lblAdjustError = new Label();
            pnlButtons = new FlowLayoutPanel();
            btnCancel = new Button();
            btnConfirm = new Button();
            erpAdjust = new ErrorProvider(components);
            tlpRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCountedQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDeltaQty).BeginInit();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpAdjust).BeginInit();
            SuspendLayout();
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpRoot.Controls.Add(lblIngredient, 0, 0);
            tlpRoot.Controls.Add(cboIngredient, 1, 0);
            tlpRoot.Controls.Add(lblUnit, 0, 1);
            tlpRoot.Controls.Add(lblUnitValue, 1, 1);
            tlpRoot.Controls.Add(lblSystemQty, 0, 2);
            tlpRoot.Controls.Add(lblSystemQtyValue, 1, 2);
            tlpRoot.SetColumnSpan(rdoByCounted, 2);
            tlpRoot.Controls.Add(rdoByCounted, 0, 3);
            tlpRoot.SetColumnSpan(rdoByDelta, 2);
            tlpRoot.Controls.Add(rdoByDelta, 0, 4);
            tlpRoot.Controls.Add(lblCounted, 0, 5);
            tlpRoot.Controls.Add(nudCountedQty, 1, 5);
            tlpRoot.Controls.Add(lblDelta, 0, 6);
            tlpRoot.Controls.Add(nudDeltaQty, 1, 6);
            tlpRoot.SetColumnSpan(lblResultQty, 2);
            tlpRoot.Controls.Add(lblResultQty, 0, 7);
            tlpRoot.Controls.Add(lblReason, 0, 8);
            tlpRoot.Controls.Add(cboReason, 1, 8);
            tlpRoot.SetColumnSpan(txtReasonOther, 2);
            tlpRoot.Controls.Add(txtReasonOther, 0, 9);
            tlpRoot.Controls.Add(lblAdjustNote, 0, 10);
            tlpRoot.Controls.Add(txtAdjustNote, 1, 10);
            tlpRoot.SetColumnSpan(lblAdjustError, 2);
            tlpRoot.Controls.Add(lblAdjustError, 0, 11);
            tlpRoot.SetColumnSpan(pnlButtons, 2);
            tlpRoot.Controls.Add(pnlButtons, 0, 12);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(16);
            tlpRoot.RowCount = 13;
            for (int i = 0; i < 13; i++)
                tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, i == 12 ? 48F : 32F));
            lblIngredient.Text = "Nguyên liệu"; lblIngredient.AutoSize = true; lblIngredient.Anchor = AnchorStyles.Left; lblIngredient.Name = "lblIngredient";
            cboIngredient.DropDownStyle = ComboBoxStyle.DropDownList; cboIngredient.Anchor = AnchorStyles.Left | AnchorStyles.Right; cboIngredient.Name = "cboIngredient"; cboIngredient.SelectedIndexChanged += cboIngredient_SelectedIndexChanged;
            lblUnit.Text = "Đơn vị"; lblUnit.AutoSize = true; lblUnit.Anchor = AnchorStyles.Left; lblUnit.Name = "lblUnit";
            lblUnitValue.Text = "g"; lblUnitValue.AutoSize = true; lblUnitValue.Anchor = AnchorStyles.Left; lblUnitValue.Name = "lblUnitValue";
            lblSystemQty.Text = "Tồn trên sổ"; lblSystemQty.AutoSize = true; lblSystemQty.Anchor = AnchorStyles.Left; lblSystemQty.Name = "lblSystemQty";
            lblSystemQtyValue.Text = "0"; lblSystemQtyValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblSystemQtyValue.AutoSize = true; lblSystemQtyValue.Name = "lblSystemQtyValue";
            rdoByCounted.AutoSize = true; rdoByCounted.Checked = true; rdoByCounted.Name = "rdoByCounted"; rdoByCounted.Text = "Nhập tồn thực tế"; rdoByCounted.CheckedChanged += rdoByCounted_CheckedChanged;
            rdoByDelta.AutoSize = true; rdoByDelta.Name = "rdoByDelta"; rdoByDelta.Text = "Nhập số điều chỉnh (+/−)"; rdoByDelta.CheckedChanged += rdoByDelta_CheckedChanged;
            lblCounted.Text = "Tồn thực tế"; lblCounted.AutoSize = true; lblCounted.Name = "lblCounted";
            nudCountedQty.Name = "nudCountedQty"; nudCountedQty.DecimalPlaces = 2; nudCountedQty.Maximum = 100000000; nudCountedQty.Anchor = AnchorStyles.Left | AnchorStyles.Right; nudCountedQty.ValueChanged += nudCountedQty_ValueChanged;
            lblDelta.Text = "Số điều chỉnh"; lblDelta.AutoSize = true; lblDelta.Name = "lblDelta";
            nudDeltaQty.Name = "nudDeltaQty"; nudDeltaQty.DecimalPlaces = 2; nudDeltaQty.Minimum = -100000000; nudDeltaQty.Maximum = 100000000; nudDeltaQty.Anchor = AnchorStyles.Left | AnchorStyles.Right; nudDeltaQty.ValueChanged += nudDeltaQty_ValueChanged;
            lblResultQty.Text = "Tồn sau điều chỉnh: 0"; lblResultQty.AutoSize = true; lblResultQty.Name = "lblResultQty";
            lblReason.Text = "Lý do"; lblReason.AutoSize = true; lblReason.Name = "lblReason";
            cboReason.DropDownStyle = ComboBoxStyle.DropDownList; cboReason.Items.AddRange(new object[] { "Kiểm kê", "Hao hụt", "Hủy hàng", "Khác" }); cboReason.Name = "cboReason"; cboReason.Anchor = AnchorStyles.Left | AnchorStyles.Right; cboReason.SelectedIndexChanged += cboReason_SelectedIndexChanged;
            txtReasonOther.Name = "txtReasonOther"; txtReasonOther.MaxLength = 200; txtReasonOther.Anchor = AnchorStyles.Left | AnchorStyles.Right; txtReasonOther.Visible = false;
            lblAdjustNote.Text = "Ghi chú"; lblAdjustNote.AutoSize = true; lblAdjustNote.Name = "lblAdjustNote";
            txtAdjustNote.Name = "txtAdjustNote"; txtAdjustNote.MaxLength = 300; txtAdjustNote.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblAdjustError.ForeColor = Color.Red; lblAdjustError.AutoSize = true; lblAdjustError.Name = "lblAdjustError"; lblAdjustError.Visible = false;
            pnlButtons.Controls.Add(btnCancel); pnlButtons.Controls.Add(btnConfirm);
            pnlButtons.Dock = DockStyle.Fill; pnlButtons.FlowDirection = FlowDirection.RightToLeft; pnlButtons.Name = "pnlButtons";
            btnCancel.Name = "btnCancel"; btnCancel.Size = new Size(100, 36); btnCancel.Text = "Hủy"; btnCancel.UseVisualStyleBackColor = true; btnCancel.Click += btnCancel_Click;
            btnConfirm.Name = "btnConfirm"; btnConfirm.Size = new Size(120, 36); btnConfirm.Text = "Xác nhận"; btnConfirm.UseVisualStyleBackColor = true; btnConfirm.Click += btnConfirm_Click;
            erpAdjust.ContainerControl = this;
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(560, 480);
            Controls.Add(tlpRoot);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(520, 400);
            Name = "frmStockAdjust";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Điều chỉnh tồn kho";
            Load += frmStockAdjust_Load;
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCountedQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDeltaQty).EndInit();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpAdjust).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel tlpRoot;
        private Label lblIngredient;
        private ComboBox cboIngredient;
        private Label lblUnit;
        private Label lblUnitValue;
        private Label lblSystemQty;
        private Label lblSystemQtyValue;
        private RadioButton rdoByCounted;
        private RadioButton rdoByDelta;
        private Label lblCounted;
        private NumericUpDown nudCountedQty;
        private Label lblDelta;
        private NumericUpDown nudDeltaQty;
        private Label lblResultQty;
        private Label lblReason;
        private ComboBox cboReason;
        private TextBox txtReasonOther;
        private Label lblAdjustNote;
        private TextBox txtAdjustNote;
        private Label lblAdjustError;
        private FlowLayoutPanel pnlButtons;
        private Button btnConfirm;
        private Button btnCancel;
        private ErrorProvider erpAdjust;
    }
}
