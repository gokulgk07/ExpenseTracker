using DatabaseLibrary;
using ExpenseTrackerDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Manager 
    {
        DatabaseManager manager;

        #region Constructor creation

        public Manager()
        {
            SwitchDatabase("expense_tracker_application");
            CreateUserDetailsTable();
            //AddUser("Sanjula", "sanjula@gmail.com", "sanjula");
            //AddUser("Santhiya", "santhiya@gmail.com", "santhiya");
            string r = "";
            //IsUserExits("santhiyadevi1302@gmail.com", "Santhiya", out r);
            // GetUserName("santhiyadevi1302@gmail.com");
            //SwitchDatabase(databaseName);
        }

        public void SwitchDatabase(string dbName)
        {
            manager = new MySqlHandler("localhost", "root", "", "");
            manager.Database = dbName;
            manager.CheckAndCreateDatabase();
            Dbconnection();
        }

        public string mailId = "";
        public string username = "";
        public string password = "";
        public string databaseName = "";

        #endregion
                
        #region CreateTable

        private void CreateUserDetailsTable()
        {
            SwitchDatabase("expense_tracker_application");
            ColumnDetails[] columns = new ColumnDetails[]
            {
                new ColumnDetails("user_id",BaseDatatypes.INT ,indexType:IndexType.PrimaryKey,isAutoIncrement:true),
                new ColumnDetails("userName", BaseDatatypes.VARCHAR , 30),
                new ColumnDetails("email", BaseDatatypes.VARCHAR , 50),
                new ColumnDetails("password", BaseDatatypes.VARCHAR , 30),
                new ColumnDetails("expenseTable", BaseDatatypes.VARCHAR , 30)
            };

            Dbconnection();

            if (!manager.TableExists("UserLoginDetails"))
            {
                manager.CreateTable("UserLoginDetails", columns);
            }

            bool exists = manager.TableExists("UserLoginDetails");
        }

        private void CreateBudgetTable()
        {
            SwitchDatabase(databaseName);
            ColumnDetails[] columns = new ColumnDetails[]
            {
                new ColumnDetails("Budget_id",BaseDatatypes.INT ,indexType:IndexType.PrimaryKey,isAutoIncrement:true),
                new ColumnDetails("Category_id", BaseDatatypes.INT),
                new ColumnDetails("Amount", BaseDatatypes.FLOAT),
                new ColumnDetails("Choice", BaseDatatypes.VARCHAR , 30),
                new ColumnDetails("Start_date", BaseDatatypes.DATE),
                new ColumnDetails("End_date" , BaseDatatypes.DATE),
                new ColumnDetails("Wallet_id" , BaseDatatypes.INT)
            };

            Dbconnection();

            if (!manager.TableExists("Budget"))
            {
                manager.CreateTable("Budget", columns);
            }

            bool exists = manager.TableExists("Budget");
        }

        private void CreateCategoryTable()
        {
            SwitchDatabase(databaseName);
            ColumnDetails[] columns = new ColumnDetails[]
            {
                new ColumnDetails("Category_id",BaseDatatypes.INT ,indexType:IndexType.PrimaryKey,isAutoIncrement:true),
                new ColumnDetails("Category_Name",BaseDatatypes.VARCHAR,30),
                new ColumnDetails("Parent_Id",BaseDatatypes.INT),
                new ColumnDetails("Type",BaseDatatypes.BOOLEAN),
                new ColumnDetails("Wallet_id",BaseDatatypes.VARCHAR,10),
                new ColumnDetails("Category_Image",BaseDatatypes.VARCHAR,50)
            };

            Dbconnection();

            if (!manager.TableExists("Category"))
            {
                List<int> WalletId = new List<int>() { 1 };
                string wallets = "";
                foreach (int id in WalletId) wallets += id + ",";
                if (wallets.Length > 1)
                    wallets = wallets.Remove(wallets.Length - 1);

                manager.CreateTable("Category", columns);
                manager.InsertData("category", 0, "Bills & Utilities", 0, false, wallets, ".\\ResourceImages\\Bills & Utilities.png");
                manager.InsertData("category", 0, "Electricity Bill", 1, false, wallets, ".\\ResourceImages\\Electricity Bill.png");
                manager.InsertData("category", 0, "Gas Bill", 1, false, wallets, ".\\ResourceImages\\Gas Bill.png");
                manager.InsertData("category", 0, "Internet Bill", 1, false, wallets, ".\\ResourceImages\\Internet Bill.png");
                manager.InsertData("category", 0, "Other Utility Bills", 1, false, wallets, ".\\ResourceImages\\Other Utility Bills.png");
                manager.InsertData("category", 0, "Phone Bill", 1, false, wallets, ".\\ResourceImages\\Phone Bill.png");
                manager.InsertData("category", 0, "Rentals", 1, false, wallets, ".\\ResourceImages\\Rentals.png");
                manager.InsertData("category", 0, "Television Bill", 1, false, wallets, ".\\ResourceImages\\Television Bill.png");
                manager.InsertData("category", 0, "Water Bill", 1, false, wallets, ".\\ResourceImages\\Water Bill.png");

                manager.InsertData("category", 0, "Education", 0, false, wallets, ".\\ResourceImages\\Education.png");

                manager.InsertData("category", 0, "Entertainment", 0, false, wallets, ".\\ResourceImages\\Entertainment.png");
                manager.InsertData("category", 0, "Fun Money", 11, false, wallets, ".\\ResourceImages\\Fun Money.png");
                manager.InsertData("category", 0, "Streaming Service", 11, false, wallets, ".\\ResourceImages\\Streaming Service.png");

                manager.InsertData("category", 0, "Family", 0, false, wallets, ".\\ResourceImages\\Family.png");
                manager.InsertData("category", 0, "Home Maintenance", 14, false, wallets, ".\\ResourceImages\\Home Maintenance.png");
                manager.InsertData("category", 0, "Home Services", 14, false, wallets, ".\\ResourceImages\\Home Services.png");
                manager.InsertData("category", 0, "Pets", 14, false, wallets, ".\\ResourceImages\\Pets.png");

                manager.InsertData("category", 0, "Food & Beverage", 0, false, wallets, ".\\ResourceImages\\Food & Beverage.png");

                manager.InsertData("category", 0, "Gift & Donations", 0, false, wallets, ".\\ResourceImages\\Gift & Donations.png");

                manager.InsertData("category", 0, "Health & Fitness", 0, false, wallets, ".\\ResourceImages\\Health & Fitness.png");
                manager.InsertData("category", 0, "Fitness", 20, false, wallets, ".\\ResourceImages\\Fitness.png");
                manager.InsertData("category", 0, "Medical Check-up", 20, false, wallets, ".\\ResourceImages\\Medical Check-up.png");

                manager.InsertData("category", 0, "Insurances", 0, false, wallets, ".\\ResourceImages\\Insurances.png");
                manager.InsertData("category", 0, "Investment", 0, false, wallets, ".\\ResourceImages\\Investment.png");
                manager.InsertData("category", 0, "Other Expense", 0, false, wallets, ".\\ResourceImages\\Other Expense.png");
                manager.InsertData("category", 0, "Outgoing transfer", 0, false, wallets, ".\\ResourceImages\\Outgoing transfer.png");
                manager.InsertData("category", 0, "Pay Interest", 0, false, wallets, ".\\ResourceImages\\Pay Interest.png");

                manager.InsertData("category", 0, "Shopping", 0, false, wallets, ".\\ResourceImages\\Shopping.png");
                manager.InsertData("category", 0, "Houseware", 28, false, wallets, ".\\ResourceImages\\Houseware.png");
                manager.InsertData("category", 0, "Makeup", 28, false, wallets, ".\\ResourceImages\\Makeup.png");
                manager.InsertData("category", 0, "Personal Items", 28, false, wallets, ".\\ResourceImages\\Personal Items.png");

                manager.InsertData("category", 0, "Transportation", 0, false, wallets, ".\\ResourceImages\\Transportation.png");
                manager.InsertData("category", 0, "Vehicle Maintenance", 32, false, wallets, ".\\ResourceImages\\Vehicle Maintenance.png");

                manager.InsertData("category", 0, "Collect Interest", 0, true, wallets, ".\\ResourceImages\\Collect Interest.png");
                manager.InsertData("category", 0, "Incoming transfer", 0, true, wallets, ".\\ResourceImages\\Incoming transfer.png");
                manager.InsertData("category", 0, "Other Income", 0, true, wallets, ".\\ResourceImages\\Other Income.png");
                manager.InsertData("category", 0, "Salary", 0, true, wallets, ".\\ResourceImages\\Salary.png");
            }

            bool exists = manager.TableExists("Category");
        }

        private void CreateTransactionTable(string tableName)
        {
            SwitchDatabase(databaseName);
            ColumnDetails[] columns = new ColumnDetails[]
            {
                new ColumnDetails("Transaction_id",BaseDatatypes.INT ,indexType:IndexType.PrimaryKey,isAutoIncrement:true),
                new ColumnDetails("Category_id",BaseDatatypes.INT),
                new ColumnDetails("Category_Name",BaseDatatypes.VARCHAR,50),
                new ColumnDetails("Amount",BaseDatatypes.FLOAT),
                new ColumnDetails("Date",BaseDatatypes.DATE),
                new ColumnDetails("Description",BaseDatatypes.TEXT,100),
                new ColumnDetails("Wallet_id",BaseDatatypes.INT)
            };

            Dbconnection();

            if (!manager.TableExists(tableName))
            {
                manager.CreateTable(tableName, columns);
                AddTableNameToTransactionInfo(tableName);
            }

            bool exists = manager.TableExists(tableName);
        }

        private void CreateTableToStoreTransactionInfo()
        {
            SwitchDatabase(databaseName);
            ColumnDetails[] columns = new ColumnDetails[]
            {
                new ColumnDetails("Id",BaseDatatypes.INT ,indexType:IndexType.PrimaryKey,isAutoIncrement:true),
                new ColumnDetails("TransactionName",BaseDatatypes.VARCHAR,40),
            };

            Dbconnection();

            if (!manager.TableExists("TransactionInfo"))
            {
                manager.CreateTable("TransactionInfo", columns);
            }
        }

        private void CreateWalletTable()
        {
            SwitchDatabase(databaseName);
            ColumnDetails[] columns = new ColumnDetails[]
            {
                new ColumnDetails("Wallet_Id",BaseDatatypes.INT ,indexType:IndexType.PrimaryKey,isAutoIncrement:true),
                new ColumnDetails("Wallet_Name",BaseDatatypes.VARCHAR,30),
                new ColumnDetails("Amount",BaseDatatypes.FLOAT),
            };

            Dbconnection();

            if (!manager.TableExists("Wallet"))
            {
                manager.CreateTable("Wallet", columns);

                manager.InsertData("Wallet", 0, "Total", 0);
                manager.InsertData("Wallet", 0, "Cash", 0);                
            }
        }

        private void CreateCurrencyTable()
        {
            SwitchDatabase(databaseName);
            ColumnDetails[] columns = new ColumnDetails[]
            {
                new ColumnDetails("Currency_Id",BaseDatatypes.INT ,indexType:IndexType.PrimaryKey,isAutoIncrement:true),
                new ColumnDetails("Country_Name",BaseDatatypes.VARCHAR,30),
                new ColumnDetails("Symbol",BaseDatatypes.VARCHAR,5),
                new ColumnDetails("Currency",BaseDatatypes.VARCHAR,3),
                new ColumnDetails("OtherToRupee",BaseDatatypes.FLOAT),
                new ColumnDetails("RupeeToOther",BaseDatatypes.FLOAT),
                new ColumnDetails("Flag",BaseDatatypes.VARCHAR,40),
                new ColumnDetails("Updated_Time",BaseDatatypes.DATETIME),
            };

            Dbconnection();

            if (!manager.TableExists("Currency"))
            {
               var b= manager.CreateTable("Currency", columns);

                manager.InsertData("currency", 0, "Australia", "$", "AUD", 54.182094, 0.018456,"Australia.png",DateTime.Now);
                manager.InsertData("currency", 0, "Brazil", "R$", "BRL", 16.6325, 0.060123, "Brazil.png", DateTime.Now);
                manager.InsertData("currency", 0, "Bulgaria", "$", "BGN", 45.8633, 0.021804, "Bulgaria.png", DateTime.Now);
                manager.InsertData("currency", 0, "Canada", "$", "CAD", 61.4876, 0.016263, "Canada.png", DateTime.Now);
                manager.InsertData("currency", 0, "China", "¥", "CNY", 11.5308, 0.086724, "China.png", DateTime.Now);
                manager.InsertData("currency", 0, "Colombia", "$", "COP", 0.02165, 46.1846, "Colombia.png", DateTime.Now);
                manager.InsertData("currency", 0, "Egypt", "£", "EGP", 1.76762, 0.56573, "Egypt.png", DateTime.Now);
                manager.InsertData("currency", 0, "Ethiopia", "$", "ETB", 1.467318, 0.681516, "Ethiopia.png", DateTime.Now);
                manager.InsertData("currency", 0, "HongKong", "$", "HKD", 10.6568, 0.093837, "HongKong.png", DateTime.Now);
                manager.InsertData("currency", 0, "Hungary", "$", "HUF", 0.228234, 4.381466, "Hungary.png", DateTime.Now);
                manager.InsertData("currency", 0, "India", "₹", "INR", 1, 1, "India.png", DateTime.Now);
                manager.InsertData("currency", 0, "Indonesia", "$", "IDR", 0.005238, 190.903506, "Indonesia.png", DateTime.Now);
                manager.InsertData("currency", 0, "Iraq", "$", "IQD", 0.063737, 15.689362, "Iraq.png", DateTime.Now);
                manager.InsertData("currency", 0, "Italy", "$", "EUR", 89.699164, 0.011148, "Italy.png", DateTime.Now);
                manager.InsertData("currency", 0, "Jamaica", "$", "JMD", 0.541679, 1.846112, "Jamaica.png", DateTime.Now);
                manager.InsertData("currency", 0, "Japan", "¥", "JPY", 0.550226, 1.817437, "Japan.png", DateTime.Now);
                manager.InsertData("currency", 0, "Kenya", "$", "KES", 0.632855, 1.580143, "Kenya.png", DateTime.Now);
                manager.InsertData("currency", 0, "Kuwait", "$", "KWD", 271.068088, 0.003689, "Kuwait.png", DateTime.Now);
                manager.InsertData("currency", 0, "Malaysia", "RM", "MYR", 17.638538, 0.056694, "Malaysia.png", DateTime.Now);
                manager.InsertData("currency", 0, "Mexico", "$", "MXN", 5.018677, 0.199256, "Mexico.png", DateTime.Now);
                manager.InsertData("currency", 0, "Myanmar", "$", "MVR", 5.39882, 0.185226, "Myanmar.png", DateTime.Now);
                manager.InsertData("currency", 0, "Nepal", "₨", "NPR", 0.625, 1.6, "Nepal.png", DateTime.Now);
                manager.InsertData("currency", 0, "Netherlands", "$", "EUR", 89.699164, 0.011148, "Netherlands.png", DateTime.Now);
                manager.InsertData("currency", 0, "New Zealand", "$", "NZD", 49.721125, 0.020112, "NewZealand.png", DateTime.Now);
                manager.InsertData("currency", 0, "Nigeria", "$", "NGN", 0.062552, 15.996661, "Nigeria.png", DateTime.Now);
                manager.InsertData("currency", 0, "North Korea", "₩", "KRW", 0.061685, 16.211477, "NorthKorea.png", DateTime.Now);
                manager.InsertData("currency", 0, "Pakistan", "₨", "PKR", 0.299606, 3.337717, "Pakistan.png", DateTime.Now);
                manager.InsertData("currency", 0, "Philipines", "$", "PHP", 1.483204, 0.674216, "Philipines.png", DateTime.Now);
                manager.InsertData("currency", 0, "Russia", "₽", "RUB", 0.902931, 1.107513, "Russia.png", DateTime.Now);
                manager.InsertData("currency", 0, "Saudi Arabia", "﷼", "SAR", 22.242508, 0.044959, "SaudiArabia.png", DateTime.Now);
                manager.InsertData("currency", 0, "Singapore", "$", "SGD", 61.711371, 0.016204, "Singapore.png", DateTime.Now);
                manager.InsertData("currency", 0, "South Africa", "R", "ZAR", 4.39934, 0.227307, "SouthAfrica.png", DateTime.Now);
                manager.InsertData("currency", 0, "Sri Lanka", "₨", "LKR", 0.277633, 3.601876, "SriLanka.png", DateTime.Now);
                manager.InsertData("currency", 0, "Turkey", "$", "TRY", 2.579011, 0.388963, "Turkey.png", DateTime.Now);
                manager.InsertData("currency", 0, "Thailand", "$", "THB", 2.282551, 0.438109, "Thailand.png", DateTime.Now);
                manager.InsertData("currency", 0, "Ukraine", "$", "UAH", 2.132939, 0.468837, "Ukraine.png", DateTime.Now);
                manager.InsertData("currency", 0, "United Kingdom", "£", "GBP", 104.857936, 0.009537, "UK.png", DateTime.Now);
                manager.InsertData("currency", 0, "United States", "$", "USD", 83.409404, 0.011989, "US.png", DateTime.Now);
                manager.InsertData("currency", 0, "Vietnam", "$", "VND", 0.003353, 303.756112, "Vietnam.png", DateTime.Now);
                manager.InsertData("currency", 0, "Zimbabwe", "$", "ZWL", 0.004008, 250.01334, "Zimbabwe.png", DateTime.Now);
            }
            var exists = manager.TableExists("Currency");
        }

        private void CreateRatingTable()
        {
            SwitchDatabase(databaseName);
            ColumnDetails[] columns = new ColumnDetails[]
            {
                new ColumnDetails("Id",BaseDatatypes.INT ,indexType:IndexType.PrimaryKey,isAutoIncrement:true),
                new ColumnDetails("Account_Id",BaseDatatypes.INT),
                new ColumnDetails("Account_Name",BaseDatatypes.VARCHAR,40),
                new ColumnDetails("Rating_Value",BaseDatatypes.FLOAT),
                new ColumnDetails("Rated",BaseDatatypes.BOOLEAN)
            };

            Dbconnection();

            if (!manager.TableExists("Ratings"))
            {
                manager.CreateTable("Ratings", columns);
            }
        }

        #endregion

        #region AddData
        public bool AddUser(string username,string email,string password)
        {
            Dbconnection();
            
            var res = manager.GetCount("userlogindetails", $"email='{email}'").Value;
            if (res == 0)
            {
                string dbName = FindDatabaseName();
                databaseName = dbName;
                var res1 = manager.InsertData("userlogindetails", 0, username, email, password, dbName).Result;
                SwitchDatabase(dbName);
                CreateBudgetTable();
                CreateCategoryTable();
                CreateWalletTable();
                CreateRatingTable();
                CreateTableToStoreTransactionInfo();
                CreateCurrencyTable();
                return res1;
            }
            return false;
        }

        public static int i = 0;

        public bool AddData(ExpenseTrackerDS.Budget budget,bool e)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            if (!e)
            {
                List<string> result = FindDates(budget.Choice, budget.StartDate, budget.EndDate);

                var r = manager.FetchData("budget", $"Start_date='{result[0]}' && End_date='{result[1]}' && Category_id='{budget.CategoryId}'").Value;
                if (r !=null && r.Count>0)
                {
                    List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(r);
                    i = Convert.ToInt32(DataList[0][0]);
                    return false;
                }
                else
                {
                    var res = manager.InsertData("budget", 0, budget.CategoryId, budget.Amount, budget.Choice.ToString(), Convert.ToDateTime(result[0]), Convert.ToDateTime(result[1]), budget.WalletId).Result;
                    return res;
                }                
            }

            else
            {
                List<string> result = FindDates(budget.Choice, budget.StartDate, budget.EndDate);

                var res = manager.UpdateData(
                 "budget",
                 $"Budget_id={i}",
                 new ParameterData("Budget_id", budget.BudgetId),
                 new ParameterData("Category_id", budget.CategoryId),
                 new ParameterData("Amount", budget.Amount),
                 new ParameterData("Choice", budget.Choice.ToString()),
                 new ParameterData("Start_date", result[0]),
                 new ParameterData("End_date", result[1]),
                 new ParameterData("Wallet_id", budget.WalletId)
                 ).Result;

                return true;
            }
            
        }     
        
        public bool AddData(ExpenseTrackerDS.Category category)
        {
            SwitchDatabase(databaseName);
            Dbconnection();
            
            var res = manager.InsertData("category", 0, category.CategoryName, category.ParentId, category.Type, string.Join(",", category.WalletId.Select(n => n.ToString()).ToArray()),category.ImagePath).Result;
            return res;
        }

        public bool AddData(ExpenseTrackerDS.Transaction transaction)
        {
            SwitchDatabase(databaseName);
            Dbconnection();
            string tablename = FindTableName(transaction.Date);
            CreateTransactionTable(tablename);
            var r = manager.FetchColumn("category", "Type", $"Category_id='{transaction.CategoryId}'").Value;
            float total = 0;
            if (r != null)
            {
                foreach(bool f in r)
                {
                    if (f == true)
                    {
                        total += transaction.Amount;
                    }
                    
                }
            }

            var res = manager.InsertData(tablename, 0, transaction.CategoryId, transaction.CategoryName, transaction.Amount, transaction.Date, transaction.Description, transaction.WalletId).Result;
            var dict = manager.FetchData("wallet", $"Wallet_Id='{transaction.WalletId}'").Value;
            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);
            var res1 = manager.UpdateData("wallet", $"Wallet_Id='{transaction.WalletId}'", new ParameterData("Amount", float.Parse(DataList[0][2]) + total));
            /* should hit in form home page as well */
            return res;
        }

        public bool AddData(ExpenseTrackerDS.Wallet wallet)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            var res = manager.InsertData("wallet", 0, wallet.WalletName, wallet.Amount).Result;
            var res2 = FetchCategories();
            var id = manager.FetchColumn("wallet", "Wallet_Id", "", "Wallet_Id DESC", -1, -1).Value[0];
            foreach (ExpenseTrackerDS.Category d in res2)
            {
                if (!d.WalletId.Contains(wallet.WalletID))
                {
                    string s = "";
                    int cnt = 0;
                    foreach (char c in d.ImagePath)
                    {
                        s += c;
                        if (c == 92)
                        {
                            s += (char)92;
                            cnt++;
                            if (cnt == 4)
                            {
                                s = d.ImagePath;
                                break;
                            }
                        }
                    }
                    d.ImagePath = s;

                    d.WalletId.Add(int.Parse(id.ToString()));
                    manager.UpdateData(
                    "category",
                    $"Category_id={d.ID}",
                    new ParameterData("Wallet_id", string.Join(",", d.WalletId.Select(n => n.ToString()).ToArray()))
                    );
                }
            }
            return res;
        }

        public bool AddData(ExpenseTrackerDS.Rating rating)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            var res = manager.InsertData("ratings", 0, rating.Account_Id, rating.Account_Name, rating.Rating_Value, rating.Rated);
            return res.Result;
        }

        public void AddTableNameToTransactionInfo(string tableName)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            var res = manager.InsertData("TransactionInfo", 0, tableName).Result;
        }

        #endregion

        #region Edit Data

        public bool EditData(ExpenseTrackerDS.Budget budget,bool e)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            if (!e)
            {
                List<string> result = FindDates(budget.Choice, budget.StartDate, budget.EndDate);

                var r = manager.FetchData("budget", $"Start_date='{result[0]}' && End_date='{result[1]}' && Category_id='{budget.CategoryId}'").Value;
                if (r != null && r.Count > 0)
                {
                    return false;
                }
                else
                {
                    //List<string> result = FindDates(budget.Choice, budget.StartDate, budget.EndDate);

                    var res = manager.UpdateData(
                     "budget",
                     $"Budget_id={budget.BudgetId}",
                     new ParameterData("Budget_id", budget.BudgetId),
                     new ParameterData("Category_id", budget.CategoryId),
                     new ParameterData("Amount", budget.Amount),
                     new ParameterData("Choice", budget.Choice.ToString()),
                     new ParameterData("Start_date", result[0]),
                     new ParameterData("End_date", result[1]),
                     new ParameterData("Wallet_id", budget.WalletId)
                     ).Result;

                    return true;
                }
            }

            else
            {
                List<string> result = FindDates(budget.Choice, budget.StartDate, budget.EndDate);

                var res = manager.UpdateData(
                 "budget",
                 $"Budget_id={budget.BudgetId}",
                 new ParameterData("Budget_id", budget.BudgetId),
                 new ParameterData("Category_id", budget.CategoryId),
                 new ParameterData("Amount", budget.Amount),
                 new ParameterData("Choice", budget.Choice.ToString()),
                 new ParameterData("Start_date", result[0]),
                 new ParameterData("End_date", result[1]),
                 new ParameterData("Wallet_id", budget.WalletId)
                 ).Result;

                return true;
            }
        }

        public bool EditData(ExpenseTrackerDS.Category category)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            string s = "";
            int cnt = 0;
            foreach (char c in category.ImagePath)
            {
                s += c;
                if (c == 92)
                {
                    s += (char)92;
                    cnt++;
                    if (cnt == 4)
                    {
                        s = category.ImagePath;
                        break;
                    }
                }
            }
            category.ImagePath = s;

            var row = manager.FetchData("category", $"Category_id='{category.ID}'").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(row);

            List<ExpenseTrackerDS.Category> result = GetCategoryRecordsAsListOfObjects(DataList);

            if (result[0].ParentId == 0 && category.ParentId != 0)
            {
                var res1 = manager.UpdateData(
                "category",
                $"Parent_Id={result[0].ID}",
                new ParameterData("Parent_Id", category.ParentId)
                ).Result;
            }

            var res = manager.UpdateData(
                "category",
                $"Category_id={category.ID}",
                new ParameterData("Category_id", category.ID),
                new ParameterData("Category_Name", category.CategoryName),
                new ParameterData("Parent_Id", category.ParentId),
                new ParameterData("Type", category.Type),
                new ParameterData("Wallet_id", string.Join(",", category.WalletId.Select(n => n.ToString()).ToArray())),
                new ParameterData("Category_Image", category.ImagePath)
                );

            return res;
        }

        public bool EditData(ExpenseTrackerDS.Transaction transaction)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            string tablename = FindTableName(transaction.Date);
            var res = manager.UpdateData(
                        tablename,
                        $"Transaction_id={transaction.TransactionId}",
                        new ParameterData("Transaction_id", transaction.TransactionId),
                        new ParameterData("Category_id", transaction.CategoryId),
                        new ParameterData("Category_Name",transaction.CategoryName),
                        new ParameterData("Amount", transaction.Amount),
                        new ParameterData("Date", transaction.Date),
                        new ParameterData("Description", transaction.Description),
                        new ParameterData("Wallet_id", transaction.WalletId)
                        ).Result;

            return res;
        }

        public bool EditData(ExpenseTrackerDS.Wallet wallet)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            var res = manager.UpdateData(
                "wallet",
                $"Wallet_Id={wallet.WalletID}",
                new ParameterData("Wallet_Id", wallet.WalletID),
                new ParameterData("Wallet_Name", wallet.WalletName),
                new ParameterData("Amount", wallet.Amount)
                ).Result;

            return res;
        }

        public bool EditData(ExpenseTrackerDS.Country country)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            var res = manager.UpdateData(
                "currency",
                $"Currency_Id={country.Id}",
                new ParameterData("Currency_Id", country.Id),
                new ParameterData("Country_Name", country.Name),
                new ParameterData("Symbol", country.Symbol),
                new ParameterData("Currency", country.Currency),
                new ParameterData("OtherToRupee", country.AmountOthertoIndia),
                new ParameterData("RupeeToOther", country.AmountIndiatoOther),
                new ParameterData("Flag", country.Flag),
                new ParameterData("Updated_Time", DateTime.Now)
                ).Result;

            return res;
        }

        #endregion

        #region RemoveData
        public bool RemoveData()
        {
            Dbconnection();

            SwitchDatabase("expense_tracker_application");
            //mailId = "sanjula@gmail.com";
            GetUserName(mailId);

            SwitchDatabase(databaseName);
            var res1 = manager.DropDatabase(databaseName);

            SwitchDatabase("expense_tracker_application");
            var res = manager.DeleteData("userlogindetails", $"email='{mailId}'");
                        
            return res;
        }

        public bool RemoveData(ExpenseTrackerDS.Transaction transaction)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            string tableName = FindTableName(transaction.Date); 
            var res = manager.DeleteData(tableName, $"Transaction_id={transaction.TransactionId}").Result;

            return res;
        }

        public bool RemoveData(ExpenseTrackerDS.Budget budget)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            var res = manager.DeleteData("budget", $"Budget_id={budget.BudgetId}").Result;

            return res;
        }

        public bool RemoveData(ExpenseTrackerDS.Category category)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            var res = manager.DeleteData("category", $"Category_id ={category.ID}").Result;            

            if (res)
            {
                Console.WriteLine("Transaction records deleted successfully");

                List<List<List<string>>> DataList = new List<List<List<string>>>();
                for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                {
                    var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                    var dict = manager.DeleteData(tablename[0].ToString(), $"Category_id ={category.ID}").Result;
                }
            }

            return res;
        }

        public bool RemoveData(ExpenseTrackerDS.Wallet wallet)
        {
            SwitchDatabase(databaseName);
            Dbconnection();

            var res = manager.DeleteData("wallet", $"Wallet_Id ={wallet.WalletID}").Result;
            var res1 = FetchCategories();

            foreach (ExpenseTrackerDS.Category d in res1)
            {
                if (!d.WalletId.Contains(wallet.WalletID))
                {
                    d.WalletId.Remove(wallet.WalletID);
                    manager.UpdateData(
                    "category",
                    $"Category_id={d.ID}",
                    new ParameterData("Wallet_id", string.Join(",", d.WalletId.Select(n => n.ToString()).ToArray()))
                    );
                }
            }            

            var res2 = FetchTransactions<List<ExpenseTrackerDS.Transaction>>(0);

            foreach (ExpenseTrackerDS.Transaction d in res2)
            {
                if (d.WalletId==wallet.WalletID)
                {
                    var bol = RemoveData(d);
                }
            }

            var res3 = FetchBudgets();

            foreach (ExpenseTrackerDS.Budget d in res3)
            {
                if (d.WalletId == wallet.WalletID)
                {
                    var bol = RemoveData(d);
                }
            }

            return res;
        }

        #endregion

        #region ShowRegion

        public List<ExpenseTrackerDS.Category> FetchCategories()
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("category", "",-1,-1, "Category_Name ASC").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);            

            List<ExpenseTrackerDS.Category> result = GetCategoryRecordsAsListOfObjects(DataList);
            
            return result;
        }

        public List<ExpenseTrackerDS.Category> FetchCategories(bool type)
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("category", $"Type='{type}'", -1, -1, "Category_Name ASC").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Category> result = GetCategoryRecordsAsListOfObjects(DataList);

            return result;
        }

        public List<ExpenseTrackerDS.Category> FetchCategories(int id)
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("category", $"Parent_Id='{id}'", -1, -1, "Category_Name ASC").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Category> result = GetCategoryRecordsAsListOfObjects(DataList);

            return result;
        }

        public List<ExpenseTrackerDS.Category> FetchCategories(string category_Name)
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("category", $"Category_Name='{category_Name}'", -1, -1, "Category_Name ASC").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Category> result = GetCategoryRecordsAsListOfObjects(DataList);

            return result;
        }

        
        public List<ExpenseTrackerDS.Budget> FetchBudgets()
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("budget", "").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Budget> result = GetBudgetRecordsAsListOfObjects(DataList);
           
            return result;
        }

        public ExpenseTrackerDS.Budget FetchBudgets(int id)
        {
            SwitchDatabase(databaseName);
            ExpenseTrackerDS.Budget budget = new ExpenseTrackerDS.Budget();
            var dict = manager.FetchData("budget", $"Budget_id='{id}'").Value;
            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);
            budget.BudgetId = Convert.ToInt32(DataList[0][0]);
            budget.CategoryId= Convert.ToInt32(DataList[0][1]);
            budget.Amount = float.Parse(DataList[0][2]);
            budget.Choice = (ExpenseTrackerDS.Budget.Choices)Enum.Parse(typeof(ExpenseTrackerDS.Budget.Choices), DataList[0][3]);
            budget.StartDate = Convert.ToDateTime(DataList[0][4]);
            budget.EndDate = Convert.ToDateTime(DataList[0][5]);
            budget.WalletId = Convert.ToInt32(DataList[0][6]);

            return budget;
        }
        
        public List<ExpenseTrackerDS.Budget> FetchPastBudgets()
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("budget", $"End_date<'{DateTime.Now.ToString("yyyy-MM-dd")}'",-1,-1, "Start_date ASC").Value;

            List <List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Budget> result = GetBudgetRecordsAsListOfObjects(DataList);

            return result;
        }

        public List<ExpenseTrackerDS.Wallet> FetchWallet()
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("wallet", "").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Wallet> result = GetWalletRecordsAsListOfObjects(DataList);

            return result;
        }

        public ExpenseTrackerDS.Wallet FetchWallet(int id)
        {
            SwitchDatabase(databaseName);
            ExpenseTrackerDS.Wallet wallet = new ExpenseTrackerDS.Wallet();
            var dict = manager.FetchData("wallet", $"Wallet_Id='{id}'").Value;
            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);
            wallet.WalletID = Convert.ToInt32(DataList[0][0]);
            wallet.WalletName = DataList[0][1];
            wallet.Amount = float.Parse(DataList[0][2]);
            return wallet;
        }

        public List<ExpenseTrackerDS.Transaction> FetchTransactions(string startDate,string endTime,bool type)
        {
            SwitchDatabase(databaseName);
            List<List<List<string>>> DataList = new List<List<List<string>>>();
            List<ExpenseTrackerDS.Transaction> result = new List<ExpenseTrackerDS.Transaction>();

            if (manager.GetCount("transactioninfo", "") > 0)
            {
                for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                {
                    var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                    var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{startDate}' && Date<='{endTime}'", -1, -1, "Date DESC").Value;
                    List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                    DataList.Add(l1);
                }
                result = GetTransactionRecordsAsListOfObjects(DataList);
            }
            return result;
        }

        public T FetchTransactions<T>(int wallet_Id)
        {
            SwitchDatabase(databaseName);
            List<List<List<string>>> DataList = new List<List<List<string>>>();
            List<ExpenseTrackerDS.Transaction> result = new List<ExpenseTrackerDS.Transaction>();
            if (manager.GetCount("transactioninfo","") > 0)
            {
                for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                {
                    var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                    if (wallet_Id == 0)
                    {
                        var dict = manager.FetchData(tablename[0].ToString(), "", -1, -1, "Date DESC").Value;
                        List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                        DataList.Add(l1);
                    }
                    else
                    {
                        var dict = manager.FetchData(tablename[0].ToString(), $"Wallet_id='{wallet_Id}'", -1, -1, "Date DESC").Value;
                        List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                        DataList.Add(l1);
                    }
                }
                result = GetTransactionRecordsAsListOfObjects(DataList);                
            }

            if (typeof(T) == typeof(List<ExpenseTrackerDS.Transaction>))
            {
                return (T)(object)(result);
            }

            else if (typeof(T) == typeof(Dictionary<DateTime, List<ExpenseTrackerDS.Transaction>>))
            {
                Dictionary<DateTime, List<ExpenseTrackerDS.Transaction>> result1 = new Dictionary<DateTime, List<ExpenseTrackerDS.Transaction>>();

                for (int i = 0; i < result.Count; i++)
                {
                    if (result1.ContainsKey(result[i].Date))
                    {
                        result1[result[i].Date].Add(result[i]);
                    }
                    else
                    {
                        result1.Add(result[i].Date, new List<ExpenseTrackerDS.Transaction>() { result[i] });
                    }
                }
                return (T)(object)(result1);
            }

            else if (typeof(T) == typeof(Dictionary<string, List<ExpenseTrackerDS.Transaction>>))
            {
                Dictionary<string, List<ExpenseTrackerDS.Transaction>> result1 = new Dictionary<string, List<ExpenseTrackerDS.Transaction>>();

                for (int i = 0; i < result.Count; i++)
                {
                    if (result1.ContainsKey(result[i].CategoryName))
                    {
                        result1[result[i].CategoryName].Add(result[i]);
                    }
                    else
                    {
                        result1.Add(result[i].CategoryName, new List<ExpenseTrackerDS.Transaction>() { result[i] });
                    }
                }
                return (T)(object)(result1);
            }
            else
            {
                return (T)(object)(new List<ExpenseTrackerDS.Transaction>());
            }
        }       

        public List<ExpenseTrackerDS.Rating> FetchRating()
        {
           // SwitchDatabase(databaseName);
            var dict = manager.FetchData("ratings", "").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Rating> result = GetRatingRecordsAsListOfObjects(DataList);

            return result;
        }

        public List<Tuple<string,float>> FetchAmount()
        {
            SwitchDatabase(databaseName);
            List<Tuple<string, float>> result = new List<Tuple<string, float>>();
            if (manager.GetCount("transactioninfo", "") > 0)
            {
                for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                {
                    var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                    var res = manager.FetchColumn(tablename[0].ToString(), "Amount", "").Value;

                    float total = 0;
                    if (res != null)
                    {
                        foreach (float amount in res)
                        {
                            total += amount;
                        }
                        result.Add(new Tuple<string, float>(tablename[0].ToString().Substring(12), total));
                    }
                    
                }
            }
            return result;
        }

        public float FetchAmount(ExpenseTrackerDS.Budget budget)
        {
            SwitchDatabase(databaseName);
            float amount = 0;

            List<string> dates = new List<string>();
            dates.Add(budget.StartDate.ToString("yyyy-MM-dd"));
            dates.Add(budget.EndDate.ToString("yyyy-MM-dd"));

            //if (budget.WalletId == 1)
            //{
            //    List<int> walletId = FetchCategoryName(budget.CategoryId).WalletId;
            //    foreach (int id in walletId)
            //    {                   
            //        //budgetAmount += budget.Amount;

            //        if (manager.GetCount("transactioninfo", "") > 0)
            //        {
            //            for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
            //            {
            //                var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
            //                var res = manager.FetchData(tablename[0].ToString(), $"Category_id='{budget.CategoryId}' && Date>='{budget.StartDate}' && Date<='{budget.EndDate}' && Wallet_id='{id}'").Value;

            //                float total = 0;
            //                if (res != null)
            //                {

            //                }
            //                amount += total;
            //            }
            //        }
            //       // budgetAmount -= amount;
            //    }
            //}

            //else
            //{
                if (manager.GetCount("transactioninfo", "") > 0)
                {
                    Console.WriteLine("\t\t\tCountttt.: " + manager.GetCount("transactioninfo", "").Value);
                    for (int i = 1; i <= manager.GetCount("transactioninfo", "").Value; i++)
                    {
                        var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                        var res = manager.FetchColumn(tablename[0].ToString(), "Amount", $"Category_id='{budget.CategoryId}' && Date>='{dates[0]}' && Date<='{dates[1]}' && Wallet_id='{budget.WalletId}'").Value;

                        float total = 0;
                        if (res != null)
                        {
                            foreach (float a in res)
                            {
                                total += a;
                            }
                        }
                        amount += total;
                    }
                }
            //}
            
            return amount;
        }

        public string FetchAmount(int category_Id,DateTime date,int wallet_id)
        {
            SwitchDatabase(databaseName);
            float budgetAmount = 0;

            var dict = manager.FetchData("budget", $"Category_id='{category_Id}' && Start_date<='{date.ToString("yyyy-MM-dd")}' && End_date>='{date.ToString("yyyy-MM-dd")}' && Wallet_id='{wallet_id}'").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Budget> result = GetBudgetRecordsAsListOfObjects(DataList);

            if (dict!=null && dict.Count > 0)
            {
                budgetAmount += result[0].Amount;

                float amount = 0;

                if (manager.GetCount("transactioninfo", "") > 0)
                {
                    for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                    {
                        var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                        var res = manager.FetchColumn(tablename[0].ToString(), "Amount", $"Category_id='{result[0].CategoryId}' && Date>='{result[0].StartDate}' && Date<='{result[0].EndDate}'").Value;

                        float total = 0;
                        if (res != null)
                        {
                            foreach (float a in res)
                            {
                                total += a;
                            }
                        }
                        amount += total;
                    }
                }

                return (budgetAmount - amount).ToString();
            }

            else
            {
                //budgetAmount = 0;
                //dict = manager.FetchData("budget", $"Category_id='{category_Id}' && Start_date<='{date.ToString("yyyy-MM-dd")}' && End_date>='{date.ToString("yyyy-MM-dd")}' && Wallet_id='{1}'").Value;
                //if (dict != null && dict.Count > 0)
                //{
                //    List<int> walletId = FetchCategoryName(category_Id).WalletId;
                //    foreach (int id in walletId)
                //    {
                //        DataList = ConvertDictionaryRecordsToListOfRows(dict);
                //        result = GetBudgetRecordsAsListOfObjects(DataList);

                //        budgetAmount += result[0].Amount;

                //        float amount = 0;

                //        if (manager.GetCount("transactioninfo", "") > 0)
                //        {
                //            for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                //            {
                //                var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                //                var res = manager.FetchColumn(tablename[0].ToString(), "Amount", $"Category_id='{result[0].CategoryId}' && Date>='{result[0].StartDate}' && Date<='{result[0].EndDate}' && Wallet_id='{id}'").Value;

                //                float total = 0;
                //                if (res != null)
                //                {
                //                    foreach (float a in res)
                //                    {
                //                        total += a;
                //                    }
                //                }
                //                amount += total;
                //            }                            
                //        }
                //        budgetAmount -= amount;
                //    }
                //    return (budgetAmount).ToString();
                //}
                return "Not Found";
            }
        }

        public List<ExpenseTrackerDS.Country> FetchCurrency()
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("currency", "").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Country> result = GetCurrencyRecordsAsListOfObjects(DataList);

            return result;
        }

        #endregion

        #region MergeData

        public bool Merge(int id1,int id2)
        {
            SwitchDatabase(databaseName);
            if (manager.FetchData("category", $"Category_id='{id1}' && Parent_Id='{0}'").Result && manager.FetchData("category", $"Category_id='{id2}' && Parent_Id='{0}'"))
            {
                var res1 = manager.UpdateData(
                    "category",
                    $"Parent_Id='{id1}'",
                    new ParameterData("Parent_Id", id2));
            }

            var res = manager.FetchColumn("category", "Category_Name", $"Category_id='{id2}'").Value;
            bool result=false;
            for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
            {
                var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                var dict = manager.UpdateData(
                        tablename[0].ToString(), 
                        $"Category_id='{id1}'", 
                        new ParameterData("Category_id", id2),
                        new ParameterData("Category_Name", res[0].ToString())                        
                        ).Result;

                if (dict)
                {
                    result = true;
                }
            }

            var dict1 = manager.DeleteData("category", $"Category_id='{id1}'").Result;
            return result;
        }

        #endregion

        #region UserDetails

        public bool IsUserExits(string email,string password,out string message)
        {
            SwitchDatabase("expense_tracker_application");
            string msg = "";
            bool res;
            var dict = manager.FetchData("userlogindetails", $"email='{email}'").Value;

            if (dict != null && dict.Count > 0)
            {
                List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);
                if (DataList[0][3] == password)
                {
                    msg = "Email and password matches";
                    res = true;
                }
                else
                {
                    msg = "Password doesnot matches";
                    res = false;
                }
            }

            else
            {
                msg = "Email doesnot exits";
                res = false;
            }
            message = msg;
            return res;
        }

        public bool ResetPassword(string email,string password)
        {
            SwitchDatabase("expense_tracker_application");
            var res = manager.UpdateData("userlogindetails", $"email='{email}'", new ParameterData("password", password)).Result;
            GetUserName(email);
            return res;
        }

        public void GetUserName(string email)
        {
            SwitchDatabase("expense_tracker_application");
            var dict = manager.FetchData("userlogindetails", $"email='{email}'").Value;
            if (dict != null && dict.Count > 0)
            {
                List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);
                username = DataList[0][1];
                password = DataList[0][3];
                databaseName = DataList[0][4];
            }
            SwitchDatabase(databaseName);
        }

        #endregion
        #region Dictionay records to list of rows

        private List<List<string>> ConvertDictionaryRecordsToListOfRows(Dictionary<string, List<object>> dict)
        {
            List<List<string>> DataList = new List<List<string>>();

            if (dict!=null && dict.Count>0)
            {
                for (int i = 0; i < dict[dict.Keys.ElementAt(0)].Count(); i++)
                {
                    List<string> data = new List<string>();
                    foreach (var keyVal in dict)
                    {
                        data.Add(keyVal.Value.ElementAt(i).ToString());
                    }
                    DataList.Add(data);
                }
            }

            return DataList;
        }

        #endregion

        #region Fetch records based on conditions

        public List<ExpenseTrackerDS.Budget> FetchRecords(ExpenseTrackerDS.Budget.Choices choice,DateTime startdate,DateTime endDate)
        {
            SwitchDatabase(databaseName);
            List<string> dates = FindDates(choice, startdate, endDate);

            var dict = manager.FetchData("budget", $"Start_date='{dates[0]}' && End_date='{dates[1]}'").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Budget> result = GetBudgetRecordsAsListOfObjects(DataList);

            return result;
        }

        public List<ExpenseTrackerDS.Budget> FetchRecords( DateTime startdate, DateTime endDate)
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("budget", $"Start_date='{startdate.ToString("yyyy-MM-dd")}' && End_date='{endDate.ToString("yyyy-MM-dd")}'").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            List<ExpenseTrackerDS.Budget> result = GetBudgetRecordsAsListOfObjects(DataList);

            return result;
        }

        public ExpenseTrackerDS.Category FetchCategoryName(int CategoryId)
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("category",  $"Category_id='{CategoryId}'").Value;
            
            if (dict!=null && dict.Count>0)
            {
                List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);
                List<ExpenseTrackerDS.Category> result = GetCategoryRecordsAsListOfObjects(DataList);
                return result[0];
            }

            else
            {
                return new ExpenseTrackerDS.Category();
            }
        }

        public List<ExpenseTrackerDS.Category> FetchParentCategories()
        {
            SwitchDatabase(databaseName);
            List<ExpenseTrackerDS.Category> result = new List<ExpenseTrackerDS.Category>();

            var dict = manager.FetchData("category", $"Parent_Id='{0}'",-1,-1, "Category_Name ASC").Value;

            List <List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            result = GetCategoryRecordsAsListOfObjects(DataList);

            return result;
        }

        public ExpenseTrackerDS.Category FetchParentCategories(int id)
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("category", $"Category_id='{id}'").Value;

            if (dict != null && dict.Count > 0)
            {
                List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);
                List<ExpenseTrackerDS.Category> result = GetCategoryRecordsAsListOfObjects(DataList);
                return result[0];
            }

            else
            {
                return null;
            }
        }

        public List<ExpenseTrackerDS.Category> FetchParentCategories(bool type)
        {
            SwitchDatabase(databaseName);
            List<ExpenseTrackerDS.Category> result = new List<ExpenseTrackerDS.Category>();

            var dict = manager.FetchData("category", $"Parent_Id='{0}' && Type='{type}'").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            result = GetCategoryRecordsAsListOfObjects(DataList);

            return result;
        }

        public bool HasChild(ExpenseTrackerDS.Category category)
        {
            SwitchDatabase(databaseName);
            var dict = manager.FetchData("category", $"Parent_Id='{category.ID}'").Value;
            if (dict.Count > 0)
            {
                return true;
            }
            return false;
        }

        public int HasTransaction(ExpenseTrackerDS.Category category)
        {
            SwitchDatabase(databaseName);
            int count = 0;

            for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
            {
                var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                var dict = manager.GetCount(tablename[0].ToString(), $"Category_id='{category.ID}'").Value;

                count += dict;
            }

            return count;

        }

        public bool IsCategory(string category_Name)
        {
            SwitchDatabase(databaseName);
            var res = manager.FetchData("category", $"Category_Name='{category_Name}'").Value;
            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(res);

            List<ExpenseTrackerDS.Category> result = GetCategoryRecordsAsListOfObjects(DataList);
            if (result.Count > 0)
            {
                foreach (ExpenseTrackerDS.Category category in result)
                {
                    if (category.CategoryName == category_Name) return true;
                }
            }
            return false;
        }

        public List<Tuple<string,string>> FetchCustomDates()
        {
            SwitchDatabase(databaseName);
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();

            var dict = manager.FetchData("budget", $"Choice='{ExpenseTrackerDS.Budget.Choices.Custom}' && End_date>='{DateTime.Now.ToString("yyyy-MM-dd")}'",-1,-1, "Start_date ASC").Value;

            List<List<string>> DataList = ConvertDictionaryRecordsToListOfRows(dict);

            foreach(List<string> data in DataList)
            {
                Tuple<string, string> t1 = new Tuple<string, string>(data[4],data[5]);
                result.Add(t1);
            }
            return result;
        }

        public List<Tuple<string,string>> FetchDistinctDates(out List<ExpenseTrackerDS.Budget> budgets)
        {
            SwitchDatabase(databaseName);
            Dictionary<Tuple<string, string>, int> res = new Dictionary<Tuple<string, string>, int>();
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();

            var dict = FetchPastBudgets();
            List<ExpenseTrackerDS.Budget> b1 = new List<ExpenseTrackerDS.Budget>();
            foreach(ExpenseTrackerDS.Budget b in dict)
            {
                Tuple<string, string> t1 = new Tuple<string, string>(b.StartDate.ToString("yyyy-MM-dd"), b.EndDate.ToString("yyyy-MM-dd"));
                if (res.ContainsKey(t1))
                {
                    res[t1]++;
                }
                else
                {
                    res[t1] = 0;
                    result.Add(t1);
                    b1.Add(b);
                }
            }
            budgets = b1;
            return result;
        }

        #endregion

        #region GetRecordsAsListOfObjects

        private List<ExpenseTrackerDS.Transaction> GetTransactionRecordsAsListOfObjects(List<List<List<string>>> DataList)
        {
            List<ExpenseTrackerDS.Transaction> result = new List<ExpenseTrackerDS.Transaction>();

            foreach(List<List<string>> l1 in DataList)
            {
                foreach (List<string> data in l1)
                {
                    ExpenseTrackerDS.Transaction transaction = new ExpenseTrackerDS.Transaction();
                    transaction.TransactionId = Convert.ToInt32(data[0]);
                    transaction.CategoryId = Convert.ToInt32(data[1]);
                    transaction.CategoryName = data[2];
                    transaction.Amount = float.Parse(data[3]);
                    transaction.Date = Convert.ToDateTime(data[4]);
                    transaction.Description = data[5];
                    transaction.WalletId = Convert.ToInt32(data[6]);

                    result.Add(transaction);
                }
            }

            return result;
        }

        private List<ExpenseTrackerDS.Category> GetCategoryRecordsAsListOfObjects(List<List<string>> DataList)
        {
            List<ExpenseTrackerDS.Category> result = new List<ExpenseTrackerDS.Category>();

            foreach (List<string> data in DataList)
            {
                ExpenseTrackerDS.Category category = new ExpenseTrackerDS.Category();
                category.ID = Convert.ToInt32(data[0]);
                category.CategoryName = data[1];
                category.ParentId = Convert.ToInt32(data[2]);
                category.Type = Convert.ToBoolean(data[3]);
                List<string> str = data[4].Split(',').ToList();
                List<int> list = new List<int>();
                foreach (string i in str)
                {
                    if (int.TryParse(i, out int num)) list.Add(num);
                }
                category.WalletId = list;
                category.ImagePath = data[5];
                result.Add(category);
            }

            return result;
        }

        private List<ExpenseTrackerDS.Budget> GetBudgetRecordsAsListOfObjects(List<List<string>> DataList)
        {
            List<ExpenseTrackerDS.Budget> result = new List<ExpenseTrackerDS.Budget>();

            foreach (List<string> data in DataList)
            {
                ExpenseTrackerDS.Budget budget = new ExpenseTrackerDS.Budget();
                budget.BudgetId = Convert.ToInt32(data[0]);
                budget.CategoryId = Convert.ToInt32(data[1]);
                budget.Amount = float.Parse(data[2]);
                budget.Choice = (ExpenseTrackerDS.Budget.Choices)Enum.Parse(typeof(ExpenseTrackerDS.Budget.Choices), data[3]);
                budget.StartDate = Convert.ToDateTime(data[4]);
                budget.EndDate = Convert.ToDateTime(data[5]);
                budget.WalletId = Convert.ToInt32(data[6]);

                result.Add(budget);
            }
            return result;
        }

        private List<ExpenseTrackerDS.Wallet> GetWalletRecordsAsListOfObjects(List<List<string>> DataList)
        {
            List<ExpenseTrackerDS.Wallet> result = new List<ExpenseTrackerDS.Wallet>();

            foreach (List<string> data in DataList)
            {
                ExpenseTrackerDS.Wallet wallet = new ExpenseTrackerDS.Wallet();
                wallet.WalletID = Convert.ToInt32(data[0]);
                wallet.WalletName = data[1];
                wallet.Amount = float.Parse(data[2]);                

                result.Add(wallet);
            }
            return result;
        }

        private List<ExpenseTrackerDS.Rating> GetRatingRecordsAsListOfObjects(List<List<string>> DataList)
        {
            List<ExpenseTrackerDS.Rating> result = new List<ExpenseTrackerDS.Rating>();

            foreach (List<string> data in DataList)
            {
                ExpenseTrackerDS.Rating rating = new ExpenseTrackerDS.Rating();
                rating.ID = Convert.ToInt32(data[0]);
                rating.Account_Id = Convert.ToInt32(data[1]);
                rating.Account_Name = data[2];
                rating.Rating_Value = float.Parse(data[3]);
                rating.Rated = Convert.ToBoolean(data[4]);
                
                result.Add(rating);
            }

            return result;
        }

        private List<ExpenseTrackerDS.Country> GetCurrencyRecordsAsListOfObjects(List<List<string>> DataList)
        {
            List<ExpenseTrackerDS.Country> result = new List<ExpenseTrackerDS.Country>();

            foreach (List<string> data in DataList)
            {
                ExpenseTrackerDS.Country country = new ExpenseTrackerDS.Country();
                country.Id = Convert.ToInt32(data[0]);
                country.Name = data[1];
                country.Symbol = data[2];
                country.Currency =  data[3];
                country.AmountOthertoIndia = float.Parse(data[4]);
                country.AmountIndiatoOther = float.Parse(data[5]);
                country.Flag = data[6];
                country.Updated_Time = Convert.ToDateTime(data[7]);

                result.Add(country);
            }
            return result;
        }

        #endregion

        #region FetchTransactionOnDates

        public T FetchTransactionOnDates<T>(DateTime date, DateTime endDate, ViewType type,int wallet_Id)
        {
            //object creation should be  -> myObject.SomeFunction<ExpenseTrackerDS>(date1,date2,type.month));            

            List<string> dates = new List<string>();

            if (type == ViewType.Day)
            {
                dates.Add(date.ToString("yyyy-MM-dd"));
                dates.Add(date.ToString("yyyy-MM-dd"));
            }

            else if (type == ViewType.Week)
            {
                dates = FindWeek(date);
            }

            else if (type == ViewType.Month)
            {
                dates = FindMonth(date);
            }

            else if (type == ViewType.Quarter)
            {
                dates = FindQuartar(date);
            }

            else if (type == ViewType.Year)
            {
                dates = FindYear(date);
            }

            else
            {
                dates.Add(date.ToString("yyyy-MM-dd"));
                dates.Add(endDate.ToString("yyyy-MM-dd"));
            }

            List<List<List<string>>> DataList = new List<List<List<string>>>();

            if (type == ViewType.Future)
            {
                for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                {
                    var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);

                    if (wallet_Id == 0)
                    {
                        var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}'").Value;
                        if (dict != null)
                        {
                            List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                            DataList.Add(l1);
                        }
                    }
                    else
                    {
                        var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}' && Wallet_id='{wallet_Id}'").Value;
                        if (dict != null)
                        {
                            List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                            DataList.Add(l1);
                        }
                    }                    
                }
            }

            else
            {                
                for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                {
                    var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                    if (wallet_Id == 0)
                    {
                        var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{dates[0]}' && Date<='{dates[1]}'").Value;
                        List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                        DataList.Add(l1);
                    }
                    else
                    {
                        var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{dates[0]}' && Date<='{dates[1]}'&& Wallet_id='{wallet_Id}'").Value;
                        List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                        DataList.Add(l1);
                    }                    
                }
            }

            List<ExpenseTrackerDS.Transaction> result = new List<ExpenseTrackerDS.Transaction>();
            result = GetTransactionRecordsAsListOfObjects(DataList);

            if (typeof(T) == typeof(List<ExpenseTrackerDS.Transaction>))
            {
                return (T)(object)(result);
            }

            else if (typeof(T) == typeof(Dictionary<DateTime, List<ExpenseTrackerDS.Transaction>>))
            {
                Dictionary<DateTime, List<ExpenseTrackerDS.Transaction>> result1 = new Dictionary<DateTime, List<ExpenseTrackerDS.Transaction>>();

                for (int i = 0; i < result.Count; i++)
                {
                    if (result1.ContainsKey(result[i].Date))
                    {
                        result1[result[i].Date].Add(result[i]);
                    }
                    else
                    {
                        result1.Add(result[i].Date, new List<ExpenseTrackerDS.Transaction>() { result[i] });
                    }
                }
                return (T)(object)(result1);
            }

            else if (typeof(T) == typeof(Dictionary<string, List<ExpenseTrackerDS.Transaction>>))
            {
                Dictionary<string, List<ExpenseTrackerDS.Transaction>> result1 = new Dictionary<string, List<ExpenseTrackerDS.Transaction>>();

                for(int i = 0; i < result.Count; i++)
                {
                    if (result1.ContainsKey(result[i].CategoryName))
                    {
                        result1[result[i].CategoryName].Add(result[i]);
                    }
                    else
                    {
                        result1.Add(result[i].CategoryName,new List<ExpenseTrackerDS.Transaction>() {result[i]});
                    }
                }
                return (T)(object)(result1);
            }

            else if (typeof(T) == typeof(Dictionary<bool, List<ExpenseTrackerDS.Transaction>>))
            {
                Dictionary<bool, List<ExpenseTrackerDS.Transaction>> result1 = new Dictionary<bool, List<ExpenseTrackerDS.Transaction>>();

                for (int i = 0; i < result.Count; i++)
                {
                    bool category_type=false;

                    var res = manager.FetchData("category", $"Category_id='{result[i].CategoryId}'").Value;
                    List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(res);

                    if (l1[0][3] == "False")
                    {
                        category_type = false;
                    }

                    else
                    {
                        category_type = true;
                    }

                    if (result1.ContainsKey(category_type))
                    {
                        result1[category_type].Add(result[i]);
                    }
                    else
                    {
                        result1.Add(category_type, new List<ExpenseTrackerDS.Transaction>() { result[i] });
                    }
                }
                return (T)(object)(result1);
            }

            else
            {
                return (T)(object)(new List<ExpenseTrackerDS.Transaction>());
            }
        }

        public List<ExpenseTrackerDS.Transaction> FetchTransactionToExport(string startDate,string endDate,string type,string categoryType)
        {
            SwitchDatabase(databaseName);
            List<List<List<string>>> DataList = new List<List<List<string>>>();
            List<ExpenseTrackerDS.Transaction> result = new List<ExpenseTrackerDS.Transaction>();

            if (type == "All")
            {
                result = FetchTransactions<List<ExpenseTrackerDS.Transaction>>(0);
            }

            else if (type == "After")
            {
                if (manager.GetCount("transactioninfo", "") > 0)
                {
                    for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                    {
                        var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                        var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{startDate}'", -1, -1, "Date DESC").Value;
                        List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                        DataList.Add(l1);
                    }
                    result = GetTransactionRecordsAsListOfObjects(DataList);
                }
            }

            else if (type == "Before")
            {
                if (manager.GetCount("transactioninfo", "") > 0)
                {
                    for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                    {
                        var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                        var dict = manager.FetchData(tablename[0].ToString(), $"Date<='{endDate}'", -1, -1, "Date DESC").Value;
                        List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                        DataList.Add(l1);
                    }
                    result = GetTransactionRecordsAsListOfObjects(DataList);
                }
            }

            else if (type == "Between")
            {
                if (manager.GetCount("transactioninfo", "") > 0)
                {
                    for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                    {
                        var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                        var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{startDate}' && Date<='{endDate}'", -1, -1, "Date DESC").Value;
                        List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                        DataList.Add(l1);
                    }
                    result = GetTransactionRecordsAsListOfObjects(DataList);
                }
            }

            else if (type == "Exact")
            {
                if (type == "All")
                {
                    result = FetchTransactions<List<ExpenseTrackerDS.Transaction>>(0);
                }

                else if (type == "After")
                {
                    if (manager.GetCount("transactioninfo", "") > 0)
                    {
                        for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                        {
                            var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                            var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{startDate}'", -1, -1, "Date DESC").Value;
                            List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                            DataList.Add(l1);
                        }
                        result = GetTransactionRecordsAsListOfObjects(DataList);
                    }
                }

                else if (type == "Before")
                {
                    if (manager.GetCount("transactioninfo", "") > 0)
                    {
                        for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                        {
                            var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                            var dict = manager.FetchData(tablename[0].ToString(), $"Date<='{endDate}'", -1, -1, "Date DESC").Value;
                            List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                            DataList.Add(l1);
                        }
                        result = GetTransactionRecordsAsListOfObjects(DataList);
                    }
                }

                else if (type == "Between")
                {
                    if (manager.GetCount("transactioninfo", "") > 0)
                    {
                        for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                        {
                            var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                            var dict = manager.FetchData(tablename[0].ToString(), $"Date>='{startDate}' && Date<='{endDate}'", -1, -1, "Date DESC").Value;
                            List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                            DataList.Add(l1);
                        }
                        result = GetTransactionRecordsAsListOfObjects(DataList);
                    }
                }

                else if (type == "Exact")
                {
                    if (manager.GetCount("transactioninfo", "") > 0)
                    {
                        for (int i = 1; i <= manager.GetCount("transactioninfo", ""); i++)
                        {
                            var tablename = manager.FetchData("transactioninfo", $"Id ={i}", -1, -1, "", "TransactionName").Value.Values.ElementAt(0);
                            var dict = manager.FetchData(tablename[0].ToString(), $"Date='{startDate}'", -1, -1, "Date DESC").Value;
                            List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(dict);
                            DataList.Add(l1);
                        }
                        result = GetTransactionRecordsAsListOfObjects(DataList);
                    }
                }
            }

            if (categoryType == "All")
            {
                return result;
            }            

            else if (categoryType == "Income")
            {
                Dictionary<bool, List<ExpenseTrackerDS.Transaction>> result1 = new Dictionary<bool, List<ExpenseTrackerDS.Transaction>>();

                for (int i = 0; i < result.Count; i++)
                {
                    bool category_type = false;

                    var res = manager.FetchData("category", $"Category_id='{result[i].CategoryId}'").Value;
                    List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(res);

                    if (l1[0][3] == "False")
                    {
                        category_type = false;
                    }

                    else
                    {
                        category_type = true;
                    }

                    if (result1.ContainsKey(category_type))
                    {
                        result1[category_type].Add(result[i]);
                    }
                    else
                    {
                        result1.Add(category_type, new List<ExpenseTrackerDS.Transaction>() { result[i] });
                    }
                }

                List<ExpenseTrackerDS.Transaction> res1 = new List<ExpenseTrackerDS.Transaction>();
                foreach(var d in result1)
                {
                    if (d.Key == true)
                    {
                        res1 = d.Value;
                        break;
                    }
                }

                return res1;
            }

            else if (categoryType == "Expense")
            {
                Dictionary<bool, List<ExpenseTrackerDS.Transaction>> result1 = new Dictionary<bool, List<ExpenseTrackerDS.Transaction>>();

                for (int i = 0; i < result.Count; i++)
                {
                    bool category_type = false;

                    var res = manager.FetchData("category", $"Category_id='{result[i].CategoryId}'").Value;
                    List<List<string>> l1 = ConvertDictionaryRecordsToListOfRows(res);

                    if (l1[0][3] == "False")
                    {
                        category_type = false;
                    }

                    else
                    {
                        category_type = true;
                    }

                    if (result1.ContainsKey(category_type))
                    {
                        result1[category_type].Add(result[i]);
                    }
                    else
                    {
                        result1.Add(category_type, new List<ExpenseTrackerDS.Transaction>() { result[i] });
                    }
                }

                List<ExpenseTrackerDS.Transaction> res1 = new List<ExpenseTrackerDS.Transaction>();
                foreach (var d in result1)
                {
                    if (d.Key == false)
                    {
                        res1 = d.Value;
                        break;
                    }
                }

                return res1;
            }
            else
            {
                return new List<ExpenseTrackerDS.Transaction>();
            }
        }
       
        public List<ExpenseTrackerDS.Transaction> FetchTransactionsOnDates(DateTime startDate,DateTime endDate)
        {
            SwitchDatabase(databaseName);
            List<Transaction> result = new List<Transaction>();
            List<Transaction> transactions = FetchTransactions<List<Transaction>>(0);
            foreach(Transaction transaction in transactions)
            {
                if(transaction.Date>=startDate && transaction.Date <= endDate)
                {
                    result.Add(transaction);
                }
            }
            return result;
        }
        #endregion

        #region Find StartDate and EndDate        

        public List<string> FindQuartar(DateTime date)
        {
            List<string> result = new List<string>();
            if (date.Month % 3 == 0)
            {
                DateTime end = new DateTime(date.Year, date.Month, 1);
                DateTime start = new DateTime(date.Year, end.AddMonths(-2).Month, end.AddMonths(-2).AddDays(-1).Day);
                string startDate = start.ToString("yyyy-MM-dd");
                string endDate = end.ToString("yyyy-MM-dd");
                result.Add(startDate);
                result.Add(endDate);
            }

            else if (date.Month % 3 == 2)
            {
                DateTime end = new DateTime(date.Year, date.AddMonths(1).Month, 1);
                DateTime start = new DateTime(date.Year, end.AddMonths(-2).Month, end.AddMonths(-2).AddDays(-1).Day);
                string startDate = start.ToString("yyyy-MM-dd");
                string endDate = end.ToString("yyyy-MM-dd");
                result.Add(startDate);
                result.Add(endDate);
            }

            else if (date.Month % 3 == 1)
            {
                DateTime start = new DateTime(date.Year, date.Month, 1);
                DateTime end = new DateTime(date.Year, start.AddMonths(2).Month, start.AddMonths(3).AddDays(-1).Day);
                string startDate = start.ToString("yyyy-MM-dd");
                string endDate = end.ToString("yyyy-MM-dd");
                result.Add(startDate);
                result.Add(endDate);
            }

            return result;
        }

        public List<string> FindYear(DateTime date)
        {
            DateTime start = new DateTime(date.Year, 1, 1);
            string startDate = start.ToString("yyyy-MM-dd");
            DateTime end = new DateTime(date.Year, 12, 31);
            string endDate = end.ToString("yyyy-MM-dd");

            List<string> result = new List<string>();
            result.Add(startDate);
            result.Add(endDate);

            return result;
        }

        public List<string> FindMonth(DateTime date)
        {
            DateTime start = new DateTime(date.Year, date.Month, 1);
            DateTime end = start.AddMonths(1).AddDays(-1);
            string startDate = start.ToString("yyyy-MM-dd");
            string endDate = end.ToString("yyyy-MM-dd");

            List<string> result = new List<string>();
            result.Add(startDate);
            result.Add(endDate);

            return result;
        }

        public List<string> FindWeek(DateTime date)
        {
            int start = (int)date.DayOfWeek;
            int end = 6 - start;
            string startDate = date.AddDays(-start).ToString("yyyy-MM-dd");
            string endDate = date.AddDays(+end).ToString("yyyy-MM-dd");
            List<string> result = new List<string>();
            result.Add(startDate);
            result.Add(endDate);

            return result;
        }

        public List<string> FindDates(ExpenseTrackerDS.Budget.Choices choice, DateTime startDate, DateTime endDate)
        {
            List<string> result = new List<string>();

            if (choice == ExpenseTrackerDS.Budget.Choices.ThisWeek)
            {
                result = FindWeek(DateTime.Now);
            }

            else if (choice == ExpenseTrackerDS.Budget.Choices.ThisMonth)
            {
                result = FindMonth(DateTime.Now);
            }

            else if (choice == ExpenseTrackerDS.Budget.Choices.ThisYear)
            {
                result = FindYear(DateTime.Now);
            }

            else if (choice == ExpenseTrackerDS.Budget.Choices.ThisQuarter)
            {
                result = FindQuartar(new DateTime(2024, 4, 1));
            }

            else
            {
                result.Add(startDate.ToString("yyyy-MM-dd"));
                result.Add(endDate.ToString("yyyy-MM-dd"));
            }

            return result;
        }

        #endregion

        #region CommonFunctions       

        private void Dbconnection()
        {
            if (!manager.IsConnected)
            {
                manager.Connect();
            }
        }

        private string FindTableName(DateTime date1)
        {
            string date = date1.ToString("yyyy-MM-dd");
            string tablename = "Transaction_" + date1.ToString("yyyy") + "_" + date1.ToString("MM");
            return tablename;
        }
   
        private string FindDatabaseName()
        {
            string dbName = "expensetracker_" + manager.GetCount("userlogindetails", "").Value;
            
            return dbName;
        }

        public enum ViewType
        {
            Day,
            Week,
            Month,
            Quarter,
            Year,
            Custom,
            Future
        }

        #endregion
    }
}