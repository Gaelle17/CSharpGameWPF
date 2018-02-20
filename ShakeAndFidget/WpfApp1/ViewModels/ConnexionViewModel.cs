using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class ConnexionViewModel
    {
        private Connexion connexion;

        public ConnexionViewModel(Connexion connexion)
        {
            this.connexion = connexion;
        }
    }
}
