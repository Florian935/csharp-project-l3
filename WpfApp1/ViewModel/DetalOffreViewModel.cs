using Bll;
using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModel
{
    public class DetalOffreViewModel: BaseViewModel {
       
        private string _intitule;
        private string _responsable;
        private float _salaire;
        private DateTime _date;
        private string _description;
        private RelayCommand _addOffre;
        private RelayCommand _modifyOffre;
        private Offre _selectedOffre;


        public DetalOffreViewModel(Offre o)
        {
            _intitule = o.Intitule;
            _responsable = o.Responsable;
            _salaire = o.Salaire;
            _date = o.DateParution;
            _description = o.Description;
            _selectedOffre = o;
        }
        public string Intitule
        {
            get { return _intitule; }
            set { _intitule = value; }
        }
        public String Responsable
        {
            get { return _responsable; }
            set { _responsable = value; }
        }
        public float Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public ICommand AddOffre
        {
            get
            {
                if (_addOffre == null)
                    _addOffre = new RelayCommand(() => RegisterOffreBDD());
                return _addOffre;
            }
        }

        private void RegisterOffreBDD()
        {
            Manager.Instance.Save(new Offre
            {
                DateParution = _date,
                Description = _description,
                Intitule = _intitule,
                Salaire = _salaire,
                Responsable = _responsable,
                Statut = new Statut { Libelle = "A pourvoir" }
            });
        }

        public ICommand ModifyOffre
        {
            get
            {
                if (_modifyOffre == null)
                {
                    _modifyOffre = new RelayCommand(() => this.ModifyOffreBDD());
                }
                return _modifyOffre;
            }
        }

        private void ModifyOffreBDD()
        {
            _selectedOffre.Intitule = _intitule;
            _selectedOffre.Responsable = _responsable;
            _selectedOffre.Salaire = _salaire;
            _selectedOffre.Description = _description;
            _selectedOffre.DateParution = _date;

            Manager.Instance.ModifyOffre(_selectedOffre);
        }
    }
}
