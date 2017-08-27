using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Globalization;

namespace InventoryManagement
{
    public partial class Sales : Form
    {
        LogIn logForm;
        public Sales(LogIn _log)
        {
            InitializeComponent();
            logForm = _log;
            productsGV.MultiSelect = false;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            ReloadDataGirdView();
            List<Category> categories = Category.GetAll();
            List<Supplier> suppliers = Supplier.GetAll();
            List<Store> stores = Store.GetAll();

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
        }

        public void ReloadDataGirdView(string filter = null, string category = null, string supplier = null, string store = null)
        {
            productsGV.Rows.Clear();

            if(!productsGV.Columns.Contains("id"))
            {
                productsGV.Columns.Add("id", "ID");
                productsGV.Columns.Add("name", "Name");
                productsGV.Columns.Add("description", "Description");
                productsGV.Columns.Add("category", "Category");
                productsGV.Columns.Add("supplier", "Supplier");
                productsGV.Columns.Add("store", "Store");
                productsGV.Columns.Add("sellPrice", "Price");
                productsGV.Columns.Add("buyPrice", "Buying Price");
                productsGV.Columns.Add("inStock", "In Stock");
            }

            List<Product> products = Product.GetAll();

            if (filter != null)
                products = products.Where(p => p.Name.ToLower().Contains(filter.ToLower()) || p.ID.ToLower().Contains(filter.ToLower()) || p.Description.ToLower().Contains(filter.ToLower())).ToList();
            if (category != null)
                products = products.Where(p => p.Category.ToLower().Equals(category.ToLower())).ToList();
            if(supplier != null)
                products = products.Where(p => p.Supplier.ToLower().Equals(supplier.ToLower())).ToList();
            if (store != null)
                products = products.Where(p => p.Store != null && p.Store.ToLower().Equals(store.ToLower())).ToList();


            int i = 0;
            foreach(Product prod in products)
            {
                double sellPrice;
                double.TryParse(prod.SellingPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out sellPrice);

                double buyPrice;
                double.TryParse(prod.BuyingPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out buyPrice);

                productsGV.Rows.Add(new object[] { int.Parse(prod.ID), prod.Name, prod.Description, prod.Category, prod.Supplier, prod.Store, sellPrice, buyPrice, prod.InStock});

                if (prod.InStock < prod.MinStock && prod.InStock != 0)
                    productsGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 94, 94);
                if (prod.InStock == prod.MinStock)
                    productsGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 102);
                if (prod.InStock > prod.MinStock + 5)
                    productsGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(74, 229, 74);
                if (prod.InStock == 0)
                {
                    productsGV.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    productsGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
                }

                i++;
            }

            if (!productsGV.Columns.Contains("sellBtn"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                productsGV.Columns.Add(btn);
                btn.HeaderText = "Action";
                btn.Text = "Sell";
                btn.Name = "sellBtn";
                btn.UseColumnTextForButtonValue = true;

                productsGV.Columns.Add("SellTo", "Sell To");
                productsGV.Columns.Add("CustomSellPrice", "Sell Price");
                
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProducts manageProductsForm = new ManageProducts(this);
            
            manageProductsForm.Show();
            this.Hide();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategories manageCategoriesForm = new ManageCategories(this);
         
            manageCategoriesForm.Show();
            this.Hide();
        }

        private void salesAndProfitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SalesAndProfit salesAndProfitForm = new SalesAndProfit(this);
            
            salesAndProfitForm.Show();
            this.Hide();
        }

        string id = null;
        private void productsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if(productsGV.CurrentCell.ColumnIndex == productsGV.Columns.IndexOf(productsGV.Columns["sellBtn"]))
                {
                    id = productsGV.Rows[productsGV.CurrentCell.RowIndex].Cells[productsGV.Columns.IndexOf(productsGV.Columns["id"])].Value.ToString();
                    Product product = Product.GetSingle(id);

                    if (product.InStock > 0)
                    {
                        string sellPrice = null;
                        string soldTo = null;

                        bool ok = true;

                        if (productsGV.Rows[productsGV.CurrentCell.RowIndex].Cells["CustomSellPrice"].Value != null)
                        {
                            sellPrice = productsGV.Rows[productsGV.CurrentCell.RowIndex].Cells["CustomSellPrice"].Value.ToString().Replace(',', '.');

                            double customPrice;
                           
                            if (!double.TryParse(sellPrice.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out customPrice))
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            sellPrice = product.SellingPrice.ToString();
                        }

                        if (productsGV.Rows[productsGV.CurrentCell.RowIndex].Cells["SellTo"].Value != null)
                            soldTo = productsGV.Rows[productsGV.CurrentCell.RowIndex].Cells["SellTo"].Value.ToString();

                        if(ok == true)
                        {
                            Sale sale = new Sale();

                            sale.Date = DateTime.Now;
                            sale.SoldWith = sellPrice;
                            sale.SoldTo = soldTo;
                            sale.Product = product;

                            sale.Add();

                            product.InStock--;
                            product.Edit();

                            ReloadDataGirdView();
                            ApplyFilters();
                        }
                        else
                        {
                            MessageBox.Show("The sell price is not a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("This product is not in stock.", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSuppliers manageSuppliersForm = new ManageSuppliers(this);

            manageSuppliersForm.Show();
            this.Hide();
        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            //{
            //    if(dialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string savePath = dialog.SelectedPath + @"\Backup_" + DateTime.Now.ToString() + ".zip";
            //        MessageBox.Show(savePath);
            //        ZipFile.CreateFromDirectory("Files", savePath, CompressionLevel.Fastest, true);
            //    }
            //}
                
        }

        private void ApplyFilters()
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

            ReloadDataGirdView(filter, category, supplier, store);
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

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            logForm.Close();
        }

        private void additionalCostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdditionalCosts costsForm = new AdditionalCosts(this);
            costsForm.Show();
            this.Hide();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ManageStores stores = new ManageStores(this);
                stores.Show();
                this.Hide();
            
        }

        private void storeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
