using ExpenseTracker;
using ExpenseTrackerDS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
    static class TransactionEditor
    {

        //Panel Paint Events        

        public static void PaintOperation(object sender, PaintEventArgs e, Color borderColor, Color backcolor, int width, int height,int borderWidth, int borderRadius)
        {
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath borderPath = CreateRoundedRectanglePath(new Rectangle(borderWidth / 2, borderWidth / 2, width - borderWidth, height - borderWidth), borderRadius);
                e.Graphics.DrawPath(borderPen, borderPath);
                e.Graphics.FillPath(new SolidBrush(backcolor), borderPath);
            }
        }

        public static GraphicsPath CreateRoundedRectanglePath(Rectangle rectangle, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectangle.Location, size);
              GraphicsPath path = new GraphicsPath();
            if (cornerRadius == 0)
            {
                path.AddRectangle(rectangle);
                return path;
            }
            path.AddArc(arc, 180, 90);// Top left arc            
            arc.X = rectangle.Right - diameter;// Top right arc
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;// Bottom right arc
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;// Bottom left arc
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

        //Button Paint Events

        public static void PaintButtonOperation(object sender, PaintEventArgs e, int width, int height)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, width - 1, height - 1);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath roundedRectangle = GetRoundedRectangle(rectangle, 10))
            using (Pen pen = new Pen(GUIStyles.primaryColor, 4))
            {
                graphics.DrawPath(pen, roundedRectangle);
            }
        }

        public static GraphicsPath GetRoundedRectangle(Rectangle rectangle, int radius)
        {
            GraphicsPath roundedRectangle = new GraphicsPath();
            roundedRectangle.AddArc(rectangle.X, rectangle.Y, radius * 2, radius * 2, 180, 90);
            roundedRectangle.AddArc(rectangle.Right - radius * 2, rectangle.Y, radius * 2, radius * 2, 270, 90);
            roundedRectangle.AddArc(rectangle.Right - radius * 2, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            roundedRectangle.AddArc(rectangle.X, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            roundedRectangle.CloseFigure();
            return roundedRectangle;
        }

        //Add Button DetailsList<String> viewday = new List<string>();

        public static List<String> viewday = new List<string>();
        public static List<String> viewweek = new List<string>();
        public static List<String> viewmonth = new List<string>();
        public static List<String> viewquarter = new List<string>();
        public static List<String> viewyear = new List<string>();
        public static List<String> viewcategory = new List<string>();
        public static List<String> viewoption = new List<string>();

        public static void AddDay()
        {
            if (viewday.Count == 0)
            {
                DateTime dt = DateTime.Now;
                for (int i = 0; i < 10; i++)
                {
                    String str = dt.ToString("dd") + "/" + dt.ToString("MM") + "/" + dt.ToString("yyyy");
                    if (i > 1)
                    {
                        viewday.Insert(0, str);
                    }
                    dt = dt.AddDays(-1);
                }
                viewday.Add("Yesterday");
                viewday.Add("Today");
                viewday.Add("Future");
            }
        }

        public static void AddWeek()
        {
            if (viewweek.Count == 0)
            {
                DateTime dt = DateTime.Now;
                for (int i = 0; i < 10; i++)
                {
                    int start = (int)dt.DayOfWeek;
                    int end = 6 - start;
                    DateTime startdate = dt.AddDays(-start);
                    String str = startdate.ToString("dd") + "/" + startdate.ToString("MM") + "/" + startdate.ToString("yyyy") + " - ";
                    DateTime endDate = dt.AddDays(+end);
                    str += endDate.ToString("dd") + "/" + endDate.ToString("MM") + "/" + endDate.ToString("yyyy");
                    if (i > 1)
                    {
                        viewweek.Insert(0, str);
                    }
                    dt = dt.AddDays(-7);
                }
                viewweek.Add("LastWeek");
                viewweek.Add("ThisWeek");
                viewweek.Add("Future");
            }
        }

        public static void AddMonth()
        {
            if (viewmonth.Count == 0)
            {
                DateTime dt = DateTime.Now;
                for (int i = 0; i < 10; i++)
                {
                    String str = dt.ToString("MM") + "/" + dt.ToString("yyyy");
                    if (i > 1)
                    {
                        viewmonth.Insert(0, str);
                    }
                    dt = dt.AddMonths(-1);
                }
                viewmonth.Add("LastMonth");
                viewmonth.Add("ThisMonth");
                viewmonth.Add("Future");
            }
        }

        public static void AddQuarter()
            {
            if (viewquarter.Count == 0)
            {
                DateTime dt = DateTime.Now;
                for (int i = 0; i < 10; i++)
                {
                    String str = "";
                    int month = int.Parse(dt.ToString("MM"));
                    if (month <= 3)
                    {
                        str = "Q1-" + dt.ToString("yyyy");
                    }
                    else if (month <= 6)
                    {
                        str = "Q2-" + dt.ToString("yyyy");
                    }
                    else if (month <= 9)
                    {
                        str = "Q3-" + dt.ToString("yyyy");
                    }
                    else
                    {
                        str = "Q4-" + dt.ToString("yyyy");
                    }
                    viewquarter.Insert(0, str);
                    dt = dt.AddMonths(-3);
                }
                viewquarter.Add("Future");
            }
        }

        public static void AddYear()
        {
            if (viewyear.Count == 0)
            {
                DateTime dt = DateTime.Now;
                for (int i = 0; i < 10; i++)
                {
                    String str = dt.ToString("yyyy");
                    if (i > 1)
                    {
                        viewyear.Insert(0, str);
                    }
                    dt = dt.AddYears(-1);
                }
                viewyear.Add("LastYear");
                viewyear.Add("ThisYear");
                viewyear.Add("Future");
            }
        }

        public static void AddViewOption()
        {
            viewoption.Add("View by Day");
            viewoption.Add("View by Week");
            viewoption.Add("View by Month");
            viewoption.Add("View by Quarter");
            viewoption.Add("View by Year");
            viewoption.Add("View All");
            viewoption.Add("Custom");
            viewcategory.Add("Individual Transaction");
            viewcategory.Add("View By Transaction");
            viewcategory.Add("View By Category");
        }

        //Call Show Functions

        public static DateTime FindDay(String str)
        {
            DateTime dt = DateTime.Now;
            if (str == "Today")
            {
                dt = DateTime.Now;
            }
            else if (str == "Yesterday")
            {
                dt = dt.AddDays(-1);
            }
            else
            {
                dt = DateTime.Parse(str);//.Substring(3, 2) + "/" + str.Substring(0, 2) + "/" + str.Substring(6, 4)
            }
            return dt;
        }

        public static DateTime FindWeek(String str)
        {
            DateTime dt = DateTime.Now;
            if (str == "ThisWeek")
            {
                dt = DateTime.Now;
            }
            else if (str == "LastWeek")
            {
                dt = dt.AddDays(-7);
            }
            else
            {
                dt = DateTime.Parse(str.Substring(0,10));//str.Substring(3, 2) + "/" + str.Substring(0, 2) + "/" + str.Substring(6, 4)
            }
            return dt;
        }

        public static DateTime FindMonth(String str)
        {
            DateTime dt = DateTime.Now;
            if (str == "ThisMonth")
            {
                dt = DateTime.Now;
            }
            else if (str == "LastMonth")
            {
                dt = dt.AddMonths(-1);
            }
            else
            {
                dt = DateTime.Parse("01/" + str);
            }
            return dt;
        }

        public static DateTime FindQuarter(String str)
        {
            DateTime dt = DateTime.Now;
            if (str.Substring(0, 2) == "Q1")
            {
                dt = DateTime.Parse("01/01/" + str.Substring(3, 4));
            }
            else if (str.Substring(0, 2) == "Q2")
            {
                dt = DateTime.Parse("01/04/" + str.Substring(3, 4));
            }
            else if (str.Substring(0, 2) == "Q3")
            {
                dt = DateTime.Parse("01/07/" + str.Substring(3, 4));
            }
            else if (str.Substring(0, 2) == "Q4")
            {
                dt = DateTime.Parse("01/10/" + str.Substring(3, 4));
            }
            else
            {
                dt = DateTime.Parse(str);
            }
            return dt;
        }

        public static DateTime FindYear(String str)
        {
            DateTime dt = DateTime.Now;
            if (str == "ThisYear")
            {
                dt = DateTime.Now;
            }
            else if (str == "LastYear")
            {
                dt = dt.AddYears(-1);
            }
            else
            {
                dt = DateTime.Parse("01/01/" + str);
            }
            return dt;
        }

        //Create Transaction

        public static bool CreateTransaction(Transaction transac)
        {
            bool result = Communicator.Manager.AddData(transac);
            return result;
        }

        public static bool DeleteTransaction(Transaction transac)
        {
            bool result = Communicator.Manager.RemoveData(transac);
            return result;
        }

        public static bool EditTransaction(Transaction transac)
        {
            bool result = Communicator.Manager.EditData(transac);
            return result;
        }
    }
}
