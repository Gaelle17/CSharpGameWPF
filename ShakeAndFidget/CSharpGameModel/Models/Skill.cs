﻿using CSharpGeModel.Models;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameModel.Models
{
    public class Skill : ModelBase
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int id;
        private String name;
        private Hero characterType;
        #endregion

        #region Properties

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Hero CharacterType
        {
            get { return characterType; }
            set { characterType = value; }
        }
        #endregion

        #region Constructors
        public Skill()
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
