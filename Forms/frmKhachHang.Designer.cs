namespace winform_cuoi_ki
{
    partial class frmKhachHang
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

            Color mauNau = Color.FromArgb(125, 68, 39);       // nâu banner
            Color mauCamNhat = Color.FromArgb(242, 201, 160); // cam nhạt header section
            Color mauNen = Color.FromArgb(250, 244, 235);     // kem nền
            Color mauXanh = Color.FromArgb(46, 160, 67);      // xanh +
            Color mauDo = Color.FromArgb(180, 45, 45);        // đỏ nhấn
            Color mauCam = Color.FromArgb(196, 112, 48);      // cam nút phụ

            pnlBanner = new Panel();
            lblBanner = new Label();
            lblBannerSub = new Label();
            pnlToolbar = new Panel();
            flpToolbar = new FlowLayoutPanel();
            txtTim = new TextBox();
            btnTim = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();

            dgvMain = new DataGridView();
            colHoTen = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colDiem = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            sts = new StatusStrip();
            lblCount = new ToolStripStatusLabel();

            pnlBanner.SuspendLayout();
            pnlToolbar.SuspendLayout();
            flpToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            sts.SuspendLayout();
            SuspendLayout();

            // Banner nâu
            pnlBanner.BackColor = mauNau;
            pnlBanner.Controls.Add(lblBannerSub);
            pnlBanner.Controls.Add(lblBanner);
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(1000, 64);

            lblBanner.Dock = DockStyle.Top;
            lblBanner.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBanner.ForeColor = Color.White;
            lblBanner.Name = "lblBanner";
            lblBanner.Size = new Size(1000, 36);
            lblBanner.Text = "QUẢN LÝ KHÁCH HÀNG";
            lblBanner.TextAlign = ContentAlignment.MiddleCenter;

            lblBannerSub.Dock = DockStyle.Fill;
            lblBannerSub.Font = new Font("Segoe UI", 9F);
            lblBannerSub.ForeColor = Color.FromArgb(255, 235, 210);
            lblBannerSub.Name = "lblBannerSub";
            lblBannerSub.Text = "Khách & điểm tích lũy";
            lblBannerSub.TextAlign = ContentAlignment.TopCenter;

            // Toolbar cam nhạt
            pnlToolbar.BackColor = mauCamNhat;
            pnlToolbar.Controls.Add(flpToolbar);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(10, 8, 10, 8);
            pnlToolbar.Size = new Size(1000, 56);

            flpToolbar.BackColor = Color.Transparent;
            flpToolbar.Controls.AddRange(new Control[] { txtTim, btnTim, btnLamMoi, btnThem, btnSua, btnXoa });
            flpToolbar.Dock = DockStyle.Fill;
            flpToolbar.Name = "flpToolbar";
            flpToolbar.WrapContents = false;

            txtTim.Font = new Font("Segoe UI", 10F);
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Tìm kiếm…";
            txtTim.Size = new Size(200, 27);
            txtTim.Margin = new Padding(0, 2, 8, 0);

            btnTim.BackColor = mauCam;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.ForeColor = Color.White;
            btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(70, 34);
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            btnTim.Margin = new Padding(0, 0, 6, 0);

            btnLamMoi.BackColor = Color.White;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.FlatAppearance.BorderColor = mauNau;
            btnLamMoi.ForeColor = mauNau;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 34);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            btnLamMoi.Margin = new Padding(0, 0, 12, 0);

            btnThem.BackColor = mauNau;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.ForeColor = Color.White;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 34);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            btnThem.Margin = new Padding(0, 0, 6, 0);

            btnSua.BackColor = mauCam;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.ForeColor = Color.White;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 34);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            btnSua.Margin = new Padding(0, 0, 6, 0);

            btnXoa.BackColor = mauDo;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.ForeColor = Color.White;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 34);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            btnXoa.Margin = new Padding(0, 0, 12, 0);



            // Grid
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.BackgroundColor = Color.White;
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = mauNau;
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMain.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMain.ColumnHeadersHeight = 36;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { colHoTen, colSDT, colDiem, colGhiChu });
            dgvMain.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 160, 110);
            dgvMain.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.GridColor = Color.FromArgb(230, 210, 190);
            dgvMain.MultiSelect = false;
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowTemplate.Height = 32;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            colHoTen.HeaderText = "Họ tên"; colHoTen.Name = "colHoTen"; colHoTen.ReadOnly = true;
            colSDT.HeaderText = "SĐT"; colSDT.Name = "colSDT"; colSDT.ReadOnly = true;
            colDiem.HeaderText = "Điểm"; colDiem.Name = "colDiem"; colDiem.ReadOnly = true;
            colGhiChu.HeaderText = "Ghi chú"; colGhiChu.Name = "colGhiChu"; colGhiChu.ReadOnly = true;

            sts.BackColor = mauCamNhat;
            sts.Items.Add(lblCount);
            sts.Name = "sts";
            lblCount.ForeColor = mauNau;
            lblCount.Name = "lblCount";
            lblCount.Spring = true;
            lblCount.Text = "0 dòng";

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = mauNen;
            ClientSize = new Size(1000, 620);
            Controls.Add(dgvMain);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlBanner);
            Controls.Add(sts);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimizeBox = false;
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Khách hàng";
            Load += frmKhachHang_Load;

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
        private Label lblBannerSub;
        private Panel pnlToolbar;
        private FlowLayoutPanel flpToolbar;
        private TextBox txtTim;
        private Button btnTim;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;

        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colDiem;
        private DataGridViewTextBoxColumn colGhiChu;
        private StatusStrip sts;
        private ToolStripStatusLabel lblCount;
    }
}
