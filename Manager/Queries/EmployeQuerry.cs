using Serveur;
using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Query
{
    public class EmployeQuerry
    {
        private MonContexte _monContexte;

        public EmployeQuerry(MonContexte monContexte)
        {
            _monContexte = monContexte;
        }

        public IQueryable<Employe> GetEmploye()
        {
            return _monContexte.Employes;
        }
    }
}
