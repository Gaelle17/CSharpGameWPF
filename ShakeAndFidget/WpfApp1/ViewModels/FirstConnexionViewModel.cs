using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class FirstConnexionViewModel
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        private String id;
        private String passwd;
        #endregion

        #region Attributs
        private FirstConnexion firstConnexion;
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public FirstConnexionViewModel(FirstConnexion firstConnexion)
        {
            this.firstConnexion = firstConnexion;
            this.Events();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        private void BtnValidate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow.Instance.CurrentPage = new FirstConnexion();
        }
        #endregion

        #region Events
        private void Events()
        {
            this.firstConnexion.BtnValidate.Click += BtnValidate_Click;
        }
        #endregion

    }
}
