using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ManageProducts : Form
    {
        Sales mainForm;
        string id = null;
        List<Category> categories = new List<Category>();
        List<Supplier> suppliers = new List<Supplier>();
        List<Store> stores = new List<Store>();

        public ManageProducts(Sales _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            productsGV.MultiSelect = false;
            productsGV.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void ManageProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.ReloadDataGirdView();
            mainForm.Show();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            ReloadDataGirdView();

            categories = Category.GetAll();
            suppliers = Supplier.GetAll();
            stores = Store.GetAll();

            categoryCB.DataSource = categories;
            categoryCB.ValueMember = "Name";
            categoryCB.SelectedValue = "ID";

            supplierCB.DataSource = suppliers;
            supplierCB.ValueMember = "Name";
            supplierCB.SelectedValue = "ID";

            storeCB.DataSource = stores;
            storeCB.ValueMember = "Name";
            storeCB.SelectedValue = "ID";

            supplierCBS.Items.Add("All");
            categoryCBS.Items.Add("All");
            storeCBS.Items.Add("All");

            foreach (Category cat in categories.OrderBy(c => c.Name).ToList())
            {
                categoryCBS.Items.Add(cat.Name);
            }

            foreach (Supplier sup in suppliers.OrderBy(s => s.Name).ToList())
            {
                supplierCBS.Items.Add(sup.Name);
            }

            foreach (Store store in stores.OrderBy(s => s.Name).ToList())
            {
                storeCBS.Items.Add(store.Name);
            }

            categoryCBS.SelectedIndex = 0;
            supplierCBS.SelectedIndex = 0;
            storeCBS.SelectedIndex = 0;
        }

        private void ClearInputs()
        {
            name.Text = "";
            minStock.Text = "";
            description.Text = "";
            stock.Text = "";
            buyingPrice.Text = "";
            sellingPrice.Text = "";
            supplierCB.SelectedValue = "";
            categoryCB.SelectedValue = "";
            storeCB.SelectedValue = "";
            stockIn.Text = "";

            nameL.ForeColor = Color.Silver;
            descriptionL.ForeColor = Color.Silver;
            sellingL.ForeColor = Color.Silver;
            buyingL.ForeColor = Color.Silver;
            minL.ForeColor = Color.Silver;
            stockL.ForeColor = Color.Silver;
            categoryL.ForeColor = Color.Silver;
            supplierL.ForeColor = Color.Silver;
            label2.ForeColor = Color.Silver;
            storeL.ForeColor = Color.Silver;

            id = null;
        }

        double totalSellPrice = 0.0;
        double totalBuyPrice = 0.0;
        int totalStock = 0;

        private void ReloadDataGirdView(string filter = null, string category = null, string supplier = null, string store = null)
        {
            productsGV.Rows.Clear();
            totalSellPrice = 0.0;
            totalBuyPrice = 0.0;
            totalStock = 0;
            if (!productsGV.Columns.Contains("id"))
            {
                productsGV.Columns.Add("id", "ID");
                productsGV.Columns.Add("name", "Name");
                productsGV.Columns.Add("description", "Description");
                productsGV.Columns.Add("category", "Category");
                productsGV.Columns.Add("supplier", "Supplier");
                productsGV.Columns.Add("store", "Store");
                productsGV.Columns.Add("buyingPrice", "Buying Price");
                productsGV.Columns.Add("sellingPrice", "Selling Price");
                productsGV.Columns.Add("inStock", "In Stock");
                productsGV.Columns.Add("minStock", "Min Stock");
            }


            List<Product> products = Product.GetAll();

            if (filter != null)
                products = products.Where(p => p.Name.ToLower().Contains(filter.ToLower()) || p.ID.ToLower().Contains(filter.ToLower()) || p.Description.ToLower().Contains(filter.ToLower())).ToList();
            if (category != null)
                products = products.Where(p => p.Category.ToLower().Equals(category.ToLower())).ToList();
            if (supplier != null)
                products = products.Where(p => p.Supplier.ToLower().Equals(supplier.ToLower())).ToList();
            if (store != null)
                products = products.Where(p => p.Store != null && p.Store.ToLower().Equals(store.ToLower())).ToList();

            int i = 0;
            foreach (Product prod in products)
            {
                double buyPrice;
                double.TryParse(prod.BuyingPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out buyPrice);
                totalBuyPrice += buyPrice;

                double sellPrice;
                double.TryParse(prod.SellingPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out sellPrice);
                totalSellPrice += sellPrice;

                totalStock += prod.InStock;

                productsGV.Rows.Add(new object[] { int.Parse(prod.ID), prod.Name, prod.Description, prod.Category, prod.Supplier, prod.Store, buyPrice, sellPrice, prod.InStock, prod.MinStock});
                if (prod.InStock < prod.MinStock && prod.InStock != 0)
                    productsGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 94, 94);
                if(prod.InStock == prod.MinStock)
                    productsGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 102);
                if (prod.InStock > prod.MinStock + 5)
                    productsGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(74, 229, 74);
                if(prod.InStock == 0)
                {
                    productsGV.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    productsGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
                }
                i++;
            }
            
            productsGV.Rows.Add(new object[] { "Total", (productsGV.Rows.Count - 1).ToString(), null, null, null, null, totalBuyPrice, totalSellPrice, totalStock, 0});
            
            if (!productsGV.Columns.Contains("deleteBtn"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                productsGV.Columns.Add(btn);
                btn.HeaderText = "Action";
                btn.Text = "Delete";
                btn.Name = "deleteBtn";
                btn.UseColumnTextForButtonValue = true;
            }
            

        }

        private bool ValidInputs()
        {
            bool error = false;
            if (string.IsNullOrEmpty(name.Text))
            {
                nameL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                nameL.ForeColor = Color.Silver;
            }

            if (string.IsNullOrEmpty(description.Text))
            {
                descriptionL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                descriptionL.ForeColor = Color.Silver;
            }
            double val;
            if (string.IsNullOrEmpty(sellingPrice.Text))
            {
                sellingL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                try
                {
                    val = double.Parse(sellingPrice.Text.Replace(',', '.'));
                    sellingL.ForeColor = Color.Silver;
                }
                catch (Exception)
                {
                    sellingL.ForeColor = Color.FromArgb(255, 94, 94);
                    error = true;
                }
            }

            if (string.IsNullOrEmpty(buyingPrice.Text))
            {
                buyingL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                try
                {
                    val = double.Parse(buyingPrice.Text.Replace(',', '.'));
                    buyingL.ForeColor = Color.Silver;
                }
                catch (Exception)
                {
                    buyingL.ForeColor = Color.FromArgb(255, 94, 94);
                    error = true;
                }
            }
            
            if (string.IsNullOrEmpty(minStock.Text))
            {
                minL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                try
                {
                    val = double.Parse(minStock.Text.Replace(',', '.'));
                    minL.ForeColor = Color.Silver;
                }
                catch(Exception)
                {
                    minL.ForeColor = Color.FromArgb(255, 94, 94);
                    error = true;
                }
            }

            if (string.IsNullOrEmpty(stock.Text))
            {
                stockL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                try
                {
                    val = double.Parse(stock.Text.Replace(',', '.'));
                    stockL.ForeColor = Color.Silver;
                }
                catch (Exception)
                {
                    stockL.ForeColor = Color.FromArgb(255, 94, 94);
                    error = true;
                }
            }

            if(categoryCB.SelectedIndex == -1)
            {
                categoryL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                categoryL.ForeColor = Color.Silver;
            }

            if (supplierCB.SelectedIndex == -1)
            {
                supplierL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                supplierL.ForeColor = Color.Silver;
            }

            if (storeCB.SelectedIndex == -1)
            {
                storeL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                storeL.ForeColor = Color.Silver;
            }

            return !error;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(ValidInputs())
            {
                Product product = GetProduct();
                product.Add();

                ReloadDataGirdView();
                ClearInputs();
                ApplyFilters();
            }
        }

        private Product GetProduct()
        {
            Product product = new Product();
            product.Name = name.Text;
            product.Description = description.Text;
            Category cat = (Category)categoryCB.SelectedItem;
            Supplier sup = (Supplier)supplierCB.SelectedItem;
            Store store = (Store)storeCB.SelectedItem;

            product.Category = cat.Name;
            product.Supplier = sup.Name;
            product.Store = store.Name;
            product.InStock = int.Parse(stock.Text);
            product.MinStock = int.Parse(minStock.Text);
            product.BuyingPrice = buyingPrice.Text.Replace(',', '.');
            product.SellingPrice = sellingPrice.Text.Replace(',', '.');

            return product;
        }

        private void productsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < productsGV.Rows.Count - 1)
            {
                ClearInputs();
                id = productsGV.Rows[productsGV.CurrentCell.RowIndex].Cells[productsGV.Columns.IndexOf(productsGV.Columns["ID"])].Value.ToString();
                Product product = Product.GetSingle(id);

                if(product != null)
                {
                    if (productsGV.CurrentCell.ColumnIndex == productsGV.Columns.IndexOf(productsGV.Columns["deleteBtn"]))
                    {
                        product.Delete();
                        ReloadDataGirdView();
                        ClearInputs();
                        ApplyFilters();
                    }
                    else
                    {
                        name.Text = product.Name;
                        minStock.Text = product.MinStock.ToString();
                        description.Text = product.Description;
                        stock.Text = product.InStock.ToString();
                        buyingPrice.Text = product.BuyingPrice.ToString();
                        sellingPrice.Text = product.SellingPrice.ToString();
                        supplierCB.SelectedValue = product.Supplier;
                        categoryCB.SelectedValue = product.Category;

                        if(product.Store != null)
                            storeCB.SelectedValue = product.Store;
                    }

                }

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(ValidInputs())
            {
                Product product = GetProduct();
                product.ID = id;
                product.Edit();

                ReloadDataGirdView();
                ClearInputs();
                ApplyFilters();
            }
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            if(id != null)
            {
                if(!string.IsNullOrEmpty(stockIn.Text))
                {
                    try
                    {
                        int val = int.Parse(stockIn.Text);
                        label2.ForeColor = Color.Silver;

                        Product prod = Product.GetSingle(id);
                        if(prod != null)
                        {
                            prod.InStock += int.Parse(stockIn.Text);
                            prod.Edit();

                            ClearInputs();
                            ReloadDataGirdView();
                            ApplyFilters();
                        }
                        
                    }
                    catch (Exception)
                    {
                        label2.ForeColor = Color.FromArgb(255, 94, 94);
                    }
                    
                }
                else
                {
                    label2.ForeColor = Color.FromArgb(255, 94, 94);
                }
                
            }
            else
            {
                MessageBox.Show("No product selected.", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(id != null)
            {
                Product product = Product.GetSingle(id);
                if(product != null)
                {
                    product.Delete();
                    ClearInputs();
                    ReloadDataGirdView();
                    ApplyFilters();
                }
                
            }
            else
            {
                MessageBox.Show("No product selected.", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ApplyFilters()
        {
            string filter = null;
            string category = null;
            string supplier = null;
            string store = null;

            if (!string.IsNullOrEmpty(searchTB.Text))
                filter = searchTB.Text;

            if (categoryCBS.SelectedIndex != 0 && categoryCBS.SelectedItem != null)
            {
                category = categoryCBS.SelectedItem.ToString();
            }
            if (supplierCBS.SelectedIndex != 0 && supplierCBS.SelectedItem != null)
            {
                supplier = supplierCBS.SelectedItem.ToString();
            }
            if (storeCBS.SelectedIndex != 0 && storeCBS.SelectedItem != null)
            {
                store = storeCBS.SelectedItem.ToString();
            }

            ReloadDataGirdView(filter, category, supplier, store);
        }

        private void searchTB_OnValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void supplierCBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void categoryCBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void export_Click(object sender, EventArgs e)
        {
            productsGV.MultiSelect = true;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Products_" + DateTime.Now.ToString().Replace('/', '_').Replace(':', '_') + ".xls";
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
                xlWorkSheet.Cells[1, 1] = "ID";
                xlWorkSheet.Cells[1, 2] = "Name";
                xlWorkSheet.Cells[1, 3] = "Description";
                xlWorkSheet.Cells[1, 4] = "Category";
                xlWorkSheet.Cells[1, 5] = "Supplier";
                xlWorkSheet.Cells[1, 6] = "Store";
                xlWorkSheet.Cells[1, 7] = "Buying Price";
                xlWorkSheet.Cells[1, 8] = "Selling Price";
                xlWorkSheet.Cells[1, 9] = "In Stock";
                xlWorkSheet.Cells[1, 10] = "Min Stock";


                xlWorkSheet.Columns.AutoFit();
                xlWorkBook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;

                rng = xlWorkSheet.get_Range("K:K").Cells;
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

        private void productsGV_Sorted(object sender, EventArgs e)
        {
            DataGridViewRow row = productsGV.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["id"].Value.ToString().Equals("Total")).First();
            productsGV.Rows.Remove(row);
            productsGV.Rows.Add(row);
        }

        private void storeCBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
