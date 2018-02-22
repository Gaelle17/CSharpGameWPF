using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameModel.Models
{
    public class User : ModelBase {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables

        #endregion

        #region Attributs

        String name;
        String email;
        String password;

        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set {
                OnPropertyChanged("Name");
                name = value;
            }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Paswword
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

        #region Constructors
        public User()
        {

        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion

    }
}
