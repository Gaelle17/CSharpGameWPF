using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class HeroProfilViewModel
    {
        private HeroProfil heroProfil;

        public HeroProfilViewModel(HeroProfil heroProfil)
        {
            this.heroProfil = heroProfil;
        }
    }
}
