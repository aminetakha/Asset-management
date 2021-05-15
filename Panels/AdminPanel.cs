using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Gestion_Patrimoine.Dto;
using System.Windows.Forms;
using Gestion_Patrimoine.Repositories;

namespace Gestion_Patrimoine.Panels
{
    public partial class AdminPanel : UserControl
    {
        private static UserLoginResponseDto response;
        public AdminPanel()
        {
            InitializeComponent();
        }

        public static UserLoginResponseDto GetResponseDto()
        {
            return response;
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passwordBox.Text;
            
            UserLoginDto userLoginDto = new UserLoginDto(email, password);
            UserRepository userRepository = new UserRepository();
            response = userRepository.findUser(userLoginDto, "admin");
            
            if (response.DoesExist)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Email ou mot de pass est incorrect");
            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
