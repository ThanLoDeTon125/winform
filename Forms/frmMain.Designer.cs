namespace winform_cuoi_ki
{
    partial class frmMain
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
            Color mauNau = Color.FromArgb(109, 58, 32);
            Color mauNen = Color.FromArgb(245, 240, 232);

            mnuMain = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuMoCa = new ToolStripMenuItem();
            mnuChotCa = new ToolStripMenuItem();
            mnuSep1 = new ToolStripSeparator();
            mnuDangXuat = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuNguyenLieu = new ToolStripMenuItem();
            mnuNhapKho = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            mnuTroGiupMenu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();

            pnlBanner = new Panel();
            lblBannerTitle = new Label();
            lblBannerSub = new Label();

            splMain = new SplitContainer();

            // Left
            pnlTrai = new Panel();
            lblThucDon = new Label();
            pnlTimKiem = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            flpMon = new FlowLayoutPanel();

            // Right
            pnlPhai = new Panel();
            lblHoaDonTitle = new Label();
            pnlThongTinDon = new Panel();
            lblMaDon = new Label();
            btnDonMoi = new Button();
            lblLoaiDon = new Label();
            cboLoaiDon = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            dgvHoaDon = new DataGridView();
            colTenMon = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            pnlTongKet = new Panel();
            lblTongTienHangCaption = new Label();
            lblTongTienHang = new Label();
            lblGiamGiaCaption = new Label();
            nudGiamGia = new NumericUpDown();
            lblKhachCanTraCaption = new Label();
            lblKhachCanTra = new Label();
            btnXoaDong = new Button();
            btnThanhToan = new Button();

            stsMain = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();

            mnuMain.SuspendLayout();
            pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splMain).BeginInit();
            splMain.Panel1.SuspendLayout();
            splMain.Panel2.SuspendLayout();
            splMain.SuspendLayout();
            pnlTrai.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            pnlPhai.SuspendLayout();
            pnlThongTinDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            pnlTongKet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiamGia).BeginInit();
            stsMain.SuspendLayout();
            SuspendLayout();

            // ===== MenuStrip =====
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuThongKe, mnuTroGiupMenu });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1280, 28);
            mnuMain.Font = new Font("Segoe UI", 10F);

            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuMoCa, mnuChotCa, mnuSep1, mnuDangXuat, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Text = "Hệ thống";
            mnuMoCa.Name = "mnuMoCa";
            mnuMoCa.Text = "Mở ca";
            mnuMoCa.Click += mnuMoCa_Click;
            mnuChotCa.Name = "mnuChotCa";
            mnuChotCa.Text = "Chốt ca";
            mnuChotCa.Click += mnuChotCa_Click;
            mnuSep1.Name = "mnuSep1";
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;

            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] {
                mnuSanPham, mnuDanhMuc, mnuNguyenLieu, mnuNhapKho, mnuHoaDon, mnuNhanVien, mnuKhachHang });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Text = "Quản lý";
            mnuSanPham.Name = "mnuSanPham"; mnuSanPham.Text = "Sản phẩm"; mnuSanPham.Click += mnuSanPham_Click;
            mnuDanhMuc.Name = "mnuDanhMuc"; mnuDanhMuc.Text = "Danh mục"; mnuDanhMuc.Click += mnuDanhMuc_Click;
            mnuNguyenLieu.Name = "mnuNguyenLieu"; mnuNguyenLieu.Text = "Nguyên liệu"; mnuNguyenLieu.Click += mnuNguyenLieu_Click;
            mnuNhapKho.Name = "mnuNhapKho"; mnuNhapKho.Text = "Nhập kho"; mnuNhapKho.Click += mnuNhapKho_Click;
            mnuHoaDon.Name = "mnuHoaDon"; mnuHoaDon.Text = "Lịch sử hóa đơn"; mnuHoaDon.Click += mnuHoaDon_Click;
            mnuNhanVien.Name = "mnuNhanVien"; mnuNhanVien.Text = "Nhân viên"; mnuNhanVien.Click += mnuNhanVien_Click;
            mnuKhachHang.Name = "mnuKhachHang"; mnuKhachHang.Text = "Khách hàng"; mnuKhachHang.Click += mnuKhachHang_Click;

            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Text = "Thống kê";
            mnuThongKe.Click += (_, _) => MessageBox.Show("TODO: thống kê doanh thu.", "Thống kê");

            mnuTroGiupMenu.DropDownItems.Add(mnuTroGiup);
            mnuTroGiupMenu.Name = "mnuTroGiupMenu";
            mnuTroGiupMenu.Text = "Trợ giúp";
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Text = "Giới thiệu";
            mnuTroGiup.Click += mnuTroGiup_Click;

            // ===== Banner nâu =====
            pnlBanner.BackColor = mauNau;
            pnlBanner.Controls.Add(lblBannerSub);
            pnlBanner.Controls.Add(lblBannerTitle);
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Location = new Point(0, 28);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(1280, 72);

            lblBannerTitle.Dock = DockStyle.Top;
            lblBannerTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBannerTitle.ForeColor = Color.White;
            lblBannerTitle.Name = "lblBannerTitle";
            lblBannerTitle.Size = new Size(1280, 40);
            lblBannerTitle.Text = "HỆ THỐNG POS ORDER & THANH TOÁN TẠI QUẦY";
            lblBannerTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblBannerSub.Dock = DockStyle.Fill;
            lblBannerSub.Font = new Font("Segoe UI", 9F);
            lblBannerSub.ForeColor = Color.FromArgb(255, 235, 210);
            lblBannerSub.Name = "lblBannerSub";
            lblBannerSub.Text = "Hệ Thống Bán Hàng Order Tại Quầy Chuyên Nghiệp (Counter-Service POS)";
            lblBannerSub.TextAlign = ContentAlignment.TopCenter;

            // ===== Split =====
            splMain.Dock = DockStyle.Fill;
            splMain.Location = new Point(0, 100);
            splMain.Name = "splMain";
            splMain.Panel1MinSize = 480;
            splMain.Panel2MinSize = 360;
            splMain.Size = new Size(1280, 578);
            splMain.SplitterDistance = 820;
            splMain.SplitterWidth = 6;
            splMain.Panel1.Controls.Add(pnlTrai);
            splMain.Panel2.Controls.Add(pnlPhai);

            // ===== LEFT: Thực đơn =====
            pnlTrai.BackColor = mauNen;
            pnlTrai.Controls.Add(flpMon);
            pnlTrai.Controls.Add(pnlTimKiem);
            pnlTrai.Controls.Add(lblThucDon);
            pnlTrai.Dock = DockStyle.Fill;
            pnlTrai.Name = "pnlTrai";
            pnlTrai.Padding = new Padding(12);

            lblThucDon.Dock = DockStyle.Top;
            lblThucDon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblThucDon.ForeColor = mauNau;
            lblThucDon.Name = "lblThucDon";
            lblThucDon.Size = new Size(796, 36);
            lblThucDon.Text = "THỰC ĐƠN ĐỒ UỐNG & BÁNH  (CLICK MÓN ĐỂ THÊM VÀO ĐƠN)";
            lblThucDon.TextAlign = ContentAlignment.MiddleLeft;

            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Padding = new Padding(0, 4, 0, 8);
            pnlTimKiem.Size = new Size(796, 40);

            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimKiem.Location = new Point(0, 10);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Text = "Tìm kiếm:";

            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(90, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên đồ uống hoặc bánh cần tìm kiếm...";
            txtTimKiem.Size = new Size(690, 27);
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            flpMon.AutoScroll = true;
            flpMon.BackColor = Color.White;
            flpMon.BorderStyle = BorderStyle.FixedSingle;
            flpMon.Dock = DockStyle.Fill;
            flpMon.Name = "flpMon";
            flpMon.Padding = new Padding(10);
            flpMon.WrapContents = true;

            // ===== RIGHT: Hóa đơn =====
            pnlPhai.BackColor = mauNen;
            pnlPhai.Controls.Add(pnlTongKet);
            pnlPhai.Controls.Add(dgvHoaDon);
            pnlPhai.Controls.Add(pnlThongTinDon);
            pnlPhai.Controls.Add(lblHoaDonTitle);
            pnlPhai.Dock = DockStyle.Fill;
            pnlPhai.Name = "pnlPhai";
            pnlPhai.Padding = new Padding(10);

            lblHoaDonTitle.Dock = DockStyle.Top;
            lblHoaDonTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHoaDonTitle.ForeColor = mauNau;
            lblHoaDonTitle.Name = "lblHoaDonTitle";
            lblHoaDonTitle.Size = new Size(434, 32);
            lblHoaDonTitle.Text = "HÓA ĐƠN ĐẶT HÀNG";
            lblHoaDonTitle.TextAlign = ContentAlignment.MiddleLeft;

            pnlThongTinDon.Controls.Add(txtGhiChu);
            pnlThongTinDon.Controls.Add(lblGhiChu);
            pnlThongTinDon.Controls.Add(cboLoaiDon);
            pnlThongTinDon.Controls.Add(lblLoaiDon);
            pnlThongTinDon.Controls.Add(btnDonMoi);
            pnlThongTinDon.Controls.Add(lblMaDon);
            pnlThongTinDon.Dock = DockStyle.Top;
            pnlThongTinDon.Name = "pnlThongTinDon";
            pnlThongTinDon.Size = new Size(434, 100);

            lblMaDon.AutoSize = true;
            lblMaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaDon.Location = new Point(4, 8);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Text = "Đơn hàng: HD2026…";

            btnDonMoi.BackColor = Color.FromArgb(46, 160, 67);
            btnDonMoi.FlatStyle = FlatStyle.Flat;
            btnDonMoi.ForeColor = Color.White;
            btnDonMoi.Location = new Point(250, 4);
            btnDonMoi.Name = "btnDonMoi";
            btnDonMoi.Size = new Size(36, 28);
            btnDonMoi.Text = "+";
            btnDonMoi.UseVisualStyleBackColor = false;
            btnDonMoi.Click += btnDonMoi_Click;

            lblLoaiDon.AutoSize = true;
            lblLoaiDon.Location = new Point(4, 42);
            lblLoaiDon.Name = "lblLoaiDon";
            lblLoaiDon.Text = "Loại đơn:";

            cboLoaiDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiDon.FormattingEnabled = true;
            cboLoaiDon.Items.AddRange(new object[] { "Tại quầy", "Mang đi", "Giao hàng" });
            cboLoaiDon.Location = new Point(80, 38);
            cboLoaiDon.Name = "cboLoaiDon";
            cboLoaiDon.Size = new Size(200, 28);

            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(4, 72);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Text = "Ghi chú:";

            txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGhiChu.Location = new Point(80, 68);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Ghi chú món (ít đá, ngọt vừa, mang về...)";
            txtGhiChu.Size = new Size(340, 27);

            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colTenMon, colSL, colDonGia, colThanhTien });
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            colTenMon.HeaderText = "Món";
            colTenMon.Name = "colTenMon";
            colTenMon.ReadOnly = true;
            colSL.FillWeight = 40F;
            colSL.HeaderText = "SL";
            colSL.Name = "colSL";
            colSL.ReadOnly = true;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;

            // Totals
            pnlTongKet.Controls.Add(btnThanhToan);
            pnlTongKet.Controls.Add(btnXoaDong);
            pnlTongKet.Controls.Add(lblKhachCanTra);
            pnlTongKet.Controls.Add(lblKhachCanTraCaption);
            pnlTongKet.Controls.Add(nudGiamGia);
            pnlTongKet.Controls.Add(lblGiamGiaCaption);
            pnlTongKet.Controls.Add(lblTongTienHang);
            pnlTongKet.Controls.Add(lblTongTienHangCaption);
            pnlTongKet.Dock = DockStyle.Bottom;
            pnlTongKet.Name = "pnlTongKet";
            pnlTongKet.Padding = new Padding(4);
            pnlTongKet.Size = new Size(434, 160);

            lblTongTienHangCaption.AutoSize = true;
            lblTongTienHangCaption.Location = new Point(8, 12);
            lblTongTienHangCaption.Name = "lblTongTienHangCaption";
            lblTongTienHangCaption.Text = "Tổng tiền hàng:";

            lblTongTienHang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTongTienHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTienHang.Location = new Point(260, 12);
            lblTongTienHang.Name = "lblTongTienHang";
            lblTongTienHang.Size = new Size(160, 23);
            lblTongTienHang.Text = "0 đ";
            lblTongTienHang.TextAlign = ContentAlignment.MiddleRight;

            lblGiamGiaCaption.AutoSize = true;
            lblGiamGiaCaption.Location = new Point(8, 44);
            lblGiamGiaCaption.Name = "lblGiamGiaCaption";
            lblGiamGiaCaption.Text = "Giảm giá (%):";

            nudGiamGia.Location = new Point(120, 40);
            nudGiamGia.Maximum = 100;
            nudGiamGia.Name = "nudGiamGia";
            nudGiamGia.Size = new Size(80, 27);
            nudGiamGia.ValueChanged += nudGiamGia_ValueChanged;

            lblKhachCanTraCaption.AutoSize = true;
            lblKhachCanTraCaption.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKhachCanTraCaption.ForeColor = mauNau;
            lblKhachCanTraCaption.Location = new Point(8, 80);
            lblKhachCanTraCaption.Name = "lblKhachCanTraCaption";
            lblKhachCanTraCaption.Text = "KHÁCH CẦN TRẢ:";

            lblKhachCanTra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblKhachCanTra.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblKhachCanTra.ForeColor = mauNau;
            lblKhachCanTra.Location = new Point(200, 72);
            lblKhachCanTra.Name = "lblKhachCanTra";
            lblKhachCanTra.Size = new Size(220, 36);
            lblKhachCanTra.Text = "0 đ";
            lblKhachCanTra.TextAlign = ContentAlignment.MiddleRight;

            btnXoaDong.Location = new Point(8, 116);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(100, 36);
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;

            btnThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThanhToan.BackColor = mauNau;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(200, 112);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(220, 40);
            btnThanhToan.Text = "THANH TOÁN";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;

            // Status
            stsMain.Items.Add(lblStatus);
            stsMain.Name = "stsMain";
            lblStatus.Name = "lblStatus";
            lblStatus.Spring = true;
            lblStatus.Text = "Sẵn sàng — Counter-Service POS";

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = mauNen;
            ClientSize = new Size(1280, 720);
            Controls.Add(splMain);
            Controls.Add(pnlBanner);
            Controls.Add(stsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = mnuMain;
            MinimumSize = new Size(1100, 700);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Bán Hàng Tại Quầy - Quản Lý Quán Cafe (Counter-Service POS)";
            Load += frmMain_Load;

            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            pnlBanner.ResumeLayout(false);
            splMain.Panel1.ResumeLayout(false);
            splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splMain).EndInit();
            splMain.ResumeLayout(false);
            pnlTrai.ResumeLayout(false);
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            pnlPhai.ResumeLayout(false);
            pnlThongTinDon.ResumeLayout(false);
            pnlThongTinDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            pnlTongKet.ResumeLayout(false);
            pnlTongKet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiamGia).EndInit();
            stsMain.ResumeLayout(false);
            stsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuMoCa;
        private ToolStripMenuItem mnuChotCa;
        private ToolStripSeparator mnuSep1;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuNguyenLieu;
        private ToolStripMenuItem mnuNhapKho;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem mnuTroGiupMenu;
        private ToolStripMenuItem mnuTroGiup;

        private Panel pnlBanner;
        private Label lblBannerTitle;
        private Label lblBannerSub;
        private SplitContainer splMain;

        private Panel pnlTrai;
        private Label lblThucDon;
        private Panel pnlTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private FlowLayoutPanel flpMon;

        private Panel pnlPhai;
        private Label lblHoaDonTitle;
        private Panel pnlThongTinDon;
        private Label lblMaDon;
        private Button btnDonMoi;
        private Label lblLoaiDon;
        private ComboBox cboLoaiDon;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn colTenMon;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private Panel pnlTongKet;
        private Label lblTongTienHangCaption;
        private Label lblTongTienHang;
        private Label lblGiamGiaCaption;
        private NumericUpDown nudGiamGia;
        private Label lblKhachCanTraCaption;
        private Label lblKhachCanTra;
        private Button btnXoaDong;
        private Button btnThanhToan;

        private StatusStrip stsMain;
        private ToolStripStatusLabel lblStatus;
    }
}
