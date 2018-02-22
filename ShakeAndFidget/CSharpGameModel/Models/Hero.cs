using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGameModel.Models;
using DataBase;

namespace CSharpGeModel.Models
{
    public class Hero : ModelBase
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables

        #endregion

        #region Attributs

        private String name;
        private int level;
        private int life;
        private int mana;
        private List<int> inventory;
        private List<int> body;
        private List<int> belt;
        private int gold;

        #endregion

        #region Properties

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Life
        {
            get { return life; }
            set { life = value; }
        }

        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public List<int> Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }

        public List<int> Body
        {
            get { return body; }
            set { body = value; }
        }

        public List<int> Belt
        {
            get { return belt; }
            set { belt = value; }
        }

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }



        #endregion

        #region Constructors
        public Hero()
        {
                
        }

        public Hero(int id, int level, String name, int life, List<int> inventory, List<int> body, List<int> belt, int gold) : base(id)
        {
            this.level = level;
            this.name = name;
            this.life = life;
            this.inventory = inventory;
            this.body = body;
            this.belt = belt;
            this.gold = gold;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void Fight()
        {

        }

        public void LearnSkill()
        {

        }
        #endregion

        #region Events
        #endregion

    }
}
