using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Patrimoine.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public CategoryDto() { }
        public CategoryDto(string nom)
        {
            Nom = nom;
        }
        public CategoryDto(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}
