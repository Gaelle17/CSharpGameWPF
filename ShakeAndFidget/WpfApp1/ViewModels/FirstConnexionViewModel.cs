using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Views;
using CSharpGameModel.Constante;
using CSharpGameModel.Models;
using DataBase;
using System.Data.Entity;
using MySql.Data.Entity;
using CSharpGeModel.Models;

namespace WpfApp1.ViewModels
{
    public class FirstConnexionViewModel
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        private String name;
        private String passwd;
        private String passwd2;
        private User currentUser;

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

        public User CurrentUser { get => currentUser; set => currentUser = value; }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        private void BtnValidate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            name = this.firstConnexion.nom.Text;
            passwd = this.firstConnexion.passwd.Text;
            passwd2 = this.firstConnexion.passwd2.Text;
            int hero_type = this.firstConnexion.CmbSelect.SelectedIndex;
            Boolean check = true;

            MySQLManager<User> userManager = new MySQLManager<User>();
            MySQLManager<Hero> heroManager = new MySQLManager<Hero>();
            MySQLManager<Stats> statsManager = new MySQLManager<Stats>();
            MySQLManager<Body> bodyManager = new MySQLManager<Body>();
            MySQLManager<Belt> beltManager = new MySQLManager<Belt>();
            MySQLManager<Item> itemManager = new MySQLManager<Item>();

            Task<IEnumerable<User>> getAllUsers = Task<IEnumerable<User>>.Factory.StartNew(() =>
            {
                
                IEnumerable<User>  myUsers = userManager.Get().Result;
                return myUsers;
            });

            foreach (var user in getAllUsers.Result)
            {
                if (user.Name.Equals(name))
                {
                    Console.WriteLine(user.Name);
                    this.firstConnexion.nom.Text = "Choisissez un nom différent";
                    check = false;
                    break;
                }
            }

            if (name.Equals(""))
            {
                this.firstConnexion.nom.Text = "Choisissez un nom différent";
                check = false;
            }
            if (!passwd.Equals(passwd2))
            {
                this.firstConnexion.passwd2.Text = "les mots de passe ne correspondent pas";
                check = false;
            }
            if (hero_type == -1)
            {
                check = false;
            }

            if (check)
            {

                Task<Item> weapon = Task<Item>.Factory.StartNew(() =>
                {
                    Item myWeapon = itemManager.Get(hero_type + 1).Result;
                    Item warriorWeapon;
                    Item hunterWeapon;
                    Item mageWeapon;

                    if (myWeapon == null)
                    {
                        Stats basicWarrior = new Stats(1, 1, 25, 25, 1, Constante.GUERRIER, 10, 10, 10, 10, 10, 25, 25);
                        warriorWeapon = new Item("épéé de Base", "une épée pour taper", basicWarrior, false, true, Constante.MAIN);
                        itemManager.Insert(warriorWeapon);

                        Stats basicHunter = new Stats(1, 1, 25, 25, 1, Constante.CHASSEUR, 10, 10, 10, 10, 10, 25, 25);
                        hunterWeapon = new Item("arc de Base", "un arc pour tirer", basicHunter, false, true, Constante.MAIN);
                        itemManager.Insert(hunterWeapon);

                        Stats basicMage = new Stats(1, 1, 25, 25, 1, Constante.MAGE, 10, 10, 10, 10, 10, 25, 25);
                        mageWeapon = new Item("baguette de Base", "une baguette pour lancer des sorts", basicMage, false, true, Constante.MAIN);
                        itemManager.Insert(mageWeapon);
                        
                        myWeapon = itemManager.Get(hero_type + 1).Result;
                    }
                    return myWeapon;
                });


                Stats heroStats = new Stats(0, 1, 25, 25, 25, hero_type, 10, 10, 10, 10, 10, 25, 25);
                Body body = new Body();
                Belt belt = new Belt();
                body.MainId = weapon.Result.Id;
                Hero hero = new Hero(0, name, heroStats, body, belt);
                currentUser = new User(name, passwd, hero);
                
                Task<User> myUser = Task<User>.Factory.StartNew(() =>
                {
                    userManager.Insert(currentUser);
                    return currentUser;
                });
               
                currentUser = myUser.Result;
                currentUser.Adventurer.Body.Main = weapon.Result;
                MainWindow.Instance.CurrentPage = new Home(currentUser);
            }
            
        }

        private void CmbSelect_select(object sender, System.Windows.RoutedEventArgs e)
        {
            switch (this.firstConnexion.CmbSelect.SelectedIndex)
            {
                case Constante.GUERRIER:
                    firstConnexion.Description.Text = "Les guerriers, ces seigneurs du champ de bataille, forment un groupe hétéroclite. Ils s’entraînent à manier de nombreuses armes ou juste une, ils apprennent à utiliser les armures de manière optimale, ils suivent les enseignements martiaux de maîtres exotiques et étudient l’art de la guerre. Tout cela pour devenir de véritables armes vivantes.";
                    break;
                case Constante.CHASSEUR:
                    firstConnexion.Description.Text = "Les chasseurs partagent de nombreuses particularités : une maîtrise inégalée de certaines armes, une grande habileté pour débusquer le gibier, même le plus inaccessible, et un savoir-faire leur permettant de venir à bout d’une grande variétés de proies. Ces chasseurs allient savoir, patience et habileté pour traquer les hommes, les bêtes ou encore les animaux";
                    break;
                case Constante.MAGE:
                    firstConnexion.Description.Text = "Les mages, ces individus à l’esprit affûté recherchent, collectent et convoitent les connaissances ésotériques et se servent d’arts connus seulement d’une poignée de personnes pour réaliser des merveilles allant au-delà de la portée des simples mortels. ";
                    break;


            }
        }
        #endregion

        #region Events
        private void Events()
        {
            this.firstConnexion.BtnValidate.Click += BtnValidate_Click;
            this.firstConnexion.CmbSelect.SelectionChanged += CmbSelect_select;
        }
        #endregion

    }
}
