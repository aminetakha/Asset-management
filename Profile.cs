using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gestion_Patrimoine.Dto;
using Gestion_Patrimoine.Repositories;
using Gestion_Patrimoine.Panels;

namespace Gestion_Patrimoine
{
    public partial class Profile : Form
    {
        private static UserDto user;
        private PatrimoineRepository patrimoineRepository;
        int index;
        int theId;
        public Profile()
        {
            InitializeComponent();
            UserLoginResponseDto response = EmployePanel.GetResponseDto();
            user = response.User;
            patrimoineRepository = new PatrimoineRepository();
        }

        public static UserDto GetUser()
        {
            return user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            demanderPatrimoineBtn.Enabled = false;
            patrimoineGridView.DataSource = patrimoineRepository.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;

            patrimoineBtn.BackColor = Color.White;
            patrimoineBtn.ForeColor = Color.Black;
            patrimoineBtn.FlatAppearance.BorderSize = 1;

            UpdateProfile updateProfile = new UpdateProfile();
            updateProfile.ShowDialog();
        }

        private void patrimoineBtn_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.FlatAppearance.BorderSize = 1;

            patrimoineBtn.BackColor = Color.Crimson;
            patrimoineBtn.ForeColor = Color.White;
            patrimoineBtn.FlatAppearance.BorderSize = 0;

            patrimoineGridView.DataSource = patrimoineRepository.GetAll();
        }

        private void patrimoineGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = patrimoineGridView.CurrentCell.RowIndex;
            theId = Int16.Parse(patrimoineGridView.Rows[index].Cells[0].Value.ToString());
            demanderPatrimoineBtn.Enabled = true;
        }

        private void demanderPatrimoineBtn_Click(object sender, EventArgs e)
        {
            AffectationRepository affectationRepository = new AffectationRepository();
            affectationRepository.demandeAffectation(theId, user.Id);
            MessageBox.Show("Demand a été effectué");
        }
    }
}
