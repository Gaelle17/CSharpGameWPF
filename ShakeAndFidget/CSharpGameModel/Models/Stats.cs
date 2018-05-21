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
        private int level;
        private int life;
        private int mana;
        private int gold;
        private int hero_type;
        private int strength;
        private int intelligence;
        private int luck;
        private int agility;
        private int resistance;
        private int maxLife;
        private int maxMana;
        private int XP;
        #endregion

        #region Properties
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
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

        public int Level { get => level; set => level = value; }
        public int Life { get => life; set => life = value; }
        public int Mana { get => mana; set => mana = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Hero_type { get => hero_type; set => hero_type = value; }
        public int XP1 { get => XP; set => XP = value; }
        #endregion

        #region Constructors
        public Stats()
        {

        }

        public Stats(int damage, int level, int life, int mana, int gold, int hero_type, int strength, int intelligence, int luck, int agility, int resistance, int maxLife, int maxMana)
        {
            this.damage = damage;
            this.level = level;
            this.life = life;
            this.mana = mana;
            this.gold = gold;
            this.hero_type = hero_type;
            this.strength = strength;
            this.intelligence = intelligence;
            this.luck = luck;
            this.agility = agility;
            this.resistance = resistance;
            this.maxLife = maxLife;
            this.maxMana = maxMana;
            this.XP = 0;
        }


        #endregion

        #region StaticFunctions
        public override string ToString()
        {
            String statsDetail =    "level: " + level + "\n" +
                                    "XP: " + XP + "\n" +
                                    "damage: " + damage + "\n" +
                                    "life: " + life + "/" + maxLife + "\n" +
                                    "mana: " + mana + "/" + maxMana + "\n" +
                                    "strength: " + strength + "\n" +
                                    "intelligence: " + intelligence + "\n" +
                                    "luck: " + luck + "\n" +
                                    "agility: " + agility + "\n" +
                                    "resistance: " + resistance + "\n" +
                                    "gold: " + gold + "\n" ;
            return statsDetail;
        }
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion
    }
}
