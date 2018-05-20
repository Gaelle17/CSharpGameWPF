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
        private int statsId;
        private Stats stats;
        private int bodyId;
        private Body body;
        private int beltId;
        private Belt belt;
        private ICollection<Item> inventory;

        #endregion

        #region Properties

        public string Name { get => name; set => name = value; }

        public int StatsId { get => statsId; set => statsId = value; }
        public Stats Stats
        {
            get { return stats; }
            set { stats = value; }
        }
        public int BodyId { get => bodyId; set => bodyId = value; }
        public Body Body { get => body; set => body = value; }
        public int BeltId { get => beltId; set => beltId = value; }
        public Belt Belt { get => belt; set => belt = value; }

        public ICollection<Item> Inventory { get => inventory; set => inventory = value; }


        #endregion

        #region Constructors
        public Hero()
        {
                
        }

        public Hero(Int32 id, String name, Stats stats, Body body, Belt belt) : base(id)
        {
            this.Id = id;
            this.Name = name;
            this.Stats = stats;
            this.Body = body;
            this.Belt = belt;
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
