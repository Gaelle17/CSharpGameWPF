using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DataBase;
using EntityUtils;
using CSharpGeModel.Models;
using MySql.Data.Entity;
using System.Data.Entity;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());

            new DataBase.Test();
        }

        /***
            Task.Factory.StartNew(() =>
            {
                EntityGenerator<Client> generatorC = new EntityGenerator<Client>();
                EntityGenerator<Product> generatorP = new EntityGenerator<Product>();
                MySQLManager<Client> manager = new MySQLManager<Client>();
                for (int i = 0; i < 6000; i++)
                {
                    Client cli = generatorC.GenerateItem();
                    for (int j = 0; j < 4; j++)
                    {
                        cli.Bag.Add(generatorP.GenerateItem());
                    }
                    manager.Insert(cli);
                }
            });

        **/


    }
}
