using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur.Entities
{
    public class Postulation
    {
        public int Id { get; set; }
        public int EmployeId { get; set; }

        public Employe Employe { get; set; }

        public DateTime DatePostulation { get; set; }

        public string Statut { get; set; }

        public int OffreId { get; set; }

        public Offre Offre { get; set; }
    }
}
