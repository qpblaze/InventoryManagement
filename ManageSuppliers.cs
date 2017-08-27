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
    public partial class ManageSuppliers : Form
    {
        Sales mainForm;
        public ManageSuppliers(Sales _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void ManageSuppliers_Load(object sender, EventArgs e)
        {
            ReloadDataGirdView();
        }

        private void ReloadDataGirdView()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Files/Suppliers.xml");
                suppliersDGV.DataSource = ds;
                suppliersDGV.DataMember = "Supplier";

                if (!suppliersDGV.Columns.Contains("deleteBtn"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    suppliersDGV.Columns.Add(btn);
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

        string id = null;
        private void suppliersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < suppliersDGV.Rows.Count - 1)
            {
                id = suppliersDGV.Rows[e.RowIndex].Cells[suppliersDGV.Columns.IndexOf(suppliersDGV.Columns["ID"])].Value.ToString();
                Supplier supplier = Supplier.GetSingle(id);

                if (e.ColumnIndex == suppliersDGV.Columns.IndexOf(suppliersDGV.Columns["deleteBtn"]))
                {
                    supplier.Delete();
                    ReloadDataGirdView();
                    nameTB.Text = null;
                    id = null;
                }
                else
                {
                    nameTB.Text = supplier.Name;
                }
            }
        }

        private void ManageSuppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private bool ValidInputs()
        {
            if (string.IsNullOrEmpty(nameTB.Text))
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
            if (ValidInputs())
            {
                Supplier supplier = new Supplier();
                supplier.Name = nameTB.Text;
                supplier.Add();
                nameTB.Text = null;
                id = null;
                ReloadDataGirdView();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                Supplier supplier = Supplier.GetSingle(id);
                supplier.Name = nameTB.Text;
                supplier.Edit();

                ReloadDataGirdView();
                nameTB.Text = null;
                id = null;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(id != null)
            {
                Supplier sup = Supplier.GetSingle(id);
                sup.Delete();

                ReloadDataGirdView();
                nameTB.Text = null;
                id = null;
            }
            else
            {
                MessageBox.Show("No supplier selected.", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
