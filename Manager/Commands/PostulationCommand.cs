using Serveur;
using Serveur.Entities;

namespace Bll.Commands
{
    class PostulationCommand
    {
        private readonly MonContexte _monContexte;

        public PostulationCommand(MonContexte monContexte)
        {
            _monContexte = monContexte;
        }

        public int Save(Postulation postulation)
        {
            _monContexte.Postulations.Add(postulation);
            return _monContexte.SaveChanges();
        }
        public void addPostulation(Postulation postulation)
        {
            _monContexte.Postulations.Add(postulation);
            _monContexte.SaveChanges();
        }
    }
}
