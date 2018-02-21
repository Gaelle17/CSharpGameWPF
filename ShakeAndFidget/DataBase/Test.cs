using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            hero1.Name = "bob";
            hero1.Level = 1;
            hero1.Life = 32;
            hero1.Mana = 12;

            heroManager.Insert(hero1);
    }
}
}
