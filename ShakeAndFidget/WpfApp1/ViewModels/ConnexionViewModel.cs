using CSharpGameModel.Constante;
using CSharpGameModel.Models;
using CSharpGeModel.Models;
using DataBase;
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
            private String name;
            private String password;
            User currentUser;
            Hero currentHero;
            Stats currentStats;
            Body currentBody;
            Belt currentBelt;
            Item currentItem;
        #endregion

        #region Attributs
            private Connexion connexion;
            MySQLManager<User> userManager = new MySQLManager<User>();
            MySQLManager<Hero> heroManager = new MySQLManager<Hero>();
            MySQLManager<Stats> statsManager = new MySQLManager<Stats>();
            MySQLManager<Body> bodyManager = new MySQLManager<Body>();
            MySQLManager<Belt> beltManager = new MySQLManager<Belt>();
            MySQLManager<Item> itemManager = new MySQLManager<Item>();


        #endregion

        #region Properties
            public string Name { get => name; set => name = value; }
            public string Password { get => password; set => password = value; }
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

            name = this.connexion.uc1.name.Text;
            password = this.connexion.uc1.password.Text;

            Task<IEnumerable<User>> getAllUsers = Task<IEnumerable<User>>.Factory.StartNew(() =>
            {
                IEnumerable<User> myUsers = userManager.Get().Result;
                return myUsers;
            });

            foreach (var user in getAllUsers.Result)
            {
                if (user.Name.Equals(name) && user.Password.Equals(password))
                {
                    currentUser = user;
                    Task<User> getUser = Task<User>.Factory.StartNew(() =>
                    {
                        User myUser = userManager.Get(user.Id).Result;
                        return myUser;
                    });
                    currentUser = getUser.Result;
                    break;
                }
            }


            Task<Hero> getHero = Task<Hero>.Factory.StartNew(() =>
            {
                Hero myHero = heroManager.Get(currentUser.AdventurerId).Result;
                return myHero;
            });
            currentHero = getHero.Result;

            currentUser.Adventurer = currentHero;

            Task<Stats> getStats = Task<Stats>.Factory.StartNew(() =>
            {
                Stats myStats = statsManager.Get(currentUser.Adventurer.StatsId).Result;
                return myStats;
            });
            currentStats = getStats.Result;

            Task<Body> getBody = Task<Body>.Factory.StartNew(() =>
            {
                Body myBody = bodyManager.Get(currentUser.Adventurer.BodyId).Result;
                return myBody;
            });
            currentBody = getBody.Result;

            Task<Belt> getBelt = Task<Belt>.Factory.StartNew(() =>
            {
                Belt myBelt = beltManager.Get(currentUser.Adventurer.BeltId).Result;
                return myBelt;
            });
            currentBelt = getBelt.Result;

            currentBody = chargeBody(currentBody);
            currentBelt = chargeBelt(currentBelt);

            currentUser.Adventurer.Stats = currentStats;
            currentUser.Adventurer.Body = currentBody;
            currentUser.Adventurer.Belt = currentBelt;
            currentBelt = chargeBelt(currentBelt);



        MainWindow.Instance.CurrentPage = new Home(currentUser);
        }

        private Body chargeBody(Body body)
        {
            if(body.TeteId != null)
            {
                body.Tete = chargeItem(body.TeteId.GetValueOrDefault());
            }
            if (body.CorpsId != null)
            {
                body.Corps = chargeItem(body.CorpsId.GetValueOrDefault());
            }
            if (body.MainId != null)
            {
                body.Main = chargeItem(body.MainId.GetValueOrDefault());
            }
            if (body.JambeId != null)
            {
                body.Jambe = chargeItem(body.JambeId.GetValueOrDefault());
            }
            if (body.PiedsId != null)
            {
                body.Pieds = chargeItem(body.PiedsId.GetValueOrDefault());
            }

            return body;
        }

        private Belt chargeBelt(Belt belt)
        {
            if (belt.Usable1Id != null )
            {
                belt.Usable1 = chargeItem(belt.Usable1Id.GetValueOrDefault());
            }
            if (belt.Usable2Id != null)
            {
                belt.Usable2 = chargeItem(belt.Usable2Id.GetValueOrDefault());
            }
            if (belt.Usable3Id != null)
            {
                belt.Usable3 = chargeItem(belt.Usable3Id.GetValueOrDefault());
            }
            if (belt.Usable4Id != null)
            {
                belt.Usable4 = chargeItem(belt.Usable4Id.GetValueOrDefault());
            }
            if (belt.Usable5Id != null)
            {
                belt.Usable5 = chargeItem(belt.Usable5Id.GetValueOrDefault());
            }
            if (belt.Usable6Id != null)
            {
                belt.Usable6 = chargeItem(belt.Usable6Id.GetValueOrDefault());
            }

            return belt;
        }

        private Item chargeItem(int id)
        {
            Item myItem = itemManager.Get(id).Result;
            return myItem;
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
