namespace winform_cuoi_ki
{
    partial class frmMain
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
            pnlSidebar = new Panel();
            flpNav = new FlowLayoutPanel();
            lblApp = new Label();
            btnBanHang = new Button();
            btnSanPham = new Button();
            btnDanhMuc = new Button();
            btnNguyenLieu = new Button();
            btnNhapKho = new Button();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnMoCa = new Button();
            btnChotCa = new Button();
            btnDangXuat = new Button();
            pnlContent = new Panel();
            stsMain = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            pnlSidebar.SuspendLayout();
            flpNav.SuspendLayout();
            stsMain.SuspendLayout();
            SuspendLayout();
            pnlSidebar.Controls.Add(flpNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 720);
            flpNav.Controls.AddRange(new Control[] { lblApp, btnBanHang, btnSanPham, btnDanhMuc, btnNguyenLieu, btnNhapKho, btnHoaDon, btnNhanVien, btnKhachHang, btnMoCa, btnChotCa, btnDangXuat });
            flpNav.Dock = DockStyle.Fill;
            flpNav.FlowDirection = FlowDirection.TopDown;
            flpNav.Name = "flpNav";
            flpNav.Padding = new Padding(8);
            flpNav.WrapContents = false;
            lblApp.AutoSize = true;
            lblApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApp.Name = "lblApp";
            lblApp.Text = "Cafe Win";
            void Nav(Button b, string name, string text, EventHandler h)
            {
                b.Name = name; b.Text = text; b.Size = new Size(170, 40); b.Margin = new Padding(4);
                b.UseVisualStyleBackColor = true; b.Click += h;
            }
            Nav(btnBanHang, "btnBanHang", "Bán hàng", btnBanHang_Click);
            Nav(btnSanPham, "btnSanPham", "Sản phẩm", btnSanPham_Click);
            Nav(btnDanhMuc, "btnDanhMuc", "Danh mục", btnDanhMuc_Click);
            Nav(btnNguyenLieu, "btnNguyenLieu", "Nguyên liệu", btnNguyenLieu_Click);
            Nav(btnNhapKho, "btnNhapKho", "Nhập kho", btnNhapKho_Click);
            Nav(btnHoaDon, "btnHoaDon", "Hóa đơn", btnHoaDon_Click);
            Nav(btnNhanVien, "btnNhanVien", "Nhân viên", btnNhanVien_Click);
            Nav(btnKhachHang, "btnKhachHang", "Khách hàng", btnKhachHang_Click);
            Nav(btnMoCa, "btnMoCa", "Mở ca", btnMoCa_Click);
            Nav(btnChotCa, "btnChotCa", "Chốt ca", btnChotCa_Click);
            Nav(btnDangXuat, "btnDangXuat", "Đăng xuất", btnDangXuat_Click);
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Name = "pnlContent";
            stsMain.Items.Add(lblTrangThai);
            stsMain.Name = "stsMain";
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Spring = true;
            lblTrangThai.Text = "Sẵn sàng";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(stsMain);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1024, 640);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cafe";
            Load += frmMain_Load;
            pnlSidebar.ResumeLayout(false);
            flpNav.ResumeLayout(false);
            flpNav.PerformLayout();
            stsMain.ResumeLayout(false);
            stsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel pnlSidebar;
        private FlowLayoutPanel flpNav;
        private Label lblApp;
        private Button btnBanHang;
        private Button btnSanPham;
        private Button btnDanhMuc;
        private Button btnNguyenLieu;
        private Button btnNhapKho;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnMoCa;
        private Button btnChotCa;
        private Button btnDangXuat;
        private Panel pnlContent;
        private StatusStrip stsMain;
        private ToolStripStatusLabel lblTrangThai;
    }
}
