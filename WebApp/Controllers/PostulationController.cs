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
    public class PostulationController : Controller
    {
        // GET: Postulation
        public ActionResult Index()
        {
            List<Postulation> postulations = Manager.Instance.GetPostulations();
            List<PostulationViewModel> postulationsView = new List<PostulationViewModel>();
            foreach(Postulation postulation in postulations)
            {
                PostulationViewModel viewModel = new PostulationViewModel();
                viewModel.Id = postulation.Id;
                viewModel.OffreId = postulation.OffreId;
                viewModel.DatePostulation = postulation.DatePostulation;
                viewModel.EmployeId = postulation.EmployeId;
                postulationsView.Add(viewModel);
            }
            return View(postulationsView);
        }

        public ActionResult AddPostulation(int offreId)
        {
            Manager.Instance.AddPostulation(offreId);
            return View();
        }
    }
}