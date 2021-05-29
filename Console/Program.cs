using System;
using Bll;

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
                manager.GetOffres();
            } catch (Exception ex)
            {
                throw;
            }
        }
    }

    // Créer Bibliothèque de classe .Net (.Net Framework)
    // Ajouter EF + références vers projet
    // Ajouter Manager.cs -> Singleton -> Constructor privé -> Créer méthode public Manager Instance() { get { if(instance == null) new Instance() else {return _instance;} }
    // + créer private static Manager _instance;
}   // Dans Main.cs du projet Console:
    // Manager manager = Manager.GetInstance;
    // Dans le constructor du Manager: 
    // private MonContexte _contexte = new Contexte();
    // Créer des méthodes dans le Manager ensuite:
    // Ex: public List<Offre> GetOffres() { return _contexte.Offres.ToList() }
    //
    // Puis dans Main.cs dans Console project:
    // manager.GetOffres();

    // Pattern Query - Command:
    // Créer une classe OffreQuery:
    // Constructor: public OffreQuery(MonContexte monContexte() {
    //      _monContexte = monContexte;
    // }
    // Une méthode: GetOffres() {
    //  return _monContexte.Offres.ToList();
    //
    //
    // }
    // Puis dans le Manager dans GetOffres (à renommer en GetAll):
    // return new OffreQuery(_contexte).GetOffres;
    // Le mieux encore: mettre une IQueryable dans le QueryOffre et le Manager
    // s'occupe d'appeler les méthodes nécessaires sur le IQueryable (par ex: ToList())


    // Pour test unitaire:
    // Nouveau projet -> Projet de testunitaire (.Net Framework)
    // Dans les références: rajouter une référence vers le BLL et ClassLibrary) + ajouter EF
    // Dans AppConfig: reprendre la connection String pour utiliser la BDD.
    // Manager manager = Manager.GetInstance();
    // var offres = manager.GetAll();
    // Tester Assert.IsNotNull(offres) par exemple.
