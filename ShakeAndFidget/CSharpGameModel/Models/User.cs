using CSharpGeModel.Models;
using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Hero")]
        int adventurerId;
        Hero adventurer;


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
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public Hero Adventurer { get => adventurer; set => adventurer = value; }
        public int AdventurerId { get => adventurerId; set => adventurerId = value; }

        #endregion

        #region Constructors
        public User()
        {

        }

        public User(String name, string password, Hero hero)
        {
            this.Name = name;
            this.password = password;
            this.email = "a.b@c.d";
            this.adventurer = hero;
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
