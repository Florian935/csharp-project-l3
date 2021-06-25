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

        private Manager()
        {
            _monContexte = new MonContexte();
            _offreQuery = new OffreQuery(_monContexte);
            _offreCommand = new OffreCommand(_monContexte);
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
    }
}
