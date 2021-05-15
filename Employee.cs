using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gestion_Patrimoine.Repositories;

namespace Gestion_Patrimoine
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string firstName = fnameBox.Text;
            string lastName = lnameBox.Text;
            int age = Int16.Parse(ageBox.Text);
            UserRepository userRepository = new UserRepository();
            userRepository.save(email, password, firstName, lastName, age);
            this.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
