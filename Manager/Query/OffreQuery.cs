using Serveur;
using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Query
{
    public class OffreQuery
    {
        private MonContexte _monContexte;

        public OffreQuery(MonContexte monContexte)
        {
            _monContexte = monContexte;
        }

        public IQueryable<Offre> GetOffres()
        {
            return _monContexte.Offres;
        }
    }
}
