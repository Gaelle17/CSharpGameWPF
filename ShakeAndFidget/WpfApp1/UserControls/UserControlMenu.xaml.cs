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
    /// Logique d'interaction pour UserControlMenu.xaml
    /// </summary>
    public partial class UserControlMenu : UserControl
    {
        private HomeViewModel homeViewModel;

        public UserControlMenu()
        {
            InitializeComponent();
            btn_profil.Click += btn_profil_Click;
            btn_duel.Click += btn_duel_Click;
            btn_quest.Click += btn_quest_Click;
            btn_recreate.Click += btn_recreate_Click;
            btn_exit.Click += btn_exit_Click;
        }

        public UserControlMenu(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
            InitializeComponent();
            btn_profil.Click += btn_profil_Click;
            btn_duel.Click += btn_duel_Click;
            btn_quest.Click += btn_quest_Click;
            btn_recreate.Click += btn_recreate_Click;
            btn_exit.Click += btn_exit_Click;
        }

        void btn_profil_Click(object sender, RoutedEventArgs e)
        {
            UserControlProfil profil = new UserControls.UserControlProfil(this.homeViewModel);
            this.homeViewModel.home.Action.Children.Clear();
            this.homeViewModel.home.Action.Children.Add(profil);
            
        }
        void btn_duel_Click(object sender, RoutedEventArgs e)
        {
            UserControlDuel duel = new UserControlDuel(this.homeViewModel);
            this.homeViewModel.home.Action.Children.Clear();
            this.homeViewModel.home.Action.Children.Add(duel);
        }
        void btn_quest_Click(object sender, RoutedEventArgs e)
        {
            UserControlDuel quest = new UserControlDuel(this.homeViewModel);
            this.homeViewModel.home.Action.Children.Clear();
            this.homeViewModel.home.Action.Children.Add(quest);
        }
        void btn_recreate_Click(object sender, RoutedEventArgs e)
        {
            UserControlTaverne taverne = new UserControlTaverne(this.homeViewModel);
            this.homeViewModel.home.Action.Children.Clear();
            this.homeViewModel.home.Action.Children.Add(taverne);
        }
        void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.CurrentPage = new Connexion();
        }
    }
}
