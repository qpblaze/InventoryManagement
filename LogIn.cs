using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            LogInF();
        }

        private void LogInF()
        {
            string pass = File.ReadAllText("data.txt");
            if(pass != password.Text)
            {
                MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
            }
            else
            {
                Sales salesForm = new Sales(this);
                salesForm.Show();
                this.Hide();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LogInF();
            }
        }
    }
}
