using CSharpGameModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class ConnexionViewModel
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        private User currentUser = new User();
        #endregion

        #region Attributs
        private Connexion connexion;
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public ConnexionViewModel(Connexion connexion)
        {
            this.connexion = connexion;
            this.Events();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        private void BtnRegister_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow.Instance.CurrentPage = new FirstConnexion();
        }

        private void BtnValidate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow.Instance.CurrentPage = new Page1();
        }
        #endregion

        #region Events
        private void Events()
        {
            this.connexion.uc1.CurrentUser = currentUser;
            this.connexion.BtnRegister.Click += BtnRegister_Click;
            this.connexion.BtnValidate.Click += BtnValidate_Click;
        }
        #endregion




    }
}
