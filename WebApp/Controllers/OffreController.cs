using Bll;
using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class OffreController : Controller
    {
        public ActionResult Index()
        {
            List<Offre> offres = Manager.Instance.GetAll();
            List<OffreViewModel> offresViewModels = new List<OffreViewModel>();

            foreach(Offre offre in offres)
            {
                offresViewModels.Add(new OffreViewModel
                { 
                    Id = offre.Id,
                    Intitule = offre.Intitule,
                    DateParution = offre.DateParution,
                    Description = offre.Description,
                    Salaire = offre.Salaire,
                    Responsable = offre.Responsable,
                });
            }
            return View(offresViewModels);
        }

        public ActionResult Detail(int id)
        {
            Offre offre = Manager.Instance.GetById(id);
            OffreViewModel offreViewModel = new OffreViewModel
            {
                Id = offre.Id,
                Intitule = offre.Intitule,
                DateParution = offre.DateParution,
                Description = offre.Description,
                Salaire = offre.Salaire,
                Responsable = offre.Responsable
            };

            return View(offreViewModel);
        }
    }
}