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

namespace ExpenseTrackerGUI
{
    public partial class ToggleButton : UserControl
    {
        public ToggleButton()
        {
            InitializeComponent();
        }

        public event EventHandler<bool> StatusChange;
        
        private bool changeStatus = true, editMode=true;
        private int width = 15, xPos = 10, yPos = 10;
        private Rectangle rect;

        public int Radius { get; set; } = 20;

        public bool EditMode
        {
            get => editMode;
            set => editMode = value;
        }

        public bool ChangeStatus
        {
            get => changeStatus;
            set
            {
                if (EditMode)
                {
                    changeStatus = value;
                    if (changeStatus)
                    {
                        xPos = Width - 10 - width;
                        BackColor = Color.Green;
                    }
                    else
                    {
                        xPos = 10;
                        BackColor = Color.Red;
                    }
                    StatusChange?.Invoke(this, changeStatus);
                    Invalidate();
                }
            }
        }

        private void OnClickTriggered(object sender, EventArgs e)
        {
            ChangeStatus = !ChangeStatus;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            width = Height - (20);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();

            // Get the rectangle bounds
            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
            path.StartFigure();

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

            using (Pen pen = new Pen(Color.White, 3))
            {
                e.Graphics.DrawPath(pen, path);
            }

            rect = new Rectangle(xPos, yPos, width, width);

            using (SolidBrush brush= new SolidBrush(Color.White))
            {
                e.Graphics.FillEllipse(brush, rect);
            }
        }


    }
}
