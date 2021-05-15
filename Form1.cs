using Gestion_Patrimoine.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Patrimoine
{
    public partial class Form1 : Form
    {
        private bool isAdmin = false;
        private void addToLoginPanel(string user)
        {
            if (user == "admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                loginPanel.Controls.Clear();
                loginPanel.Controls.Add(adminPanel);
                isAdmin = true;
            }
            else if (user == "employee")
            {
                EmployePanel employePanel = new EmployePanel();
                loginPanel.Controls.Clear();
                loginPanel.Controls.Add(employePanel);
                isAdmin = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addToLoginPanel("employee");
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            addToLoginPanel("admin");
        }

        private void employeBtn_Click(object sender, EventArgs e)
        {
            addToLoginPanel("employee");
        }
    }
}
