using CSharpGameModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControlDuel : UserControl, INotifyPropertyChanged
    {
        private User currentUser;
        private HomeViewModel homeViewModel;

        public User CurrentUser
        {
            get { return currentUser; }
            set {
                OnPropertyChanged("CurrentUser");
                currentUser = value;
            }
        }

        public UserControlDuel()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public UserControlDuel(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
