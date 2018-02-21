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


        #endregion

        #region Constructors
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion

    }
}
