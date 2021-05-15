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
    public partial class Affectation : Form
    {
        private UserRepository userRepository;
        private PatrimoineRepository patrimoineRepository;
        public Affectation()
        {
            InitializeComponent();
            userRepository = new UserRepository();
            patrimoineRepository = new PatrimoineRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDto userDto = (UserDto) employeeComboBox.SelectedItem;
            PatrimoineDto patrimoineDto = (PatrimoineDto)patrimoineComboBox.SelectedItem;
            int employeeId = userDto.Id;
            int patrimoineId = patrimoineDto.Id;

            AffectationRepository affectationRepository = new AffectationRepository();
            affectationRepository.affecter(patrimoineId, employeeId);
            this.Close();
        }

        private void Affectation_Load(object sender, EventArgs e)
        {
            employeeComboBox.DataSource = userRepository.getAll();
            employeeComboBox.ValueMember = "Id";
            employeeComboBox.DisplayMember = "FirstName";

            patrimoineComboBox.DataSource = patrimoineRepository.GetAll();
            patrimoineComboBox.ValueMember = "Id";
            patrimoineComboBox.DisplayMember = "Nom";
        }
    }
}
