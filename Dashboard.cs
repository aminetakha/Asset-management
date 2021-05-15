using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gestion_Patrimoine.Dto;
using Gestion_Patrimoine.Panels;
using Gestion_Patrimoine.Repositories;

namespace Gestion_Patrimoine
{
    public partial class Dashboard : Form
    {
        private string op = "p";
        private PatrimoineRepository patrimoineRepository;
        private int theId;
        private int index;
        private static PatrimoineDto patrimoine = new PatrimoineDto();
        UserDto user;

        public static PatrimoineDto GetPatrimoine()
        {
            return patrimoine;
        }
        public Dashboard()
        {
            InitializeComponent();
            patrimoineRepository = new PatrimoineRepository();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            UserLoginResponseDto response = AdminPanel.GetResponseDto();
            user = response.User;
            dataGridView.DataSource = patrimoineRepository.GetAll();
            modifierPatrimoineBtn.Enabled = true;
            supprimerPatrimoineBtn.Enabled = true;
        }

        private void patrimoineBtn_Click(object sender, EventArgs e)
        {
            patrimoineBtn.ForeColor = Color.White;
            patrimoineBtn.BackColor = Color.Crimson;

            employeeBtn.ForeColor = Color.Black;
            employeeBtn.BackColor = Color.White;
            employeeBtn.FlatAppearance.BorderSize = 1;
            dataGridView.DataSource = patrimoineRepository.GetAll();
            modifierPatrimoineBtn.Enabled = true;
            supprimerPatrimoineBtn.Enabled = true;
            acceptDemandeBtn.Enabled = false;
            op = "p";
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            patrimoineBtn.ForeColor = Color.Black;
            patrimoineBtn.BackColor = Color.White;
            patrimoineBtn.FlatAppearance.BorderSize = 1;

            employeeBtn.ForeColor = Color.White;
            employeeBtn.BackColor = Color.Crimson;
            UserRepository userRepository = new UserRepository();
            dataGridView.DataSource = userRepository.getAll();
            modifierPatrimoineBtn.Enabled = false;
            supprimerPatrimoineBtn.Enabled = false;
            acceptDemandeBtn.Enabled = false;
            op = "f";
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            modifierPatrimoineBtn.Enabled = false;
            supprimerPatrimoineBtn.Enabled = false;
            acceptDemandeBtn.Enabled = false;
            op = "f";
            Employee employee = new Employee();
            employee.ShowDialog();
        }

        private void demandeAffectationBtn_Click(object sender, EventArgs e)
        {
            AffectationRepository affectationRepository = new AffectationRepository();
            dataGridView.DataSource = affectationRepository.getAll();
            modifierPatrimoineBtn.Enabled = false;
            supprimerPatrimoineBtn.Enabled = false;
            acceptDemandeBtn.Enabled = true;
            op = "d";
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView.CurrentCell.RowIndex;
            theId = Int16.Parse(dataGridView.Rows[index].Cells[0].Value.ToString());
        }

        private void modifierPatrimoineBtn_Click(object sender, EventArgs e)
        {
            patrimoine.Id = theId;
            patrimoine.Nom = dataGridView.Rows[index].Cells["Nom"].Value.ToString();
            patrimoine.Prix = Double.Parse(dataGridView.Rows[index].Cells["Prix"].Value.ToString());
            patrimoine.PrixAmortissement = Double.Parse(dataGridView.Rows[index].Cells["PrixAmortissement"].Value.ToString());
            patrimoine.Status = dataGridView.Rows[index].Cells["Status"].Value.ToString();
            patrimoine.TauxAmortissement = Int16.Parse(dataGridView.Rows[index].Cells["TauxAmortissement"].Value.ToString());
            patrimoine.Anciennte = Int16.Parse(dataGridView.Rows[index].Cells["Anciennte"].Value.ToString());
            patrimoine.DateAchat = dataGridView.Rows[index].Cells["DateAchat"].Value.ToString();
            patrimoine.Description = dataGridView.Rows[index].Cells["Description"].Value.ToString();
            patrimoine.DureeAmortissement = Int16.Parse(dataGridView.Rows[index].Cells["DureeAmortissement"].Value.ToString());
            patrimoine.EmployeeId = Int16.Parse(dataGridView.Rows[index].Cells["EmployeeId"].Value.ToString());

            Modifier_Patrimoine modifierPatrimoine = new Modifier_Patrimoine();
            modifierPatrimoine.ShowDialog();
            this.OnLoad(e);
        }

        private void supprimerPatrimoineBtn_Click(object sender, EventArgs e)
        {
            patrimoineRepository.delete(theId);
            this.OnLoad(e);
        }

        private void acceptDemandeBtn_Click(object sender, EventArgs e)
        {
            int demandeId = Int16.Parse(dataGridView.Rows[index].Cells["DemandeId"].Value.ToString());
            AffectationRepository affectationRepository = new AffectationRepository();
            affectationRepository.acceptDemande(demandeId);
            MessageBox.Show("Demande a été accepté");
            this.demandeAffectationBtn_Click(sender, e);
        }

        private void affectationBtn_Click(object sender, EventArgs e)
        {
            Affectation affectation = new Affectation();
            affectation.ShowDialog();
        }
    }
}
