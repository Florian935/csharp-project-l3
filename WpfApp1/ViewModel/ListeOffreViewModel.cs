using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModel
{
   public class ListeOffreViewModel : BaseViewModel
    {
        private ObservableCollection<DetalOffreViewModel> _offres = null;
        private DetalOffreViewModel _selectedOffre;

        public ListeOffreViewModel()
        {
            _offres = new ObservableCollection<DetalOffreViewModel>();
            foreach(Offre o in Bll.Manager.Instance.GetAll())
            {
                _offres.Add(new DetalOffreViewModel(o));
            }
            if(_offres!= null && _offres.Count > 0)
            {
                _selectedOffre = _offres.ElementAt(0);
            }

        }
        public ObservableCollection<DetalOffreViewModel> Offres
        {
            get { return _offres; }
            set {
                _offres = value;
                  OnPropertyChanged("Offres");
                    }
        }

        public DetalOffreViewModel SelectedOffre
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedOffre");
            }
        }
    }
}
