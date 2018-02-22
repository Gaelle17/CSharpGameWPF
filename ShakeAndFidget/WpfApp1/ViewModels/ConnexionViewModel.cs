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
        private String pseudo;
        private String passwd;
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
        #endregion

        #region Events
        private void Events()
        {
            this.connexion.BtnRegister.Click += BtnRegister_Click;
        }
        #endregion




    }
}
