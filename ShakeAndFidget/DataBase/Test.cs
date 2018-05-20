using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGameModel.Constante;
using CSharpGameModel.Models;
using CSharpGeModel.Models;

namespace DataBase
{
    public class Test
    {
        public Test()
        {
            MySQLManager<Hero> heroManager = new MySQLManager<Hero>();
            Hero hero1 = new Hero();
           

            Hero hero2 = heroManager.Insert(hero1).Result;
            hero2 = heroManager.Get(1).Result;

        }
    }
}
