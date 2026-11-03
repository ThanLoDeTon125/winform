namespace winform_cuoi_ki
{
    partial class frmShiftOpen
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
            components = new System.ComponentModel.Container();
            tlpRoot = new TableLayoutPanel();
            lblUserInfo = new Label();
            lblOpenTime = new Label();
            lblOpeningCash = new Label();
            nudOpeningCash = new NumericUpDown();
            lblCounter = new Label();
            txtCounterName = new TextBox();
            lblNote = new Label();
            txtNote = new TextBox();
            lblShiftOpenError = new Label();
            pnlButtons = new FlowLayoutPanel();
            btnCancel = new Button();
            btnConfirm = new Button();
            erpShiftOpen = new ErrorProvider(components);
            tlpRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudOpeningCash).BeginInit();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpShiftOpen).BeginInit();
            SuspendLayout();
            //
            // tlpRoot
            //
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(lblUserInfo, 0, 0);
            tlpRoot.Controls.Add(lblOpenTime, 0, 1);
            tlpRoot.Controls.Add(lblOpeningCash, 0, 2);
            tlpRoot.Controls.Add(nudOpeningCash, 0, 3);
            tlpRoot.Controls.Add(lblCounter, 0, 4);
            tlpRoot.Controls.Add(txtCounterName, 0, 5);
            tlpRoot.Controls.Add(lblNote, 0, 6);
            tlpRoot.Controls.Add(txtNote, 0, 7);
            tlpRoot.Controls.Add(lblShiftOpenError, 0, 8);
            tlpRoot.Controls.Add(pnlButtons, 0, 9);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(16);
            tlpRoot.RowCount = 10;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRoot.Size = new Size(420, 300);
            tlpRoot.TabIndex = 0;
            //
            // lblUserInfo
            //
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserInfo.Location = new Point(19, 16);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(150, 19);
            lblUserInfo.TabIndex = 0;
            lblUserInfo.Text = "NV: … — Vai trò";
            //
            // lblOpenTime
            //
            lblOpenTime.AutoSize = true;
            lblOpenTime.Location = new Point(19, 44);
            lblOpenTime.Name = "lblOpenTime";
            lblOpenTime.Size = new Size(120, 19);
            lblOpenTime.TabIndex = 1;
            lblOpenTime.Text = "Thời điểm mở: …";
            //
            // lblOpeningCash
            //
            lblOpeningCash.AutoSize = true;
            lblOpeningCash.Location = new Point(19, 68);
            lblOpeningCash.Name = "lblOpeningCash";
            lblOpeningCash.Size = new Size(130, 19);
            lblOpeningCash.TabIndex = 2;
            lblOpeningCash.Text = "Tiền mặt đầu ca";
            //
            // nudOpeningCash
            //
            nudOpeningCash.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudOpeningCash.Location = new Point(19, 95);
            nudOpeningCash.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudOpeningCash.Name = "nudOpeningCash";
            nudOpeningCash.Size = new Size(382, 25);
            nudOpeningCash.TabIndex = 0;
            nudOpeningCash.ThousandsSeparator = true;
            //
            // lblCounter
            //
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(19, 124);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(80, 19);
            lblCounter.TabIndex = 4;
            lblCounter.Text = "Quầy / máy";
            //
            // txtCounterName
            //
            txtCounterName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCounterName.Location = new Point(19, 151);
            txtCounterName.MaxLength = 50;
            txtCounterName.Name = "txtCounterName";
            txtCounterName.Size = new Size(382, 25);
            txtCounterName.TabIndex = 1;
            //
            // lblNote
            //
            lblNote.AutoSize = true;
            lblNote.Location = new Point(19, 180);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(55, 19);
            lblNote.TabIndex = 6;
            lblNote.Text = "Ghi chú";
            //
            // txtNote
            //
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.Location = new Point(19, 207);
            txtNote.MaxLength = 200;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(382, 25);
            txtNote.TabIndex = 2;
            //
            // lblShiftOpenError
            //
            lblShiftOpenError.AutoSize = true;
            lblShiftOpenError.ForeColor = Color.Red;
            lblShiftOpenError.Location = new Point(19, 236);
            lblShiftOpenError.Name = "lblShiftOpenError";
            lblShiftOpenError.Size = new Size(0, 19);
            lblShiftOpenError.TabIndex = 8;
            lblShiftOpenError.Visible = false;
            //
            // pnlButtons
            //
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnConfirm);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Location = new Point(19, 255);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(382, 42);
            pnlButtons.TabIndex = 9;
            //
            // btnCancel
            //
            btnCancel.Location = new Point(279, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 36);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            //
            // btnConfirm
            //
            btnConfirm.Location = new Point(153, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 36);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Mở ca";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            //
            // erpShiftOpen
            //
            erpShiftOpen.ContainerControl = this;
            //
            // frmShiftOpen
            //
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(420, 300);
            Controls.Add(tlpRoot);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShiftOpen";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mở ca làm việc";
            Load += frmShiftOpen_Load;
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudOpeningCash).EndInit();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpShiftOpen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Label lblUserInfo;
        private Label lblOpenTime;
        private Label lblOpeningCash;
        private NumericUpDown nudOpeningCash;
        private Label lblCounter;
        private TextBox txtCounterName;
        private Label lblNote;
        private TextBox txtNote;
        private Label lblShiftOpenError;
        private FlowLayoutPanel pnlButtons;
        private Button btnConfirm;
        private Button btnCancel;
        private ErrorProvider erpShiftOpen;
    }
}
