using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Views;
using DataBase;
using CSharpGeModel.Models;

namespace WpfApp1.ViewModels
{
    public class HeroProfilViewModel
    {
        private HeroProfil heroProfil;

        public HeroProfilViewModel(HeroProfil heroProfil)
        {
            this.heroProfil = heroProfil;
          //  MySQLManager<Hero> heroManager = new MySQLManager<Hero>();
           // Hero monHero =heroManager.Get(1).Result;
           // Console.WriteLine(monHero);

        }
    }
}
