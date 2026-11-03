
namespace winform_cuoi_ki
{
    partial class frmPos
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
            pnlTopBar = new Panel();
            lblPosTitle = new Label();
            lblCashier = new Label();
            lblShift = new Label();
            lblClock = new Label();
            btnSearch = new Button();
            btnBackMain = new Button();
            stsPos = new StatusStrip();
            lblPosHint = new ToolStripStatusLabel();
            splPos = new SplitContainer();
            flpCategories = new FlowLayoutPanel();
            btnCatAll = new Button();
            ucProductGrid = new ucProductGrid();
            pnlProductTools = new Panel();
            txtProductFilter = new TextBox();
            ucCartPanel = new ucCartPanel();
            tmrPosClock = new System.Windows.Forms.Timer(components);
            pnlTopBar.SuspendLayout();
            stsPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splPos).BeginInit();
            splPos.Panel1.SuspendLayout();
            splPos.Panel2.SuspendLayout();
            splPos.SuspendLayout();
            flpCategories.SuspendLayout();
            pnlProductTools.SuspendLayout();
            SuspendLayout();
            //
            // pnlTopBar
            //
            pnlTopBar.Controls.Add(btnBackMain);
            pnlTopBar.Controls.Add(btnSearch);
            pnlTopBar.Controls.Add(lblClock);
            pnlTopBar.Controls.Add(lblShift);
            pnlTopBar.Controls.Add(lblCashier);
            pnlTopBar.Controls.Add(lblPosTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1366, 52);
            pnlTopBar.TabIndex = 0;
            //
            // lblPosTitle
            //
            lblPosTitle.AutoSize = true;
            lblPosTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPosTitle.Location = new Point(12, 12);
            lblPosTitle.Name = "lblPosTitle";
            lblPosTitle.Size = new Size(48, 25);
            lblPosTitle.TabIndex = 0;
            lblPosTitle.Text = "POS";
            //
            // lblCashier
            //
            lblCashier.AutoSize = true;
            lblCashier.Location = new Point(90, 18);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(40, 19);
            lblCashier.TabIndex = 1;
            lblCashier.Text = "NV: …";
            //
            // lblShift
            //
            lblShift.AutoSize = true;
            lblShift.Location = new Point(220, 18);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(40, 19);
            lblShift.TabIndex = 2;
            lblShift.Text = "Ca: …";
            //
            // lblClock
            //
            lblClock.AutoSize = true;
            lblClock.Location = new Point(360, 18);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(60, 19);
            lblClock.TabIndex = 3;
            lblClock.Text = "00:00:00";
            //
            // btnSearch
            //
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(1140, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 32);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm món";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            //
            // btnBackMain
            //
            btnBackMain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBackMain.Location = new Point(1250, 10);
            btnBackMain.Name = "btnBackMain";
            btnBackMain.Size = new Size(100, 32);
            btnBackMain.TabIndex = 5;
            btnBackMain.Text = "Về menu";
            btnBackMain.UseVisualStyleBackColor = true;
            btnBackMain.Click += btnBackMain_Click;
            //
            // stsPos
            //
            stsPos.Items.AddRange(new ToolStripItem[] { lblPosHint });
            stsPos.Location = new Point(0, 746);
            stsPos.Name = "stsPos";
            stsPos.Size = new Size(1366, 22);
            stsPos.TabIndex = 1;
            //
            // lblPosHint
            //
            lblPosHint.Name = "lblPosHint";
            lblPosHint.Size = new Size(1351, 17);
            lblPosHint.Spring = true;
            lblPosHint.Text = "F4 Thanh toán | Esc đóng (tuỳ cấu hình)";
            //
            // splPos
            //
            splPos.Dock = DockStyle.Fill;
            splPos.Location = new Point(0, 52);
            splPos.Name = "splPos";
            //
            // splPos.Panel1
            //
            splPos.Panel1.Controls.Add(ucProductGrid);
            splPos.Panel1.Controls.Add(pnlProductTools);
            splPos.Panel1.Controls.Add(flpCategories);
            splPos.Panel1MinSize = 480;
            //
            // splPos.Panel2
            //
            splPos.Panel2.Controls.Add(ucCartPanel);
            splPos.Panel2MinSize = 360;
            splPos.Size = new Size(1366, 694);
            splPos.SplitterDistance = 846;
            splPos.TabIndex = 2;
            //
            // flpCategories
            //
            flpCategories.Controls.Add(btnCatAll);
            flpCategories.Dock = DockStyle.Top;
            flpCategories.Location = new Point(0, 0);
            flpCategories.Name = "flpCategories";
            flpCategories.Size = new Size(846, 56);
            flpCategories.TabIndex = 0;
            flpCategories.WrapContents = true;
            //
            // btnCatAll
            //
            btnCatAll.Location = new Point(4, 4);
            btnCatAll.Margin = new Padding(4);
            btnCatAll.Name = "btnCatAll";
            btnCatAll.Size = new Size(80, 36);
            btnCatAll.TabIndex = 0;
            btnCatAll.Text = "Tất cả";
            btnCatAll.UseVisualStyleBackColor = true;
            //
            // ucProductGrid
            //
            ucProductGrid.Dock = DockStyle.Fill;
            ucProductGrid.Location = new Point(0, 56);
            ucProductGrid.MinimumSize = new Size(320, 240);
            ucProductGrid.Name = "ucProductGrid";
            ucProductGrid.Size = new Size(846, 594);
            ucProductGrid.TabIndex = 1;
            //
            // pnlProductTools
            //
            pnlProductTools.Controls.Add(txtProductFilter);
            pnlProductTools.Dock = DockStyle.Bottom;
            pnlProductTools.Location = new Point(0, 650);
            pnlProductTools.Name = "pnlProductTools";
            pnlProductTools.Padding = new Padding(8);
            pnlProductTools.Size = new Size(846, 44);
            pnlProductTools.TabIndex = 2;
            //
            // txtProductFilter
            //
            txtProductFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductFilter.Location = new Point(8, 10);
            txtProductFilter.Name = "txtProductFilter";
            txtProductFilter.PlaceholderText = "Tìm món…";
            txtProductFilter.Size = new Size(830, 25);
            txtProductFilter.TabIndex = 0;
            txtProductFilter.TextChanged += txtProductFilter_TextChanged;
            //
            // ucCartPanel
            //
            ucCartPanel.Dock = DockStyle.Fill;
            ucCartPanel.Location = new Point(0, 0);
            ucCartPanel.MinimumSize = new Size(360, 480);
            ucCartPanel.Name = "ucCartPanel";
            ucCartPanel.Size = new Size(516, 694);
            ucCartPanel.TabIndex = 0;
            //
            // tmrPosClock
            //
            tmrPosClock.Interval = 1000;
            tmrPosClock.Tick += tmrPosClock_Tick;
            //
            // frmPos
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(splPos);
            Controls.Add(stsPos);
            Controls.Add(pnlTopBar);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            MinimumSize = new Size(1100, 700);
            Name = "frmPos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán hàng — POS";
            FormClosing += frmPos_FormClosing;
            Load += frmPos_Load;
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            stsPos.ResumeLayout(false);
            stsPos.PerformLayout();
            splPos.Panel1.ResumeLayout(false);
            splPos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splPos).EndInit();
            splPos.ResumeLayout(false);
            flpCategories.ResumeLayout(false);
            pnlProductTools.ResumeLayout(false);
            pnlProductTools.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopBar;
        private Label lblPosTitle;
        private Label lblCashier;
        private Label lblShift;
        private Label lblClock;
        private Button btnSearch;
        private Button btnBackMain;
        private StatusStrip stsPos;
        private ToolStripStatusLabel lblPosHint;
        private SplitContainer splPos;
        private FlowLayoutPanel flpCategories;
        private Button btnCatAll;
        private ucProductGrid ucProductGrid;
        private Panel pnlProductTools;
        private TextBox txtProductFilter;
        private ucCartPanel ucCartPanel;
        private System.Windows.Forms.Timer tmrPosClock;
    }
}
