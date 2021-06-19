using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class OffreViewModel
    {
        public int Id { get; set; }

        public string Intitule { get; set; }

        public DateTime DateParution { get; set; }

        public string Description { get; set; }

        public float Salaire { get; set; }

        public string Responsable { get; set; }

        public int StatutId { get; set; }

        public StatutViewModel Statut { get; set; }

        public ICollection<PostulationViewModel> Postulations { get; set; }
    }
}