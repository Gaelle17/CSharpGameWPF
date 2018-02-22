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
        }
    }
}
