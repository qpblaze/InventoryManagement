using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class SalesAndProfit : Form
    {
        private Sales mainForm;
        private string globalDate = null;

        public SalesAndProfit(Sales _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            productsGV.MultiSelect = false;
            productsGV.EditMode = DataGridViewEditMode.EditProgrammatically;

            for (int i = 2016; i <= DateTime.Now.Year; i++)
                yearCB.Items.Add(i.ToString());

            dayCB.SelectedItem = DateTime.Now.Day.ToString();
            monthCB.SelectedItem = IntToMonth(DateTime.Now.Month);
            yearCB.SelectedItem = DateTime.Now.Year.ToString();
        }

        private void SalesAndProfit_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void SalesAndProfit_Load(object sender, EventArgs e)
        {
            ReloadDataGirdView();

            List<Category> categories = Category.GetAll();
            List<Supplier> suppliers = Supplier.GetAll();
            List<Store> stores = Store.GetAll();

            double totalSpent = 0.0;
            foreach (Product prod in Product.GetAll())
            {
                double.TryParse(prod.BuyingPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double inv);
                totalSpent += inv * prod.InStock;
            }

            totalSpentL.Text = totalSpent.ToString();

            categoryCB.Items.Add("All");
            supplierCB.Items.Add("All");
            storeCB.Items.Add("All");

            foreach (Category cat in categories.OrderBy(c => c.Name).ToList())
            {
                categoryCB.Items.Add(cat.Name);
            }

            foreach (Supplier sup in suppliers.OrderBy(s => s.Name).ToList())
            {
                supplierCB.Items.Add(sup.Name);
            }

            foreach (Store store in stores.OrderBy(s => s.Name).ToList())
            {
                storeCB.Items.Add(store.Name);
            }

            categoryCB.SelectedIndex = 0;
            supplierCB.SelectedIndex = 0;
            storeCB.SelectedIndex = 0;

            ApplyDate();
        }

        public void ReloadDataGirdView(string filter = null, string category = null, string supplier = null, string store = null, int day = 0, int week = 0, int month = 0, int year = 0, string date = null)
        {
            productsGV.Rows.Clear();

            if (!productsGV.Columns.Contains("id"))
            {
                productsGV.Columns.Add("id", "Sale ID");
                productsGV.Columns.Add("date", "Date");
                productsGV.Columns.Add("productId", "Product ID");
                productsGV.Columns.Add("name", "Name");
                productsGV.Columns.Add("description", "Description");
                productsGV.Columns.Add("category", "Category");
                productsGV.Columns.Add("supplier", "Supplier");
                productsGV.Columns.Add("store", "Store");
                productsGV.Columns.Add("soldTo", "Sold To");
                productsGV.Columns.Add("buyPrice", "Buying Price");
                productsGV.Columns.Add("sellPrice", "Selling Price");
                productsGV.Columns.Add("soldWith", "Sold With");
                productsGV.Columns.Add("profit", "Profit");
            }

            List<Sale> sales = Sale.GetAll();

            double invested = 0;
            double sold = 0;

            if (filter != null)
                sales = sales.Where(p => p.Product.Name.ToLower().Contains(filter.ToLower()) || p.ID.ToLower().Contains(filter.ToLower()) || p.Product.Description.ToLower().Contains(filter.ToLower())).ToList();
            if (category != null)
                sales = sales.Where(p => p.Product.Category.ToLower().Equals(category.ToLower())).ToList();
            if (supplier != null)
                sales = sales.Where(p => p.Product.Supplier.ToLower().Equals(supplier.ToLower())).ToList();
            if (store != null)
                sales = sales.Where(p => p.Product.Store != null && p.Product.Store.ToLower().Equals(store.ToLower())).ToList();

            if (day != 0)
                sales = sales.Where(p => p.Date.Day == day).ToList();
            if (week != 0)
                sales = sales.Where(p => GetWeekNumber(p.Date) == week).ToList();
            if (month != 0)
                sales = sales.Where(p => p.Date.Month == month).ToList();
            if (year != 0)
                sales = sales.Where(p => p.Date.Year == year).ToList();

            if (date != null)
                sales = sales.Where(p => p.Date.ToShortDateString() == DateTime.Parse(date).ToShortDateString()).ToList();

            double totalSellPrice = 0.0;
            double totalBuyPrice = 0.0;
            foreach (Sale s in sales)
            {
                double.TryParse(s.Product.BuyingPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double inv);
                double.TryParse(s.SoldWith.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double so);

                invested += inv;
                sold += so;

                double.TryParse(s.Product.SellingPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double sellPrice);
                totalSellPrice += sellPrice;

                double.TryParse(s.SoldWith.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double price);
                totalBuyPrice += price;
                productsGV.Rows.Add(new object[] { s.ID, s.Date, int.Parse(s.Product.ID), s.Product.Name, s.Product.Description, s.Product.Category, s.Product.Supplier, s.Product.Store, s.SoldTo, inv, sellPrice, price, price - inv });
            }
            productsGV.Rows.Add(new object[] { "Total", null, null, null, null, null, null, null, null, invested, totalSellPrice, totalBuyPrice, totalBuyPrice - invested });

            if (!productsGV.Columns.Contains("deleteBtn"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                productsGV.Columns.Add(btn);
                btn.HeaderText = "Action";
                btn.Text = "Delete";
                btn.Name = "deleteBtn";
                btn.UseColumnTextForButtonValue = true;
            }

            investedL.Text = invested.ToString();
            soldL.Text = sold.ToString();
            double profit = sold - invested;
            if (profit > 0)
                profitL.ForeColor = Color.Green;
            if (profit < 0)
                profitL.ForeColor = Color.Red;
            profitL.Text = profit.ToString("f2");
        }

        private void ApplyFilters(int day = 0, int week = 0, int month = 0, int year = 0, string date = null)
        {
            string filter = null;
            string category = null;
            string supplier = null;
            string store = null;

            if (!string.IsNullOrEmpty(searchTB.Text))
                filter = searchTB.Text;

            if (categoryCB.SelectedIndex != 0 && categoryCB.SelectedItem != null)
            {
                category = categoryCB.SelectedItem.ToString();
            }
            if (supplierCB.SelectedIndex != 0 && supplierCB.SelectedItem != null)
            {
                supplier = supplierCB.SelectedItem.ToString();
            }
            if (storeCB.SelectedIndex != 0 && storeCB.SelectedItem != null)
            {
                store = storeCB.SelectedItem.ToString();
            }

            ReloadDataGirdView(filter, category, supplier, store, day, week, month, year, date);
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void supplierCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dailySales_Click(object sender, EventArgs e)
        {
            ApplyFilters(DateTime.Now.Day);
        }

        private void weeklySales_Click(object sender, EventArgs e)
        {
            ApplyFilters(0, GetWeekNumber(DateTime.Now));
        }

        private int GetWeekNumber(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private void all_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void monthlySales_Click(object sender, EventArgs e)
        {
            ApplyFilters(0, 0, DateTime.Now.Month, DateTime.Now.Year);
        }

        private void annuallySales_Click(object sender, EventArgs e)
        {
            ApplyFilters(0, 0, 0, DateTime.Now.Year);
        }

        private void export_Click(object sender, EventArgs e)
        {
            productsGV.MultiSelect = true;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "SalesAndProfit_" + globalDate + ".xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application xlexcel = new Microsoft.Office.Interop.Excel.Application();

                xlexcel.DisplayAlerts = false;
                Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

                Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                Range CR = (Range)xlWorkSheet.Cells[2, 1];
                CR.Select();

                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();
                xlWorkSheet.Cells[1, 1] = "Sale ID";
                xlWorkSheet.Cells[1, 2] = "Date";
                xlWorkSheet.Cells[1, 3] = "Product ID";
                xlWorkSheet.Cells[1, 4] = "Name";
                xlWorkSheet.Cells[1, 5] = "Description";
                xlWorkSheet.Cells[1, 6] = "Category";
                xlWorkSheet.Cells[1, 7] = "Supplier";
                xlWorkSheet.Cells[1, 8] = "Store";
                xlWorkSheet.Cells[1, 9] = "Sold To";
                xlWorkSheet.Cells[1, 10] = "Buying Price";
                xlWorkSheet.Cells[1, 11] = "Selling Price";
                xlWorkSheet.Cells[1, 12] = "Sold With";
                xlWorkSheet.Cells[1, 13] = "Profit";

                xlWorkSheet.Columns.AutoFit();
                xlWorkBook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;

                rng = xlWorkSheet.get_Range("N:N").Cells;
                rng.Delete();
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                Clipboard.Clear();
                productsGV.ClearSelection();

                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            productsGV.MultiSelect = false;
        }

        private void copyAlltoClipboard()
        {
            productsGV.SelectAll();
            DataObject dataObj = productsGV.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void productsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < productsGV.Rows.Count - 2)
            {
                if (productsGV.CurrentCell.ColumnIndex == productsGV.Columns.IndexOf(productsGV.Columns["deleteBtn"]))
                {
                    string id = productsGV.Rows[productsGV.CurrentCell.RowIndex].Cells[productsGV.Columns.IndexOf(productsGV.Columns["ID"])].Value.ToString();
                    Sale sale = Sale.GetSingle(id);
                    if (sale != null)
                    {
                        Product prod = Product.GetSingle(sale.Product.ID);
                        if (prod != null)
                        {
                            prod.InStock++;
                            prod.Edit();
                            sale.Product = prod;
                            mainForm.ReloadDataGirdView();
                        }
                        sale.Delete();
                        ReloadDataGirdView();
                        ApplyDate();
                    }
                }
            }
        }

        private void productsGV_Sorted(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = productsGV.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["id"].Value.ToString().Equals("Total")).First();
                productsGV.Rows.Remove(row);
                productsGV.Rows.Add(row);
            }
            catch (Exception)
            {
            }
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyDate();
        }

        private void dayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyDate();
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyDate();
        }

        private void ApplyDate()
        {
            try
            {
                int day = 0;
                int month = 0;
                int year = 0;
                if (dayCB.SelectedItem.ToString() != "All")
                    day = int.Parse(dayCB.SelectedItem.ToString());
                if (monthCB.SelectedItem.ToString() != "All")
                    month = MonthInt(monthCB.SelectedItem.ToString());
                if (yearCB.SelectedItem.ToString() != "All")
                    year = int.Parse(yearCB.SelectedItem.ToString());
                globalDate = dayCB.SelectedItem.ToString() + "_" + monthCB.SelectedItem.ToString() + "_" + yearCB.SelectedItem.ToString();

                if (show.Text == "Profit per month")
                {
                    productsGV.Columns.Clear();
                    ApplyFilters(day, 0, month, year, null);
                }
                else
                {
                    productsGV.Columns.Clear();
                    ProfitGrid(month, year);
                }
            }
            catch (Exception)
            {
                //ignore
            }
        }

        private int MonthInt(string month)
        {
            int m = 0;
            switch (month)
            {
                case "January":
                    m = 1;
                    break;

                case "February":
                    m = 2;
                    break;

                case "March":
                    m = 3;
                    break;

                case "April":
                    m = 4;
                    break;

                case "May":
                    m = 5;
                    break;

                case "June":
                    m = 6;
                    break;

                case "July":
                    m = 7;
                    break;

                case "August":
                    m = 8;
                    break;

                case "September":
                    m = 9;
                    break;

                case "October":
                    m = 10;
                    break;

                case "November":
                    m = 11;
                    break;

                case "December":
                    m = 12;
                    break;

                default:
                    m = 0;
                    break;
            }
            return m;
        }

        private string IntToMonth(int month)
        {
            string m = "";
            switch (month)
            {
                case 1:
                    m = "January";
                    break;

                case 2:
                    m = "February";
                    break;

                case 3:
                    m = "March";
                    break;

                case 4:
                    m = "April";
                    break;

                case 5:
                    m = "May";
                    break;

                case 6:
                    m = "June";
                    break;

                case 7:
                    m = "July";
                    break;

                case 8:
                    m = "August";
                    break;

                case 9:
                    m = "September";
                    break;

                case 10:
                    m = "October";
                    break;

                case 11:
                    m = "November";
                    break;

                case 12:
                    m = "December";
                    break;

                default:
                    m = "All";
                    break;
            }
            return m;
        }

        private void ProfitGrid(int month = 0, int year = 0)
        {
            if (month != 0 && year != 0)
            {
                if (!productsGV.Columns.Contains("id"))
                {
                    productsGV.Columns.Add("date", "Date");
                    productsGV.Columns.Add("sold", "Sold");
                    productsGV.Columns.Add("invested", "Invested");
                    productsGV.Columns.Add("profit", "Profit");
                }
                List<Sale> sales = Sale.GetAll().Where(s => s.Date.Month == month && s.Date.Year == year).ToList();
                for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
                {
                    DateTime date = new DateTime(year, month, i);
                    double sold = sales.Where(s => s.Date.Day == i).Sum(s => double.Parse(s.SoldWith.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture));
                    double invested = sales.Where(s => s.Date.Day == i).Sum(s => double.Parse(s.Product.BuyingPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture));
                    double profit = sold - invested;
                    productsGV.Rows.Add(new object[] { date, sold, invested, profit });
                }
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (show.Text == "Profit per month")
            {
                productsGV.Columns.Clear();
                show.Text = "Profit per sale";
                int month = 0, year = 0;
                if (monthCB.SelectedItem.ToString() != "All")
                {
                    month = MonthInt(monthCB.SelectedItem.ToString());
                    if (yearCB.SelectedItem.ToString() != "All")
                    {
                        year = int.Parse(yearCB.SelectedItem.ToString());
                        ProfitGrid(month, year);
                    }
                }
            }
            else
            {
                show.Text = "Profit per month";
                productsGV.Columns.Clear();
                ApplyDate();
            }
        }

        private void storeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}