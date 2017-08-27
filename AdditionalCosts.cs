using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class AdditionalCosts : Form
    {
        Sales mainForm;
        string id;
        public AdditionalCosts(Sales _main)
        {
            InitializeComponent();
            mainForm = _main;
        }

        private void AdditionalCosts_Load(object sender, EventArgs e)
        {
            ReloadDataGirdView();
            dayCB.SelectedIndex = 0;
            monthCB.SelectedIndex = 0;
            yearCB.SelectedIndex = 0;
        }

        private void GetTotalCost()
        {
            double totalSpent = 0.0;
            foreach(Cost cost in Cost.GetAll())
            {
                double inv;
                double.TryParse(cost.Price.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out inv);
                totalSpent += inv;
            }

            totalL.Text = totalSpent.ToString();
        }

        private void AdditionalCosts_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void ClearInputs()
        {
            infoTB.Text = "";
            costTB.Text = "";
            id = null;
        }

        private void ReloadDataGirdView(int day = 0, int month = 0, int year = 0)
        {
            costsDGV.Rows.Clear();
            GetTotalCost();
            if (!costsDGV.Columns.Contains("id"))
            {
                costsDGV.Columns.Add("id", "Cost ID");
                costsDGV.Columns.Add("date", "Date");
                costsDGV.Columns.Add("info", "Info");
                costsDGV.Columns.Add("price", "Price");
            }

            List<Cost> costs = Cost.GetAll();

            if (day != 0)
                costs = costs.Where(c => c.Date.Day == day).ToList();
            if (month != 0)
                costs = costs.Where(c => c.Date.Month == month).ToList();
            if (year != 0)
                costs = costs.Where(c => c.Date.Year == year).ToList();

            double totalSpent = 0.0;
           
            foreach (Cost c in costs)
            {
                double inv;
                double.TryParse(c.Price.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out inv);
                totalSpent += inv;
                costsDGV.Rows.Add(new object[] { c.ID, c.Date, c.Info, c.Price});
            }
            costsDGV.Rows.Add(new object[] { "Total", null, null,totalSpent });


            if (!costsDGV.Columns.Contains("deleteBtn"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                costsDGV.Columns.Add(btn);
                btn.HeaderText = "Action";
                btn.Text = "Delete";
                btn.Name = "deleteBtn";
                btn.UseColumnTextForButtonValue = true;
            }
            

        }

        private bool ValidInputs()
        {
            bool error = false;
            if (string.IsNullOrEmpty(infoTB.Text))
            {
                infoL.ForeColor = Color.FromArgb(255, 94, 94);
                error = true;
            }
            else
            {
                infoL.ForeColor = Color.Silver;
            }

            if (string.IsNullOrEmpty(costTB.Text))
            {
                costL.ForeColor = Color.FromArgb(255, 94, 94);
            }
            else
            {
                try
                {
                    double val = double.Parse(costTB.Text.Replace(',', '.'));
                    costL.ForeColor = Color.Silver;
                }
                catch (Exception)
                {
                    costL.ForeColor = Color.FromArgb(255, 94, 94);
                    error = true;
                }
            }

            return !error;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                Cost cost = new Cost();
                cost.Info = infoTB.Text;
                cost.Price = costTB.Text;
                cost.Date = DateTime.Now;
                cost.Add();

                ClearInputs();
                ReloadDataGirdView();
            }
        }

        private void DeleteCost()
        {
            if(id != null)
            {
                Cost cost = Cost.GetSingle(id);
                if(cost != null)
                {
                    cost.Delete();
                    ClearInputs();
                    ReloadDataGirdView();
                }
            }
            else
            {
                MessageBox.Show("No cost selected.", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteCost();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(id != null)
            {
                if (ValidInputs())
                {
                    Cost cost = Cost.GetSingle(id);
                    cost.Info = infoTB.Text;
                    cost.Price = costTB.Text;
                    cost.Edit();

                    ClearInputs();
                    ReloadDataGirdView();
                }
            }
            else
            {
                MessageBox.Show("No cost selected.", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void categoriesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < costsDGV.Rows.Count - 2)
            {
                
                id = costsDGV.Rows[e.RowIndex].Cells[costsDGV.Columns.IndexOf(costsDGV.Columns["ID"])].Value.ToString();
                Cost cost = Cost.GetSingle(id);

                if (e.ColumnIndex == costsDGV.Columns.IndexOf(costsDGV.Columns["deleteBtn"]))
                {
                    cost.Delete();
                    ClearInputs();
                    ReloadDataGirdView();
                }
                else
                {
                    infoTB.Text = cost.Info;
                    costTB.Text = cost.Price;
                }
            }
        }

        private void dayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyDate();
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
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
                ReloadDataGirdView(day, month, year);
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
    }
}
