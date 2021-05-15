using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Patrimoine.Dto
{
    public class PatrimoineDto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string DateAchat { get; set; }
        public double Prix { get; set; }
        public int DureeAmortissement { get; set; }
        public int TauxAmortissement { get; set; }
        public double PrixAmortissement { get; set; }
        public int Anciennte { get; set; }
        public string Status { get; set; }
        public CategoryDto Category { get; set; }
        public int EmployeeId { get; set; }
    }
}
