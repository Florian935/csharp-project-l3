using Bll.Query;
using Serveur;
using Serveur.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bll
{
    public class Manager
    {
        private static Manager _instance;
        private readonly MonContexte _monContexte;
        private readonly OffreQuery _offreQuery;

        private Manager()
        {
            _monContexte = new MonContexte();
            _offreQuery = new OffreQuery(_monContexte);
        }

        public static Manager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Manager();
                }
                return _instance;
            }
                
        }

        public List<Offre> GetAll()
        {
            return _offreQuery.GetOffres().ToList();
        }
    }
}
