namespace winform_cuoi_ki
{
    partial class frmNhapKho
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
            pnlToolbar = new Panel();
            flpToolbar = new FlowLayoutPanel();
            txtTim = new TextBox();
            btnTim = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();

            btnXacNhan = new Button();
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(120, 30);
            btnXacNhan.Text = "Xác nhận nhập";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            dgvMain = new DataGridView();
            colNL = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            sts = new StatusStrip();
            lblCount = new ToolStripStatusLabel();
            pnlToolbar.SuspendLayout();
            flpToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            sts.SuspendLayout();
            SuspendLayout();
            pnlToolbar.Controls.Add(flpToolbar);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(8);
            pnlToolbar.Size = new Size(1000, 48);
            flpToolbar.Controls.AddRange(new Control[] { txtTim, btnTim, btnLamMoi, btnThem, btnSua, btnXoa, btnXacNhan });
            flpToolbar.Dock = DockStyle.Fill;
            flpToolbar.Name = "flpToolbar";
            flpToolbar.WrapContents = false;
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Tìm…";
            txtTim.Size = new Size(180, 27);
            btnTim.Name = "btnTim"; btnTim.Size = new Size(70, 30); btnTim.Text = "Tìm"; btnTim.UseVisualStyleBackColor = true; btnTim.Click += btnTim_Click;
            btnLamMoi.Name = "btnLamMoi"; btnLamMoi.Size = new Size(90, 30); btnLamMoi.Text = "Làm mới"; btnLamMoi.UseVisualStyleBackColor = true; btnLamMoi.Click += btnLamMoi_Click;
            btnThem.Name = "btnThem"; btnThem.Size = new Size(70, 30); btnThem.Text = "Thêm"; btnThem.UseVisualStyleBackColor = true; btnThem.Click += btnThem_Click;
            btnSua.Name = "btnSua"; btnSua.Size = new Size(70, 30); btnSua.Text = "Sửa"; btnSua.UseVisualStyleBackColor = true; btnSua.Click += btnSua_Click;
            btnXoa.Name = "btnXoa"; btnXoa.Size = new Size(70, 30); btnXoa.Text = "Xóa"; btnXoa.UseVisualStyleBackColor = true; btnXoa.Click += btnXoa_Click;
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { colNL, colSL, colDonGia, colThanhTien });
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.MultiSelect = false;
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowHeadersVisible = false;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colNL.HeaderText = "Nguyên liệu"; colNL.Name = "colNL"; colNL.ReadOnly = true;
            colSL.HeaderText = "SL"; colSL.Name = "colSL"; colSL.ReadOnly = true;
            colDonGia.HeaderText = "Đơn giá"; colDonGia.Name = "colDonGia"; colDonGia.ReadOnly = true;
            colThanhTien.HeaderText = "Thành tiền"; colThanhTien.Name = "colThanhTien"; colThanhTien.ReadOnly = true;
            sts.Items.Add(lblCount);
            sts.Name = "sts";
            lblCount.Name = "lblCount";
            lblCount.Spring = true;
            lblCount.Text = "0 dòng";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvMain);
            Controls.Add(pnlToolbar);
            Controls.Add(sts);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNhapKho";
            Text = "Nhập kho";
            Load += frmNhapKho_Load;
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

        private Panel pnlToolbar;
        private FlowLayoutPanel flpToolbar;
        private TextBox txtTim;
        private Button btnTim;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnXacNhan;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn colNL;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private StatusStrip sts;
        private ToolStripStatusLabel lblCount;
    }
}
