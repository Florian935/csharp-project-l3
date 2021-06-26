using Serveur;
using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Query
{
  public  class PostulationQuerry
    {
        private MonContexte _monContexte;

        public PostulationQuerry(MonContexte monContexte)
        {
            _monContexte = monContexte;
        }

        public IQueryable<Postulation> GetPostulations()
        {
            return _monContexte.Postulations;
        }

    }
}
