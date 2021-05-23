using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur.Entities
{
    public class Offre
    {
        public int Id { get; set; }

        public string Intitule { get; set; }

        public DateTime DateParution { get; set; }

        public string Description { get; set; }

        public float Salaire { get; set; }

        public string Responsable { get; set; }

        public int StatutId { get; set; }


        public ICollection<Postulation> Postulations { get; set; }
    }
}
