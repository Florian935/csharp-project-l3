using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PostulationViewModel
    {
        public int EmployeId { get; set; }

        public EmployeViewModel Employe { get; set; }

        public DateTime DatePostulation { get; set; }

        public string Statut { get; set; }

        public int OffreId { get; set; }

        public OffreViewModel Offre { get; set; }
    }
}