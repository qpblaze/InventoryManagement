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
    public partial class ManageCategories : Form
    {
        Sales mainForm;
        public ManageCategories(Sales _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void ManageCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            ReloadDataGirdView();
        }

        private void ReloadDataGirdView()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Files/Categories.xml");
                categoriesDGV.DataSource = ds;
                categoriesDGV.DataMember = "Category";

                if (!categoriesDGV.Columns.Contains("deleteBtn"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    categoriesDGV.Columns.Add(btn);
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
            if(string.IsNullOrEmpty(categoryName.Text))
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

        private void add_Click(object sender, EventArgs e)
        {
            if(ValidInputs())
            {
                Category category = new Category();
                category.Name = categoryName.Text;
                category.Add();
                categoryName.Text = null;
                id = null;
                ReloadDataGirdView();
            }
        }

        string id = null;
        private void categoriesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < categoriesDGV.Rows.Count - 1)
            {
                id = categoriesDGV.Rows[e.RowIndex].Cells[categoriesDGV.Columns.IndexOf(categoriesDGV.Columns["ID"])].Value.ToString();
                Category category = Category.GetSingle(id);

                if(e.ColumnIndex == categoriesDGV.Columns.IndexOf(categoriesDGV.Columns["deleteBtn"]))
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

        private void edit_Click(object sender, EventArgs e)
        {
            if(ValidInputs())
            {
                Category category = Category.GetSingle(id);
                category.Name = categoryName.Text;
                category.Edit();

                ReloadDataGirdView();
                categoryName.Text = null;
                id = null;
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                Category cat = Category.GetSingle(id);
                cat.Delete();

                ReloadDataGirdView();
                categoryName.Text = null;
                id = null;
            }
            else
            {
                MessageBox.Show("No category selected.", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
