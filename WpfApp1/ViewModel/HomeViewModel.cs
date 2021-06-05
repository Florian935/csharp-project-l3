using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModel
{
    public class HomeViewModel : BaseViewModel
       
    {
        private ListeOffreViewModel _listeOffreViewModel = null;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listeOffreViewModel = new ListeOffreViewModel();
        }

        

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit le ListeProduitViewModel
        /// </summary>
        public ListeOffreViewModel ListeOffreViewModel
        {
            get { return _listeOffreViewModel; }
            set { _listeOffreViewModel = value; }
        }

        #endregion
    }
}

