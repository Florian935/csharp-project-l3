using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class FormationViewModel
    {
        public int Id { get; set; }

        public int EmployeId { get; set; }

        public EmployeViewModel Employe { get; set; }

        public string Intitule { get; set; }

        public DateTime DateFormation { get; set; }
    }
}