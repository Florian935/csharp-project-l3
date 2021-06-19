using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class StatutViewModel
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public ICollection<OffreViewModel> Offres { get; set; }
    }
}