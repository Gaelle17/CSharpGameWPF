using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameModel.Models
{
    public class Item : ModelBase
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs

        private String name;
        private String description;
        private Boolean usable;
        private Boolean equipement;
        private int? emplacement;

        private int caracsId;
        private Stats caracs;
        #endregion

        #region Properties

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        public int? Emplacement
        {
            get { return emplacement; }
            set { emplacement = value; }
        }
        public Boolean Equipement
        {
            get { return equipement; }
            set { equipement = value; }
        }
        public Boolean Usable
        {
            get { return usable; }
            set { usable = value; }
        }

        public int CaracsId { get => caracsId; set => caracsId = value; }
        public Stats Caracs
        {
            get { return caracs; }
            set { caracs = value; }
        }



        #endregion

        #region Constructors

        public Item()
        {

        }

        public Item(string name, string description, Stats caracs, bool usable, bool equipement, int emplacement)
        {
            this.name = name;
            this.description = description;
            this.caracs = caracs;
            this.usable = usable;
            this.equipement = equipement;
            this.emplacement = emplacement;
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
