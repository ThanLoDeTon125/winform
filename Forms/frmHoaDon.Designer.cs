namespace winform_cuoi_ki
{
    partial class frmHoaDon
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
            Color mauNau = Color.FromArgb(109, 58, 32);
            Color mauNen = Color.FromArgb(245, 240, 232);

            pnlBanner = new Panel();
            lblBanner = new Label();
            pnlToolbar = new Panel();
            flpToolbar = new FlowLayoutPanel();
            txtTim = new TextBox();
            btnTim = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();

            btnXem = new Button();
            btnXem.BackColor = Color.FromArgb(109, 58, 32);
            btnXem.FlatStyle = FlatStyle.Flat;
            btnXem.ForeColor = Color.White;
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(120, 30);
            btnXem.Text = "Xem chi tiết";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            dgvMain = new DataGridView();
            colSoHD = new DataGridViewTextBoxColumn();
            colGio = new DataGridViewTextBoxColumn();
            colNV = new DataGridViewTextBoxColumn();
            colKhach = new DataGridViewTextBoxColumn();
            colTong = new DataGridViewTextBoxColumn();
            colTT = new DataGridViewTextBoxColumn();
            sts = new StatusStrip();
            lblCount = new ToolStripStatusLabel();
            pnlBanner.SuspendLayout();
            pnlToolbar.SuspendLayout();
            flpToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            sts.SuspendLayout();
            SuspendLayout();
            pnlBanner.BackColor = mauNau;
            pnlBanner.Controls.Add(lblBanner);
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(1000, 56);
            lblBanner.Dock = DockStyle.Fill;
            lblBanner.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBanner.ForeColor = Color.White;
            lblBanner.Name = "lblBanner";
            lblBanner.Text = "LỊCH SỬ HÓA ĐƠN";
            lblBanner.TextAlign = ContentAlignment.MiddleCenter;

            pnlToolbar.BackColor = mauNen;
            pnlToolbar.Controls.Add(flpToolbar);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(8);
            pnlToolbar.Size = new Size(1000, 52);
            flpToolbar.Controls.AddRange(new Control[] { txtTim, btnTim, btnLamMoi, btnThem, btnSua, btnXoa, btnXem });
            flpToolbar.Dock = DockStyle.Fill;
            flpToolbar.Name = "flpToolbar";
            flpToolbar.WrapContents = false;
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Tìm…";
            txtTim.Size = new Size(180, 27);
            btnTim.Name = "btnTim"; btnTim.Size = new Size(70, 30); btnTim.Text = "Tìm"; btnTim.UseVisualStyleBackColor = true; btnTim.Click += btnTim_Click;
            btnLamMoi.Name = "btnLamMoi"; btnLamMoi.Size = new Size(90, 30); btnLamMoi.Text = "Làm mới"; btnLamMoi.UseVisualStyleBackColor = true; btnLamMoi.Click += btnLamMoi_Click;
            btnThem.BackColor = mauNau; btnThem.FlatStyle = FlatStyle.Flat; btnThem.ForeColor = Color.White; btnThem.Name = "btnThem"; btnThem.Size = new Size(70, 30); btnThem.Text = "Thêm"; btnThem.UseVisualStyleBackColor = false; btnThem.Click += btnThem_Click;
            btnSua.Name = "btnSua"; btnSua.Size = new Size(70, 30); btnSua.Text = "Sửa"; btnSua.UseVisualStyleBackColor = true; btnSua.Click += btnSua_Click;
            btnXoa.Name = "btnXoa"; btnXoa.Size = new Size(70, 30); btnXoa.Text = "Xóa"; btnXoa.UseVisualStyleBackColor = true; btnXoa.Click += btnXoa_Click;
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.BackgroundColor = Color.White;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { colSoHD, colGio, colNV, colKhach, colTong, colTT });
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.MultiSelect = false;
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowHeadersVisible = false;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colSoHD.HeaderText = "Số đơn"; colSoHD.Name = "colSoHD"; colSoHD.ReadOnly = true;
            colGio.HeaderText = "Giờ"; colGio.Name = "colGio"; colGio.ReadOnly = true;
            colNV.HeaderText = "Thu ngân"; colNV.Name = "colNV"; colNV.ReadOnly = true;
            colKhach.HeaderText = "Khách"; colKhach.Name = "colKhach"; colKhach.ReadOnly = true;
            colTong.HeaderText = "Tổng"; colTong.Name = "colTong"; colTong.ReadOnly = true;
            colTT.HeaderText = "Trạng thái"; colTT.Name = "colTT"; colTT.ReadOnly = true;
            sts.Items.Add(lblCount);
            sts.Name = "sts";
            lblCount.Name = "lblCount";
            lblCount.Spring = true;
            lblCount.Text = "0 dòng";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = mauNen;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvMain);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlBanner);
            Controls.Add(sts);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimizeBox = false;
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lịch sử hóa đơn";
            Load += frmHoaDon_Load;
            pnlBanner.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            flpToolbar.ResumeLayout(false);
            flpToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            sts.ResumeLayout(false);
            sts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel pnlBanner;
        private Label lblBanner;
        private Panel pnlToolbar;
        private FlowLayoutPanel flpToolbar;
        private TextBox txtTim;
        private Button btnTim;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnXem;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn colSoHD;
        private DataGridViewTextBoxColumn colGio;
        private DataGridViewTextBoxColumn colNV;
        private DataGridViewTextBoxColumn colKhach;
        private DataGridViewTextBoxColumn colTong;
        private DataGridViewTextBoxColumn colTT;
        private StatusStrip sts;
        private ToolStripStatusLabel lblCount;
    }
}
