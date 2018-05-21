using CSharpGameModel.Models;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Views;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UserControl2.xaml
    /// </summary>
    public partial class UserControlTaverne : UserControl
    {
        private HomeViewModel homeViewModel;
        private MySQLManager<User> usermanager = new MySQLManager<User>();

        public UserControlTaverne()
        {
            InitializeComponent();
        }

        public UserControlTaverne(HomeViewModel homeViewModel)
        {
            InitializeComponent();
            this.homeViewModel = homeViewModel;
            this.myGold.Content = "Gold: " + homeViewModel.home.CurrentUser.Adventurer.Stats.Gold;
            btn_boire.Click += btn_boire_click;
            btn_manger.Click += btn_manger_click;
            btn_discuter.Click += btn_discuter_click;

        }

        private void btn_boire_click(object sender, RoutedEventArgs e)
        {
            if (homeViewModel.home.CurrentUser.Adventurer.Stats.Gold >= 1 )
            {

                if (homeViewModel.home.CurrentUser.Adventurer.Stats.Mana < homeViewModel.home.CurrentUser.Adventurer.Stats.MaxMane)
                {
                    homeViewModel.home.CurrentUser.Adventurer.Stats.Gold -= 1;
                    this.myGold.Content = homeViewModel.home.CurrentUser.Adventurer.Stats.Gold;
                    this.result.Text = "Un petit coup pur faire le plein d'énergie mais attention les mots de tête \n +1 Mana";
                    homeViewModel.home.CurrentUser.Adventurer.Stats.Mana += 1;
                    Task.Factory.StartNew(() =>
                    {
                        usermanager.Update(homeViewModel.home.CurrentUser);
                    });
                }
                else
                {
                    this.result.Text = "Vous avez déjà toute votre Mana";
                }
            }
            else
            {
                this.result.Text = "Pas assez d'or!!!";
            }
        }

        private void btn_manger_click(object sender, RoutedEventArgs e)
        {
            if (homeViewModel.home.CurrentUser.Adventurer.Stats.Gold >= 1)
            {
                
                if (homeViewModel.home.CurrentUser.Adventurer.Stats.Life < homeViewModel.home.CurrentUser.Adventurer.Stats.MaxLife)
                {
                    homeViewModel.home.CurrentUser.Adventurer.Stats.Gold -= 1;
                    this.myGold.Content = homeViewModel.home.CurrentUser.Adventurer.Stats.Gold;
                    this.result.Text = "Un ventre plein ça vous remet en forme \n +1 Life";
                    homeViewModel.home.CurrentUser.Adventurer.Stats.Life += 1;
                    Task.Factory.StartNew(() =>
                    {
                        usermanager.Update(homeViewModel.home.CurrentUser);
                    });
                }
                else
                {
                    this.result.Text = "Vous avez déjaà toute votre Santé";
                }
            }
            else
            {
                this.result.Text = "Pas assez d'or!!!";
            }
        }

        private void btn_discuter_click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://talaikis.com/api/quotes/random/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("").Result;

            String json = response.Content.ReadAsStringAsync().Result;
            System.Console.WriteLine(response.IsSuccessStatusCode);

            String[] desarialize = json.Split('"');
            result.Text = desarialize[3];
        }
    }
}
