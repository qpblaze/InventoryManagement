using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ManageStores : Form
    {
        Sales _mainForm;
        public ManageStores(Sales mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ManageStores_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Show();
        }

        private void ReloadDataGirdView()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Files/Stores.xml");
                storesDGV.DataSource = ds;
                storesDGV.DataMember = "Store";

                if (!storesDGV.Columns.Contains("deleteBtn"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    storesDGV.Columns.Add(btn);
                    btn.HeaderText = "Action";
                    btn.Text = "Delete";
                    btn.Name = "deleteBtn";
                    btn.UseColumnTextForButtonValue = true;
                }

            }
            catch (Exception)
            {
                //ignore
            }

        }

        private bool ValidInputs()
        {
            if (string.IsNullOrEmpty(categoryName.Text))
            {
                nameL.ForeColor = Color.FromArgb(255, 94, 94);
                return false;
            }
            else
            {
                nameL.ForeColor = Color.Silver;
                return true;
            }
        }

        string id = null;
        private void add_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                Store store = new Store();
                store.Name = categoryName.Text;
                store.Add();
                categoryName.Text = null;
                id = null;
                ReloadDataGirdView();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                Store store = Store.GetSingle(id);
                store.Name = categoryName.Text;
                store.Edit();

                ReloadDataGirdView();
                categoryName.Text = null;
                id = null;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                Store store = Store.GetSingle(id);
                store.Delete();

                ReloadDataGirdView();
                categoryName.Text = null;
                id = null;
            }
            else
            {
                MessageBox.Show("No category selected.", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void storesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < storesDGV.Rows.Count - 1)
            {
                id = storesDGV.Rows[e.RowIndex].Cells[storesDGV.Columns.IndexOf(storesDGV.Columns["ID"])].Value.ToString();
                Store category = Store.GetSingle(id);

                if (e.ColumnIndex == storesDGV.Columns.IndexOf(storesDGV.Columns["deleteBtn"]))
                {
                    category.Delete();
                    ReloadDataGirdView();
                    categoryName.Text = null;
                    id = null;
                }
                else
                {
                    categoryName.Text = category.Name;
                }
            }
        }

        private void ManageStores_Load(object sender, EventArgs e)
        {

            ReloadDataGirdView();
        }
    }
}
