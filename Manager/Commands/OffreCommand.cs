using Serveur;
using Serveur.Entities;

namespace Bll.Commands
{
    class OffreCommand
    {
        private readonly MonContexte _monContexte;

        public OffreCommand(MonContexte monContexte)
        {
            _monContexte = monContexte;
        }

        public int Save(Offre offre)
        {
            _monContexte.Offres.Add(offre);
            return _monContexte.SaveChanges();
        }
    }
}
