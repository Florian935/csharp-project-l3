using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.ViewModel;
using Serveur.Entities;

namespace WpfApp1.Views
{
    public partial class AddOffre : Window
    {
        public AddOffre()
        {
            InitializeComponent();
            this.DataContext = new DetalOffreViewModel(new Offre());
        }
    }
}
