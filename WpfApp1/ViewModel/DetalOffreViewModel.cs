using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModel
{
    public class DetalOffreViewModel { 
        private String _title;
    private String _responsable;
        private float _salaire;
    private RelayCommand _addOperation;

    
        public DetalOffreViewModel(Offre o)
        {
            _title = o.Intitule;
            _responsable = o.Responsable;
            _salaire = o.Salaire;
        }
        public String Title
        {
            get { return _title; }
            set { _title = value; }
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


        public ICommand AddOperation
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                return _addOperation;
            }
        }

        /// <summary>
        /// Permet l'ouverture de la fenêtre
        /// </summary>
        private void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }

    }
}
