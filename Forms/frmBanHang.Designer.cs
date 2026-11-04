namespace winform_cuoi_ki
{
    partial class frmBanHang
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
            Color mauNau = Color.FromArgb(125, 68, 39);
            Color mauCamNhat = Color.FromArgb(242, 201, 160);
            Color mauNen = Color.FromArgb(250, 244, 235);
            Color mauXanh = Color.FromArgb(46, 160, 67);
            Color mauDo = Color.FromArgb(180, 45, 45);

            pnlBanner = new Panel();
            lblBannerTitle = new Label();
            lblBannerSub = new Label();

            splMain = new SplitContainer();

            pnlTrai = new Panel();
            lblThucDon = new Label();
            pnlTimKiem = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            flpMon = new FlowLayoutPanel();

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
            btnDong = new Button();

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
            SuspendLayout();

            // Banner
            pnlBanner.BackColor = mauNau;
            pnlBanner.Controls.Add(lblBannerSub);
            pnlBanner.Controls.Add(lblBannerTitle);
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(1200, 72);

            lblBannerTitle.Dock = DockStyle.Top;
            lblBannerTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBannerTitle.ForeColor = Color.White;
            lblBannerTitle.Name = "lblBannerTitle";
            lblBannerTitle.Size = new Size(1200, 40);
            lblBannerTitle.Text = "HỆ THỐNG POS ORDER & THANH TOÁN TẠI QUẦY";
            lblBannerTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblBannerSub.Dock = DockStyle.Fill;
            lblBannerSub.Font = new Font("Segoe UI", 9F);
            lblBannerSub.ForeColor = Color.FromArgb(255, 235, 210);
            lblBannerSub.Name = "lblBannerSub";
            lblBannerSub.Text = "Hệ Thống Bán Hàng Order Tại Quầy Chuyên Nghiệp (Counter-Service POS)";
            lblBannerSub.TextAlign = ContentAlignment.TopCenter;

            // Split
            splMain.Dock = DockStyle.Fill;
            splMain.Name = "splMain";
            splMain.Panel1MinSize = 480;
            splMain.Panel2MinSize = 360;
            splMain.SplitterDistance = 760;
            splMain.SplitterWidth = 6;
            splMain.Panel1.Controls.Add(pnlTrai);
            splMain.Panel2.Controls.Add(pnlPhai);

            // Left
            pnlTrai.BackColor = mauNen;
            pnlTrai.Controls.Add(flpMon);
            pnlTrai.Controls.Add(pnlTimKiem);
            pnlTrai.Controls.Add(lblThucDon);
            pnlTrai.Dock = DockStyle.Fill;
            pnlTrai.Name = "pnlTrai";
            pnlTrai.Padding = new Padding(12);

            lblThucDon.BackColor = mauCamNhat;
            lblThucDon.Dock = DockStyle.Top;
            lblThucDon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblThucDon.ForeColor = mauNau;
            lblThucDon.Name = "lblThucDon";
            lblThucDon.Padding = new Padding(8, 0, 0, 0);
            lblThucDon.Size = new Size(736, 40);
            lblThucDon.Text = "THỰC ĐƠN ĐỒ UỐNG & BÁNH  (CLICK MÓN ĐỂ THÊM VÀO ĐƠN)";
            lblThucDon.TextAlign = ContentAlignment.MiddleLeft;

            pnlTimKiem.BackColor = Color.FromArgb(255, 248, 238);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Padding = new Padding(8, 4, 8, 8);
            pnlTimKiem.Size = new Size(736, 44);

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
            txtTimKiem.Size = new Size(630, 27);
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            flpMon.AutoScroll = true;
            flpMon.BackColor = Color.White;
            flpMon.BorderStyle = BorderStyle.FixedSingle;
            flpMon.Dock = DockStyle.Fill;
            flpMon.Name = "flpMon";
            flpMon.Padding = new Padding(10);
            flpMon.WrapContents = true;

            // Right
            pnlPhai.BackColor = mauNen;
            pnlPhai.Controls.Add(pnlTongKet);
            pnlPhai.Controls.Add(dgvHoaDon);
            pnlPhai.Controls.Add(pnlThongTinDon);
            pnlPhai.Controls.Add(lblHoaDonTitle);
            pnlPhai.Dock = DockStyle.Fill;
            pnlPhai.Name = "pnlPhai";
            pnlPhai.Padding = new Padding(10);

            lblHoaDonTitle.BackColor = mauCamNhat;
            lblHoaDonTitle.Dock = DockStyle.Top;
            lblHoaDonTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHoaDonTitle.ForeColor = mauNau;
            lblHoaDonTitle.Name = "lblHoaDonTitle";
            lblHoaDonTitle.Padding = new Padding(8, 0, 0, 0);
            lblHoaDonTitle.Size = new Size(414, 40);
            lblHoaDonTitle.Text = "HÓA ĐƠN ĐẶT HÀNG";
            lblHoaDonTitle.TextAlign = ContentAlignment.MiddleLeft;

            pnlThongTinDon.BackColor = Color.White;
            pnlThongTinDon.Controls.Add(txtGhiChu);
            pnlThongTinDon.Controls.Add(lblGhiChu);
            pnlThongTinDon.Controls.Add(cboLoaiDon);
            pnlThongTinDon.Controls.Add(lblLoaiDon);
            pnlThongTinDon.Controls.Add(btnDonMoi);
            pnlThongTinDon.Controls.Add(lblMaDon);
            pnlThongTinDon.Dock = DockStyle.Top;
            pnlThongTinDon.Name = "pnlThongTinDon";
            pnlThongTinDon.Padding = new Padding(4);
            pnlThongTinDon.Size = new Size(414, 108);

            lblMaDon.AutoSize = true;
            lblMaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaDon.ForeColor = mauDo;
            lblMaDon.Location = new Point(4, 8);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Text = "Đơn hàng: HD2026…";

            btnDonMoi.BackColor = mauXanh;
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
            txtGhiChu.Size = new Size(320, 27);

            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.BorderStyle = BorderStyle.None;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.BackColor = mauNau;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvHoaDon.ColumnHeadersHeight = 34;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colTenMon, colSL, colDonGia, colThanhTien });
            dgvHoaDon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 160, 110);
            dgvHoaDon.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.GridColor = Color.FromArgb(230, 210, 190);
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

            pnlTongKet.BackColor = mauCamNhat;
            pnlTongKet.Controls.Add(btnDong);
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
            pnlTongKet.Padding = new Padding(8);
            pnlTongKet.Size = new Size(414, 168);

            lblTongTienHangCaption.AutoSize = true;
            lblTongTienHangCaption.Location = new Point(8, 12);
            lblTongTienHangCaption.Name = "lblTongTienHangCaption";
            lblTongTienHangCaption.Text = "Tổng tiền hàng:";

            lblTongTienHang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTongTienHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTienHang.Location = new Point(240, 12);
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
            lblKhachCanTra.Location = new Point(180, 72);
            lblKhachCanTra.Name = "lblKhachCanTra";
            lblKhachCanTra.Size = new Size(220, 36);
            lblKhachCanTra.Text = "0 đ";
            lblKhachCanTra.TextAlign = ContentAlignment.MiddleRight;

            btnXoaDong.BackColor = mauDo;
            btnXoaDong.FlatStyle = FlatStyle.Flat;
            btnXoaDong.FlatAppearance.BorderSize = 0;
            btnXoaDong.ForeColor = Color.White;
            btnXoaDong.Location = new Point(8, 116);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(90, 36);
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = false;
            btnXoaDong.Click += btnXoaDong_Click;

            btnThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThanhToan.BackColor = mauNau;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(110, 112);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(180, 40);
            btnThanhToan.Text = "THANH TOÁN";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;

            btnDong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDong.BackColor = Color.White;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.FlatAppearance.BorderColor = mauNau;
            btnDong.ForeColor = mauNau;
            btnDong.Location = new Point(300, 112);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(100, 40);
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = mauNen;
            ClientSize = new Size(1200, 720);
            Controls.Add(splMain);
            Controls.Add(pnlBanner);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1100, 700);
            Name = "frmBanHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hệ Thống Bán Hàng Tại Quầy - Quản Lý Quán Cafe (Counter-Service POS)";
            Load += frmBanHang_Load;

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
            ResumeLayout(false);
        }

        #endregion

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
        private Button btnDong;
    }
}
