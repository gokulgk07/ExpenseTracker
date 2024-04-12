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
using System.Net.Http;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Xml;
using Newtonsoft.Json.Linq;
using ExpenseTracker;

namespace ExpenseTrackerGUI
{
    public partial class CurrencyConverter : UserControl
    { 
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        //Event

        public event EventHandler CurrencyConverterClosed;

        //Update Data

        private async void AddCountryAsync()
        {
            for(int i = 0; i < lidata.Count; i++)
            {
                process = true;
                if (lidata.Count > i)
                {
                    await ConvertCurrency(lidata[i].Pcountry.Currency, "INR");
                    if (status == false)
                    {
                        break;
                    }
                    await ConvertCurrencyReverse("INR", lidata[i].Pcountry.Currency);
                    if (status == false)
                    {
                        break;
                    }
                    licountry[i].AmountOthertoIndia = float.Parse(amt1);
                    licountry[i].AmountIndiatoOther = float.Parse(amt2);
                }
                else
                {
                    break;
                }
            }
            process = false;
            UpdateData();
        }

        static async Task ConvertCurrency(string basecurrency,string convertcurrency)
        {
            try
            {
                string apiKey = "YOUR_API_KEY"; 
                string baseCurrency = basecurrency;
                string targetCurrency = convertcurrency; 
                double amountToConvert = 1.0;
                string url = $"https://open.er-api.com/v6/latest/{baseCurrency}?apikey={apiKey}";
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseData);
                        double exchangeRate = jsonResponse["rates"][targetCurrency].Value<double>();
                        double convertedAmount = amountToConvert * exchangeRate;
                        amt1 = convertedAmount.ToString();
                        status = true;
                        Console.WriteLine($"{amountToConvert} {baseCurrency} = {convertedAmount} {targetCurrency}");
                    }
                    else
                    {
                        status = false;
                        //  Console.WriteLine($"Failed to retrieve data. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException e)
            {
                status = false;
                //Console.WriteLine($"Error occurred: {e.Message}");
            }
        }

        static async Task ConvertCurrencyReverse(string basecurrency, string convertcurrency)
        {
            try
            {
                string apiKey = "YOUR_API_KEY";
                string baseCurrency = basecurrency; 
                string targetCurrency = convertcurrency; 
                double amountToConvert = 1.0;
                string url = $"https://open.er-api.com/v6/latest/{baseCurrency}?apikey={apiKey}";
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseData);
                        double exchangeRate = jsonResponse["rates"][targetCurrency].Value<double>();
                        double convertedAmount = amountToConvert * exchangeRate;
                        amt2 = convertedAmount.ToString();
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                status = false;
            }
        }

        //Paint Operation

        private void OnPBottomPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, GUIStyles.primaryColor, Color.GhostWhite, pbottom.Width, pbottom.Height, 10, 10);
        }

        private void OnPCurrencyPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, Color.Black, Color.White, pcb1.Width, pcb2.Height, 3, 5);
        }

        private void OnpdataPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, Color.MidnightBlue, Color.White, pdata.Width, pdata.Height, 6, 5);
        }

        //Variable Initialization

        int locy = 0, locx = 5, type = 0;
        Country cdata1, cdata2;
        static string amt1 = "1.0", amt2 = "1.0";
        static bool status, process = false;
        List<Country> licountry = new List<Country>();
        List<CountryData> lidata = new List<CountryData>();

        //Load Operation

        private void OnCurrencyConverterLoad(object sender, EventArgs e)
        {
            ActiveControl = Calculatebt;
            pchoose.Size = new Size(263, 221);
            licountry=Communicator.Manager.FetchCurrency();
            if (licountry.Count > 0)
            {
                AddData();
                AddCountryAsync();
            }
        }

        private void AddData()
        {
            for (int i = 0; i < licountry.Count; i++)
            {
                CountryData cd = new CountryData
                {
                    Pcountry = licountry[i],
                    Location = new Point(locx, locy)
                };
                cd.CountrySelected += OnCountryDataSelected;
                locy += cd.Height;
                pmain.Controls.Add(cd);
                lidata.Add(cd);
                if (licountry[i].Name == "India")
                {
                    cdata2 = licountry[i];
                }
                if (licountry[i].Name == "United States")
                {
                    cdata1 = licountry[i];
                }
            }
            EditData();
        }

        private void OnCountryDataSelected(object sender, Country e)
        {
            if (type == 0)
            {
                cdata1 = e;
            }
            else if (type == 1)
            {
                cdata2 = e;
            }
            EditData();
            pchoose.Visible = false;
            pc1.Enabled = pc2.Enabled = Closepb.Enabled = Calculatebt.Enabled = pdata.Enabled = true;
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            pchoose.Visible = false;
            pc1.Enabled = pc2.Enabled = Closepb.Enabled = Calculatebt.Enabled = pdata.Enabled = true;
        }

        private void OnSelectCountry1Click(object sender, EventArgs e)
        {
            type = 0;
            pchoose.Location = new Point(pcb1.Location.X, pcb1.Location.Y + pcb1.Height + 1);
            SelectCountry();
        }

        private void OnSelectCountry2Click(object sender, EventArgs e)
        {
            type = 1;
            pchoose.Location = new Point(pcb2.Location.X, pcb2.Location.Y + pcb2.Height + 1);
            SelectCountry();
        }

        private void SelectCountry()
        {
            pc1.Enabled = pc2.Enabled = Closepb.Enabled = Calculatebt.Enabled = pdata.Enabled = false;
            pchoose.Visible = true;
        }

        private void OnCalculateBtClick(object sender, EventArgs e)
        {
            CheckInputCurrency();
            if (cdata1 != null && cdata2 != null)
            {
                currencylb.Text = ((float.Parse(currencytb.Text)) * cdata1.AmountOthertoIndia * cdata2.AmountIndiatoOther).ToString("F4");
            }
        }

        private void OnClosePbClick(object sender, EventArgs e)
        {
            for(int i = 0; i < lidata.Count; i++)
            {
                lidata[i].Dispose();
            }
            lidata.Clear();
            licountry.Clear();
            CurrencyConverterClosed?.Invoke(sender, e);
        }

        private void OnRefreshlbClick(object sender, EventArgs e)
        {
            if (process == false)
            {
                AddCountryAsync();
            }
        }

        private void UpdateData()
        {
            licountry = Communicator.Manager.FetchCurrency();
            for(int i = 0; i < lidata.Count; i++)
            {
                lidata[i].Pcountry = licountry[i];
                if (licountry[i].Name == cdata1.Name)
                {
                    cdata1 = licountry[i];
                }
                if (licountry[i].Name == cdata2.Name)
                {
                    cdata2 = licountry[i];
                }
            }
            EditData();
        }

        private void OnCurrencyInputKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)8 || e.KeyChar == (char)46)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)13)
            {
                OnCalculateBtClick(sender, EventArgs.Empty);
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CheckInputCurrency()
        {
            if (currencytb.TextLength == 0)
            {
                currencytb.Text = "1";
                currencytb.SelectionStart = currencytb.TextLength;
            }
        }

        private void EditData()
        {
            flagpb1.BackgroundImage = new Bitmap(@".\\Images\\" + cdata1.Flag );
            symb1.Text = cdata1.Symbol; symbollb1.Text = cdata1.Currency;
            flagpb2.BackgroundImage = new Bitmap(@".\\Images\\" + cdata2.Flag );
            symb2.Text = cdata2.Symbol; symbollb2.Text = cdata2.Currency;
            CheckInputCurrency();
            currencylb.Text = ((float.Parse(currencytb.Text)) * cdata1.AmountOthertoIndia * cdata2.AmountIndiatoOther).ToString("F4");
            amountlb.Text = (cdata1.AmountOthertoIndia * cdata2.AmountIndiatoOther).ToString("F2");
            updatedtimelb.Text = cdata1.Updated_Time.ToString();
        }
    }
}
