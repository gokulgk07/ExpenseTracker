using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ExpenseTrackerDS;

namespace ExpenseTrackerGUI
{
    public partial class BranchControl : UserControl
    {
        public BranchControl()
        {
            InitializeComponent();
        }
        
        public int Radius { get; set; } = 20;
        
        private Color backcolor = Color.White, forecolor= Color.Black, outlineColor= Color.White;
        private Category category = new Category();
        private int height = 40;
        private string imagePath = "";

        public string ImagePath
        {
            get => imagePath;
            set
            {
                imagePath = value;
                if (imagePath != null && imagePath!="")
                {
                    pbImage.Image = Image.FromFile(imagePath);
                }
            }
        }

        public string BranchText
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string BranchName
        {
            get => lblName.Name;
            set
            {
                this.Name = pbImage.Name = lblName.Name = value;
            }
        }

        public Color BranchBackColor
        {
            get => backcolor;
            set
            {
                backcolor = value;
                this.BackColor = backcolor;
            }
        }

        public Color BranchForeColor
        {
            get => forecolor;
            set
            {
                forecolor = value;
                lblName.ForeColor = forecolor;
            }
        }
        
        public override Font Font
        {
            get => lblName.Font;
            set => lblName.Font = value;
        }
        
        public int BranchHeight
        {
            get => height;
            set
            {
                height = value;
                this.Height = lblName.Height = height;
            }
        }

        public Category Category
        {
            get => category;
            set => category = value;
        }

        public Color OutLineColor
        {
            get => outlineColor;
            set
            {
                outlineColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();

            // Get the rectangle bounds
            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);

            // Create a rounded rectangle path
            path.AddArc(bounds.X, bounds.Y, Radius * 2, Radius * 2, 180, 90); // Top left arc
            path.AddArc(bounds.Right - (Radius * 2), bounds.Y, Radius * 2, Radius * 2, 270, 90); // Top right arc
            path.AddArc(bounds.Right - (Radius * 2), bounds.Bottom - (Radius * 2), Radius * 2, Radius * 2, 0, 90); // Bottom right arc
            path.AddArc(bounds.X, bounds.Bottom - (Radius * 2), Radius * 2, Radius * 2, 90, 90); // Bottom left arc

            // Close the path
            path.CloseFigure();

            // Apply the rounded rectangle path as the region of the panel
            Region = new Region(path);

            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Fill the rectangle with a solid color (you can customize this)
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            using (Pen pen = new Pen(OutLineColor, 3))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
        
        private void OnMouseEntered(object sender, EventArgs e)
        {
            this.BackColor = GUIStyles.secondaryColor;
            lblName.ForeColor = Color.White;

            this.Cursor = Cursors.Hand;

            Invalidate();
        }

        private void OnClickTrigged(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void OnMouseLeaved(object sender, EventArgs e)
        {
            this.BackColor = BranchBackColor;
            lblName.ForeColor = Color.Black;

            this.Cursor = Cursors.Arrow;
        }
    }
}
