using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTrackerDS;
using ExpenseTracker;
using System.IO;

namespace ExpenseTrackerGUI.Account
{
    public partial class ExportToCSV : UserControl
    {
        public ExportToCSV()
        {
            InitializeComponent();
            titleLbl.ForeColor = GUIStyles.primaryColor;
            showCategory.Hide();
            space2.Size = new Size(726, 10);
            timeSelectPanel.Hide();
            timePanel.Height = 79;
            startDateSelect.Hide();
            endDateSelect.Hide();
            panel2.Hide();
            delimiters.Hide();
            exportBtn.BackColor = GUIStyles.primaryColor;
            exportBtn.ForeColor = GUIStyles.whiteColor;
            exportBtn.FlatAppearance.MouseOverBackColor = GUIStyles.terenaryColor;
            allCategoryLbl.ForeColor = GUIStyles.primaryColor;
            allIncomeLbl.ForeColor = GUIStyles.primaryColor;
            allExpenseLbl.ForeColor = GUIStyles.primaryColor;
            border1.BackColor = GUIStyles.primaryColor;
            showCategory.BackColor = GUIStyles.backColor;
            border1.Hide();

            startDateSelect.BackColor = GUIStyles.primaryColor;
            endDateSelect.BackColor = GUIStyles.primaryColor;
            startDateSelect.Location = border2.Location;
            endDateSelect.Location = border3.Location;

            border2.BackColor = GUIStyles.primaryColor;
            timeSelectPanel.BackColor = GUIStyles.backColor;
            border2.Hide();

            border3.BackColor = GUIStyles.primaryColor;
            delimiters.BackColor = GUIStyles.backColor;
            border3.Hide();

            cancelBtn.BackColor = GUIStyles.primaryColor;
            cancelBtn.ForeColor = GUIStyles.whiteColor;
            cancelBtn.FlatAppearance.MouseOverBackColor = GUIStyles.terenaryColor;

            selectBtn.BackColor = GUIStyles.primaryColor;
            selectBtn.ForeColor = GUIStyles.whiteColor;
            selectBtn.FlatAppearance.MouseOverBackColor = GUIStyles.terenaryColor;
        }

        static int categoryCnt = 0, timeCnt = 0, delimiterCnt = 0;

        private void walletSelectPanel_Click(object sender, EventArgs e)
        {
            border1.Hide();
            border2.Hide();
            border3.Hide();
        }

        private void categoryPicture_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            border2.Hide();
            border3.Hide();
            timeSelectPanel.Hide();
            timePanel.Height = 79;
            timeCnt = 0;
            categoryCnt++;
            if (categoryCnt % 2 != 0)
            {
                space2.Size = new Size(726, 126);
                border1.Show();
                border1.BringToFront();
                showCategory.Show();
                showCategory.BringToFront();
            }
            else
            {
                border1.Hide();
                showCategory.Hide();
                space2.Size = new Size(726, 10);
            }            
        }

        private void timePanel_Click(object sender, EventArgs e)
        {
            border1.Hide();
            border3.Hide();
            startDateSelect.Hide();
            endDateSelect.Hide();
            panel2.Hide();
            showCategory.Hide();
            space2.Size = new Size(726, 10);
            categoryCnt = 0;
            timeCnt++;
            if (timeCnt % 2 != 0)
            {
                timePanel.Height = 280;
                border2.Show();
                timeSelectPanel.Show();
            }
            else
            {
                timeSelectPanel.Hide();
                border2.Hide();
                timePanel.Height = 79;
            }            
        }

        private void delimiterPanel_Click(object sender, EventArgs e)
        {
            border1.Hide();
            border2.Hide();
            timeSelectPanel.Hide();
            showCategory.Hide();
            timePanel.Height = 79;
            timeCnt = 0;
            categoryCnt = 0;
            delimiterCnt++;
            if (delimiterCnt % 2 != 0)
            {
                delimiters.Show();
                border3.Show();
            }
            else
            {
                border3.Hide();
                delimiters.Hide();
            }
        }

        public event EventHandler CloseBtnClick;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            border1.Hide();
            border2.Hide();
            CloseBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void allCategoryLbl_Click(object sender, EventArgs e)
        {
            selectCategoryLbl.Text = allCategoryLbl.Text;
            space2.Size = new Size(726, 10);
            categoryCnt = 0;
            border1.Hide();
        }

        private void allIncomeLbl_Click(object sender, EventArgs e)
        {
            selectCategoryLbl.Text = allIncomeLbl.Text;
            space2.Size = new Size(726, 10);
            categoryCnt = 0;
            border1.Hide();
        }

        private void allExpenseLbl_Click(object sender, EventArgs e)
        {
            selectCategoryLbl.Text = allExpenseLbl.Text;
            space2.Size = new Size(726, 10);
            categoryCnt = 0;
            border1.Hide();
        }

        private void ExportToCSV_Resize(object sender, EventArgs e)
        {
            exportBtn.Location = new Point(Width - exportBtn.Width - 50, exportBtn.Location.Y);
        }

        private void ExportToCSV_Load(object sender, EventArgs e)
        {
            titleLbl.ForeColor = GUIStyles.primaryColor;
            showCategory.Hide();
            selectCategoryLbl.Text = allCategoryLbl.Text;
            space2.Size = new Size(726, 10);
            categoryCnt = 0;
        }

        private void allPanel_Click(object sender, EventArgs e)
        {
            endFlag = false;
            startFlag = false;
            label2.Hide();
            selectedTime.Text = allLbl.Text;
            timeSelectPanel.Hide();
            timePanel.Height = 79;
            timeCnt = 0;
            border2.Hide();
        }

        private void afterLbl_Click(object sender, EventArgs e)
        {
            endFlag = false;
            startFlag = false;
            selectedTime.Text = afterLbl.Text;
            timeSelectPanel.Hide();
            panel2.Hide();
            endDateSelect.Hide();
            timeCnt = 0;
            startDateSelect.Show();
            startDateSelect.Location = new Point(261, 60);
            label2.Text = startDate;
            border2.Hide();
        }

        private void beforeLbl_Click(object sender, EventArgs e)
        {
            endFlag = false;
            startFlag = false;
            selectedTime.Text = beforeLbl.Text;
            timeSelectPanel.Hide();
            panel2.Hide();
            startDateSelect.Hide();
            timeCnt = 0;
            endDateSelect.Show();
            endDateSelect.Location = new Point(261, 60);
            label2.Text = endDate;
            border2.Hide();
        }

        private void betweenLbl_Click(object sender, EventArgs e)
        {
            panel2.BackColor = GUIStyles.primaryColor;
            betweenTime.BackColor = GUIStyles.backColor;
            betweenTime.BringToFront();
            endDateSelect.Hide();
            startDateSelect.Hide();
            selectedTime.Text = betweenLbl.Text;
            timeSelectPanel.Hide();
            panel2.Location = new Point(350, 40);
            panel2.Show();
            timeCnt = 0;
            border2.Hide();
        }

        string startDate = "", endDate = "";

        bool startFlag = false,endFlag=false;

        private void startDateSelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            startDate = startDateSelect.SelectionRange.Start.ToString("yyyy-MM-dd");
            startDateSelect.Hide();

            if (startFlag)
            {
                date1Lbl.Text = startDate;
                panel2.Show();
                startFlag = false;
            }

            else
            {
                timePanel.Height = 79;
                label2.Text =  Convert.ToDateTime(startDate).ToString("dd/MM/yyyy");
            }
        }

        private void date2_Click(object sender, EventArgs e)
        {
            endDateSelect.Location = panel2.Location;
            panel2.Hide();
            endDateSelect.Show();
            endFlag = true;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            startDate = date1Lbl.Text;
            endDate = date2.Text;

            if (startDate == "Yesterday")
            {
                startDate = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            }
            if (endDate == "Today")
            {
                endDate = DateTime.Now.ToString("yyyy-MM-dd");
            }

            label2.Text = startDate + " - " + endDate;
            timePanel.Height = 79;
            panel2.Hide();
            
        }        

        private void exportBtn_Click_1(object sender, EventArgs e)
        {
            List<Transaction> result = new List<Transaction>();

            if (selectCategoryLbl.Text == allCategoryLbl.Text)
            {
                if (selectedTime.Text == allLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "All", "All");
                }

                else if (selectedTime.Text == afterLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, startDate, "After", "All");
                }

                else if (selectedTime.Text == beforeLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(endDate, endDate, "Before", "All");
                }

                else if (selectedTime.Text == betweenLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "Between", "All");
                }

                else if (selectedTime.Text == beforeLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "Exact", "All");
                }
            }

            else if(selectCategoryLbl.Text == allIncomeLbl.Text)
            {
                if (selectedTime.Text == allLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "All", "Income");
                }

                else if (selectedTime.Text == afterLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, startDate, "After", "Income");
                }

                else if (selectedTime.Text == beforeLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(endDate, endDate, "Before", "Income");
                }

                else if (selectedTime.Text == betweenLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "Between", "Income");
                }

                else if (selectedTime.Text == beforeLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "Exact", "Income");
                }
            }

            else if (selectCategoryLbl.Text == allExpenseLbl.Text)
            {
                if (selectedTime.Text == allLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "All", "Expense");
                }

                else if (selectedTime.Text == afterLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, startDate, "After", "Expense");
                }

                else if (selectedTime.Text == beforeLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(endDate, endDate, "Before", "Expense");
                }

                else if (selectedTime.Text == betweenLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "Between", "Expense");
                }

                else if (selectedTime.Text == beforeLbl.Text)
                {
                    result = Communicator.Manager.FetchTransactionToExport(startDate, endDate, "Exact", "Expense");
                }
            }

            ToCSV(result);
        }

        String separator = ",";

        private void semicolonLbl_Click(object sender, EventArgs e)
        {
            separator = ";";
            delimiters.Hide();
            border3.Hide();
            selectedDelimiiter.Text = semicolonLbl.Text;
        }

        private void commaLbl_Click(object sender, EventArgs e)
        {
            separator = ",";
            delimiters.Hide();
            border3.Hide();
            selectedDelimiiter.Text = commaLbl.Text;
        }

        private void tabLbl_Click(object sender, EventArgs e)
        {
            separator = "\t";
            delimiters.Hide();
            border3.Hide();
            selectedDelimiiter.Text = tabLbl.Text;
        }

        private void ToExcel(List<Transaction> result1)
        {
            //using (ExcelEngine excelEngine = new ExcelEngine())
            //{
            //    IApplication application = excelEngine.Excel;
            //    application.DefaultVersion = ExcelVersion.Excel2016;

            //    //Read the data from XML file
            //    StreamReader reader = new StreamReader(Path.GetFullPath(@"../../Data/Customers.xml"));

            //    //Assign the data to the customerObjects collection
            //    IEnumerable customerObjects = GetData(reader.ReadToEnd());

            //    //Create a new workbook
            //    IWorkbook workbook = application.Workbooks.Create(1);
            //    IWorksheet sheet = workbook.Worksheets[0];

            //    //Import data from customerObjects collection
            //    sheet.ImportData(customerObjects, 5, 1, false);

            //    #region Define Styles
            //    IStyle pageHeader = workbook.Styles.Add("PageHeaderStyle");
            //    IStyle tableHeader = workbook.Styles.Add("TableHeaderStyle");

            //    pageHeader.Font.RGBColor = Color.FromArgb(0, 83, 141, 213);
            //    pageHeader.Font.FontName = "Calibri";
            //    pageHeader.Font.Size = 18;
            //    pageHeader.Font.Bold = true;
            //    pageHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            //    pageHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;

            //    tableHeader.Font.Color = ExcelKnownColors.White;
            //    tableHeader.Font.Bold = true;
            //    tableHeader.Font.Size = 11;
            //    tableHeader.Font.FontName = "Calibri";
            //    tableHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            //    tableHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;
            //    tableHeader.Color = Color.FromArgb(0, 118, 147, 60);
            //    tableHeader.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            //    tableHeader.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            //    tableHeader.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            //    tableHeader.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            //    #endregion

            //    #region Apply Styles
            //    //Apply style to the header
            //    sheet["A1"].Text = "Yearly Sales Report";
            //    sheet["A1"].CellStyle = pageHeader;

            //    sheet["A2"].Text = "Namewise Sales Comparison Report";
            //    sheet["A2"].CellStyle = pageHeader;
            //    sheet["A2"].CellStyle.Font.Bold = false;
            //    sheet["A2"].CellStyle.Font.Size = 16;

            //    sheet["A1:D1"].Merge();
            //    sheet["A2:D2"].Merge();
            //    sheet["A3:A4"].Merge();
            //    sheet["D3:D4"].Merge();
            //    sheet["B3:C3"].Merge();

            //    sheet["B3"].Text = "Sales";
            //    sheet["A3"].Text = "Sales Person";
            //    sheet["B4"].Text = "January - June";
            //    sheet["C4"].Text = "July - December";
            //    sheet["D3"].Text = "Change(%)";
            //    sheet["A3:D4"].CellStyle = tableHeader;
            //    #endregion

            //    sheet.UsedRange.AutofitColumns();

            //    //Save the file in the given path
            //    Stream excelStream = File.Create(Path.GetFullPath(@"Output.xlsx"));
            //    workbook.SaveAs(excelStream);
            //    excelStream.Dispose();
            //}
        }

        private void ToCSV(List<Transaction> result1)
        {
            StringBuilder output = new StringBuilder();

            String[] headings = { "Transaction Id", "Category Name", "Amount", "Date","Description"};
            output.AppendLine(string.Join(separator, headings));

            foreach (Transaction t in result1)
            {
                String[] newLine = { t.TransactionId.ToString(), t.CategoryName, t.Amount.ToString(), t.Date.ToString(),t.Description };
                output.AppendLine(string.Join(separator, newLine));
            }

            try
            {
                String file="";
                saveFileDialog1.ShowDialog();
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = saveFileDialog1.FileName;
                }
                File.AppendAllText(file, output.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data could not be written to the CSV file.");
                return;
            }
        }

        private void endDateSelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            endDate = endDateSelect.SelectionRange.Start.ToString("yyyy-MM-dd");
            endDateSelect.Hide();
            if (endFlag)
            {
                date2.Text = endDate;
                panel2.Show();
                
                endFlag = false;
            }

            else
            {
                timePanel.Height = 79;
                label2.Text = Convert.ToDateTime(endDate).ToString("dd/MM/yyyy");
            }
        }        

        private void border1_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(allExpensePanel, allExpenseLbl);
            MouseLeaveEvent(allIncomePanel, allIncomeLbl);
            MouseLeaveEvent(allCategoryPanel, allCategoryLbl);
        }

        private void allLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(allPanel, allLbl);
        }

        private void afterLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(afterPanel, afterLbl);
        }

        private void beforeLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(beforePanel, beforeLbl);
        }

        private void betweenLbl_Enter(object sender, EventArgs e)
        {
            MouseEnterEvent(betweenPanel, betweenLbl);
        }

        private void exactLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(exactPanel, exactLbl);
        }

        private void allLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(allPanel, allLbl);
        }

        private void afterLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(afterPanel, afterLbl);
        }

        private void beforeLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(beforePanel, beforeLbl);
        }

        private void betweenLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(betweenPanel, betweenLbl);
        }

        private void exactLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(exactPanel, exactLbl);
        }

        private void border2_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(allPanel, allLbl);
            MouseLeaveEvent(afterPanel, afterLbl);
            MouseLeaveEvent(beforePanel, beforeLbl);
            MouseLeaveEvent(betweenPanel, betweenLbl);
            MouseLeaveEvent(exactPanel, exactLbl);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            border2.Show();
            timeSelectPanel.Show();
        }

        private void allCategoryLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(allCategoryPanel, allCategoryLbl);
        }

        private void allIncomeLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(allIncomePanel, allIncomeLbl);
        }

        private void allExpenseLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(allExpensePanel, allExpenseLbl);
        }

        private void allCategoryLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(allCategoryPanel, allCategoryLbl);
        }

        private void allIncomeLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(allIncomePanel, allIncomeLbl);
        }

        private void allExpenseLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(allExpensePanel, allExpenseLbl);
        }

        private void betweenLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(betweenPanel, betweenLbl);
        }

        private void semicolonLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(semicolonPanel, semicolonLbl);
        }

        private void commaLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(commaPanel, commaLbl);
        }

        private void tabLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent(tabPanel, tabLbl);
        }

        private void semicolonLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(semicolonPanel, semicolonLbl);
        }

        private void commaLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(commaPanel, commaLbl);
        }

        private void tabLbl_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(tabPanel, tabLbl);
        }

        private void date1Lbl_Click(object sender, EventArgs e)
        {
            startDateSelect.Location=panel2.Location;
            panel2.Hide();
            startDateSelect.Show();
            startFlag = true;
        }

        private void exactLbl_Click(object sender, EventArgs e)
        {
            endFlag = false;
            startFlag = false;
            selectedTime.Text = exactLbl.Text;
            startDateSelect.Show();
            startDateSelect.Location = new Point(261, 60);
            timeSelectPanel.Hide();
            timePanel.Height = 79;
            timeCnt = 0;
            label2.Text = startDate;
            border2.Hide();
        }

        private void MouseEnterEvent(Panel panel,Label label)
        {
            panel.BackColor = GUIStyles.primaryColor;
            label.BackColor = GUIStyles.primaryColor;
            label.ForeColor = GUIStyles.whiteColor;
        }

        private void MouseLeaveEvent(Panel panel,Label label)
        {
            panel.BackColor = GUIStyles.backColor;
            label.BackColor = GUIStyles.backColor;
            label.ForeColor = GUIStyles.primaryColor;
        }
    }
}
