using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI.Home
{
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();
            searchPicture.BackColor = Color.FromArgb(54, 55, 149);
            //this.BackColor= GUIStyles.terenaryColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics gh = e.Graphics;
            gh.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Brush fill = new SolidBrush(GUIStyles.primaryColor);

            Rectangle rect = new Rectangle(20, 0, Width - 50, Height);
            Rectangle cir1 = new Rectangle(0, 0, 48, Height);
            Rectangle cir2 = new Rectangle(Width - 50, 0, 48, Height);
            gh.FillRectangle(fill, rect);
            gh.FillEllipse(fill, cir1);
            gh.FillEllipse(fill, cir2);
        }

        private void searchPicture_MouseEnter(object sender, EventArgs e)
        {
            searchPicture.BackColor = Color.White;
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\search1.png");
            searchPicture.Image = hoverImage;
            searchPicture.Cursor = Cursors.Hand;
        }

        private void searchPicture_MouseLeave(object sender, EventArgs e)
        {
            searchPicture.BackColor = GUIStyles.primaryColor;
            Image leaveImage = Image.FromFile(@"D:\Santhiya\C#\Images\search2.png");
            searchPicture.Image = leaveImage;
        }
    }
}
