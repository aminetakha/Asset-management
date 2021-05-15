using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gestion_Patrimoine.Repositories;
using Gestion_Patrimoine.Dto;

namespace Gestion_Patrimoine
{
    public partial class UpdateProfile : Form
    {
        private int theId;
        public UpdateProfile()
        {
            InitializeComponent();
            firstnameBox.Text = Profile.GetUser().FirstName.Trim();
            lastnameBox.Text = Profile.GetUser().LastName.Trim();
            ageBox.Text = Profile.GetUser().Age.ToString();
            theId = Profile.GetUser().Id;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            UserDto user = new UserDto
            {
                Id = theId,
                FirstName = firstnameBox.Text.Trim(),
                LastName = lastnameBox.Text.Trim(),
                Age = Int16.Parse(ageBox.Text)
            };
            userRepository.update(user);
            MessageBox.Show("Profile a été modifié");
            this.Close();
        }
    }
}
