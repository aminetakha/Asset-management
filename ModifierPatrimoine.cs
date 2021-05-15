using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gestion_Patrimoine.Dto;
using Gestion_Patrimoine.Repositories;

namespace Gestion_Patrimoine
{
    public partial class Modifier_Patrimoine : Form
    {
        private PatrimoineDto patrimoine;
        private int theId;
        public Modifier_Patrimoine()
        {
            InitializeComponent();
            patrimoine = Dashboard.GetPatrimoine();
            theId = patrimoine.Id;
            nomBox.Text = patrimoine.Nom.Trim();
            prixBox.Text = patrimoine.Prix.ToString().Trim();
            prixAmortissementBox.Text = patrimoine.PrixAmortissement.ToString().Trim();
            statusBox.Text = patrimoine.Status.Trim();
            tauxAmortissementBox.Text = patrimoine.TauxAmortissement.ToString().Trim();
            descriptionBox.Text = patrimoine.Description.Trim();
            anciennteBox.Text = patrimoine.Anciennte.ToString().Trim();
            dateAchatBox.Text = patrimoine.DateAchat.Trim();
            dureeAmortissement.Text = patrimoine.DureeAmortissement.ToString().Trim();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modifier_Patrimoine_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatrimoineDto patrimoine = new PatrimoineDto
            {
                Id = theId,
                Nom = nomBox.Text,
                Prix = Double.Parse(prixBox.Text),
                PrixAmortissement = Int16.Parse(prixAmortissementBox.Text),
                Status = statusBox.Text,
                TauxAmortissement = Int16.Parse(tauxAmortissementBox.Text),
                Description = descriptionBox.Text,
                Anciennte = Int16.Parse(anciennteBox.Text),
                DateAchat = dateAchatBox.Text,
                DureeAmortissement = Int16.Parse(dureeAmortissement.Text)
            };

            PatrimoineRepository patrimoineRepository = new PatrimoineRepository();
            patrimoineRepository.update(patrimoine);
            this.Close();            
        }
    }
}
