using Bll.Commands;
using Bll.Query;
using Serveur;
using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll
{
    public class Manager
    {
        private static Manager _instance;
        private readonly MonContexte _monContexte;
        private readonly OffreQuery _offreQuery;
        private readonly OffreCommand _offreCommand;
        private readonly PostulationCommand _postulationCommand;
        private readonly PostulationQuerry _postulationQuery;
        private readonly EmployeQuerry _employeQuery;


        private Manager()
        {
            _monContexte = new MonContexte();
            _offreQuery = new OffreQuery(_monContexte);
            _postulationQuery = new PostulationQuerry(_monContexte);
            _postulationCommand = new PostulationCommand(_monContexte);
            _offreCommand = new OffreCommand(_monContexte);
            _employeQuery = new EmployeQuerry(_monContexte);
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

      

        public Offre GetById(int id)
        {
            return _offreQuery.GetOffres().Where(o => o.Id == id).FirstOrDefault();
        }

        public int Save(Offre offre)
        {
            return _offreCommand.Save(offre);
        }
        public List<Offre> getOffresByTitle(string search)
        {
            return _offreQuery.GetOffres().Where(o => o.Intitule.Contains(search)).ToList();
        }

        public void ModifyOffre(Offre o)
        {
            Offre offre = _monContexte.Offres.Where(of => of.Id == o.Id).FirstOrDefault();

            try
            {
                if (offre != null)
                {
                    offre.Intitule = o.Intitule;
                    offre.Salaire = o.Salaire;
                    offre.Responsable = o.Responsable;
                    offre.Description = o.Description;
                    offre.Statut = o.Statut;
                    offre.DateParution = o.DateParution;
                    offre.Responsable = o.Responsable;

                }
                _monContexte.SaveChanges();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            
        }
        public List<Postulation> GetPostulations()
        {
            return _postulationQuery.GetPostulations().ToList();
        }
        public List<Postulation> GetPostulationsByUser()
        {
            return _postulationQuery.GetPostulations().Where(p => p.EmployeId.Equals(3)).ToList();
        }
        public Employe GetEmploye()
        {
            return _employeQuery.GetEmploye().Where(e => e.Id.Equals(3)).FirstOrDefault();

        }
        public void AddPostulation(int id)
        {
            Postulation postulation = new Postulation();
            postulation.DatePostulation = DateTime.Now;
            postulation.OffreId = id;
            postulation.EmployeId = 3;
            postulation.Statut = "En cours";
            _postulationCommand.addPostulation(postulation);
            
        }
    }
}
