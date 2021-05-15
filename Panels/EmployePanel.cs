using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gestion_Patrimoine.Dto;
using Gestion_Patrimoine.Repositories;

namespace Gestion_Patrimoine.Panels
{
    public partial class EmployePanel : UserControl
    {
        private static UserLoginResponseDto response;
        public EmployePanel()
        {
            InitializeComponent();
        }

        public static UserLoginResponseDto GetResponseDto()
        {
            return response;
        }

        private void employeeLoginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passwordBox.Text;

            UserLoginDto userLoginDto = new UserLoginDto(email, password);
            UserRepository userRepository = new UserRepository();
            response = userRepository.findUser(userLoginDto, "employee");

            if (response.DoesExist)
            {
                Profile profile = new Profile();
                profile.Show();
            }
            else
            {
                MessageBox.Show("Email ou mot de pass est incorrect");
            }
        }
    }
}
