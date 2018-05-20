using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGameModel.Constante;
using DataBase;

namespace CSharpGameModel.Models
{
    public class Belt : ModelBase
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int? usable1Id;
        private Item usable1;
        private int? usable2Id;
        private Item usable2;
        private int? usable3Id;
        private Item usable3;
        private int? usable4Id;
        private Item usable4;
        private int? usable5Id;
        private Item usable5;
        private int? usable6Id;
        private Item usable6;
        #endregion

        #region Properties
        public int? Usable1Id { get => usable1Id; set => usable1Id = value; }
        public Item Usable1 { get => usable1; set => usable1 = value; }
        public int? Usable2Id { get => usable2Id; set => usable2Id = value; }
        public Item Usable2 { get => usable2; set => usable2 = value; }
        public int? Usable3Id { get => usable3Id; set => usable3Id = value; }
        public Item Usable3 { get => usable3; set => usable3 = value; }
        public int? Usable4Id { get => usable4Id; set => usable4Id = value; }
        public Item Usable4 { get => usable4; set => usable4 = value; }
        public int? Usable5Id { get => usable5Id; set => usable5Id = value; }
        public Item Usable5 { get => usable5; set => usable5 = value; }
        public int? Usable6Id { get => usable6Id; set => usable6Id = value; }
        public Item Usable6 { get => usable6; set => usable6 = value; }
        #endregion

        #region Constructors
        public Belt()
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
