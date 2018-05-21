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

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Profil.xaml
    /// </summary>
    public partial class UserControlProfil : UserControl
    {
        private Home home;
        private HomeViewModel homeViewModel;

        public UserControlProfil()
        {
            InitializeComponent();
        }

        public UserControlProfil(HomeViewModel homeViewModel)
        {
            InitializeComponent();
            this.homeViewModel = homeViewModel;
            this.home = homeViewModel.home;

            if (home.CurrentUser.Adventurer.Body.Tete != null)
            {
                Tete.Content = home.CurrentUser.Adventurer.Body.Tete.Name;
            }
            if (home.CurrentUser.Adventurer.Body.Main != null)
            {
                this.Main.Content = home.CurrentUser.Adventurer.Body.Main.Name;
            }
            if (home.CurrentUser.Adventurer.Body.Corps != null)
            {
                this.Corps.Content = home.CurrentUser.Adventurer.Body.Corps.Name;
            }
            if (home.CurrentUser.Adventurer.Body.Jambe != null)
            {
                this.Jambe.Content = home.CurrentUser.Adventurer.Body.Jambe.Name;
            }
            if (home.CurrentUser.Adventurer.Body.Pieds != null)
            {
                this.Pieds.Content = home.CurrentUser.Adventurer.Body.Pieds.Name;
            }

            if (home.CurrentUser.Adventurer.Belt.Usable1 != null)
            {
                this.Usable1.Content = home.CurrentUser.Adventurer.Belt.Usable1.Name;
            }
            if (home.CurrentUser.Adventurer.Belt.Usable2 != null)
            {
                this.Usable2.Content = home.CurrentUser.Adventurer.Belt.Usable2.Name;
            }
            if (home.CurrentUser.Adventurer.Belt.Usable3 != null)
            {
                this.Usable3.Content = home.CurrentUser.Adventurer.Belt.Usable3.Name;
            }
            if (home.CurrentUser.Adventurer.Belt.Usable4 != null)
            {
                this.Usable4.Content = home.CurrentUser.Adventurer.Belt.Usable4.Name;
            }
            if (home.CurrentUser.Adventurer.Belt.Usable5 != null)
            {
                this.Usable5.Content = home.CurrentUser.Adventurer.Belt.Usable5.Name;
            }
            if (home.CurrentUser.Adventurer.Belt.Usable6 != null)
            {
                this.Usable6.Content = home.CurrentUser.Adventurer.Belt.Usable6.Name;
            }

            this.Stats.Text = home.CurrentUser.Adventurer.Stats.ToString();
        }
    }
}
