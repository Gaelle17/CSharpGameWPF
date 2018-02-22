using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameModel.Models
{
    public class Stats : ModelBase
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int damage;
        private int strenght;
        private int intelligence;
        private int luck;
        private int speed;
        private int agility;
        private int resistance;
        private int maxLife;
        private int maxMana;
        #endregion

        #region Properties
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Strenght
        {
            get { return strenght; }
            set { strenght = value; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public int Luck
        {
            get { return luck; }
            set { luck = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Agility
        {
            get { return agility; }
            set { agility = value; }
        }

        public int Resistance
        {
            get { return resistance; }
            set { resistance = value; }
        }

        public int MaxLife
        {
            get { return maxLife; }
            set { maxLife = value; }
        }

        public int MaxMane
        {
            get { return maxMana; }
            set { maxMana = value; }
        }
        #endregion

        #region Constructors
        public Stats()
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
