using CSharpGeModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameModel.Models
{
    class Equipment
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private String position;
        private Hero characterType;  
        #endregion

        #region Properties
        public String Position
        {
            get { return position; }
            set { position = value; }
        }

        public Hero CharacterType
        {
            get { return characterType; }
            set { characterType = value; }
        }
        #endregion

        #region Constructors
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void Equip()
        {

        }

        public void Unequip()
        {

        }
        #endregion

        #region Events
        #endregion
    }
}
