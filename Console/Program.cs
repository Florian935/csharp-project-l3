using Serveur;
using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MonContexte MonContexte = new MonContexte();
                List<Offre> offres = MonContexte.Offres.ToList();
            } catch (Exception ex)
            {
                throw;
            }
        }
    }
}
