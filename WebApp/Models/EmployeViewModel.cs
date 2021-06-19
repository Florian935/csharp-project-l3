using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class EmployeViewModel
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public int Anciennete { get; set; }

        public string Biographie { get; set; }

        public ICollection<PostulationViewModel> Postulations { get; set; }

        public ICollection<FormationViewModel> Formations { get; set; }

        public ICollection<ExperienceViewModel> Experiences { get; set; }


    }
}