using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameModel.Models
{
    public class Body : ModelBase
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int? teteId;
        private Item tete;
        private int? corpsId;
        private Item corps;
        private int? mainId;
        private Item main;
        private int? jambeId;
        private Item jambe;
        private int? piedsId;
        private Item pieds;
        #endregion

        #region Properties
        public int? TeteId { get => teteId; set => teteId = value; }
        public Item Tete { get => tete; set => tete = value; }
        public int? CorpsId { get => corpsId; set => corpsId = value; }
        public Item Corps { get => corps; set => corps = value; }
        public int? MainId { get => mainId; set => mainId = value; }
        public Item Main { get => main; set => main = value; }
        public int? JambeId { get => jambeId; set => jambeId = value; }
        public Item Jambe { get => jambe; set => jambe = value; }
        public int? PiedsId { get => piedsId; set => piedsId = value; }
        public Item Pieds { get => pieds; set => pieds = value; }
        #endregion

        #region Constructors
        public Body()
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
