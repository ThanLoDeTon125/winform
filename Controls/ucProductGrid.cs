using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace winform_cuoi_ki
{
    public partial class ucProductGrid : UserControl
    {
        public event EventHandler<object>? ProductSelected;

        public ucProductGrid()
        {
            InitializeComponent();
        }

        /// <summary>Bind danh sách món (DTO/object từ BLL). Tag trên nút = item.</summary>
        public void BindProducts(IEnumerable<object>? products)
        {
            flpProducts.Controls.Clear();
            lblEmpty.Visible = false;
            btnProductSample.Visible = false;

            if (products == null)
            {
                lblEmpty.Visible = true;
                lblEmpty.BringToFront();
                return;
            }

            var any = false;
            foreach (var p in products)
            {
                any = true;
                var btn = new Button
                {
                    Size = new Size(120, 90),
                    Margin = new Padding(6),
                    Text = p?.ToString() ?? "Món",
                    Tag = p,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 11F)
                };
                btn.Click += (s, e) =>
                {
                    if (s is Button b)
                        ProductSelected?.Invoke(this, b.Tag!);
                };
                flpProducts.Controls.Add(btn);
            }

            if (!any)
            {
                lblEmpty.Visible = true;
                lblEmpty.BringToFront();
            }
        }

        public void ClearProducts()
        {
            flpProducts.Controls.Clear();
            lblEmpty.Visible = false;
        }
    }
}
