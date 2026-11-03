namespace winform_cuoi_ki
{
    partial class ucProductGrid
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            flpProducts = new FlowLayoutPanel();
            btnProductSample = new Button();
            lblEmpty = new Label();
            flpProducts.SuspendLayout();
            SuspendLayout();
            //
            // flpProducts
            //
            flpProducts.AutoScroll = true;
            flpProducts.Controls.Add(btnProductSample);
            flpProducts.Dock = DockStyle.Fill;
            flpProducts.Location = new Point(0, 0);
            flpProducts.Name = "flpProducts";
            flpProducts.Padding = new Padding(8);
            flpProducts.Size = new Size(700, 500);
            flpProducts.TabIndex = 0;
            flpProducts.WrapContents = true;
            //
            // btnProductSample
            //
            btnProductSample.Location = new Point(14, 14);
            btnProductSample.Margin = new Padding(6);
            btnProductSample.Name = "btnProductSample";
            btnProductSample.Size = new Size(120, 90);
            btnProductSample.TabIndex = 0;
            btnProductSample.Text = "Món mẫu\n0 đ";
            btnProductSample.UseVisualStyleBackColor = true;
            btnProductSample.Visible = false;
            //
            // lblEmpty
            //
            lblEmpty.Dock = DockStyle.Fill;
            lblEmpty.ForeColor = Color.Gray;
            lblEmpty.Location = new Point(0, 0);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(700, 500);
            lblEmpty.TabIndex = 1;
            lblEmpty.Text = "Không có sản phẩm trong danh mục này";
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
            lblEmpty.Visible = false;
            //
            // ucProductGrid
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpProducts);
            Controls.Add(lblEmpty);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(320, 240);
            Name = "ucProductGrid";
            Size = new Size(700, 500);
            flpProducts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpProducts;
        private Button btnProductSample;
        private Label lblEmpty;
    }
}
