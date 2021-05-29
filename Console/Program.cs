using Bll;
using Serveur.Entities;
using System;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // MonContexte MonContexte = new MonContexte();
                // List<Offre> offres = MonContexte.Offres.ToList();

                Manager manager = Manager.Instance;
                manager.GetAll();

                Statut statut = new Statut
                {
                    Libelle = "libelle"
                };
                Offre offre = new Offre
                {
                    DateParution = new DateTime(2020, 05, 29),
                    Description = "Description",
                    Intitule = "Une offre",
                    Salaire = 1200,
                    Responsable = "Le responsable",

                    Statut = statut
                };
                manager.Save(offre);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

    // Créer une application WPF
    // Créer dossier ViewModels, Views
    // Dans fichier MainWindow.xaml -> rajouter les namespaces en haut du fichier
