using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FanGuide
{
    class Boxer : Person
    {
        protected string sport = "Boxer";

        protected string medals;
        protected string wins;
        protected string losses;
        protected string knockout;

        public Boxer(string name, string surName, string nationality, string age, string height, string weight,
            string careerDuration, string medals, string wins, string losses, string knockout) 
            : base(name, surName, nationality, age, height, weight, careerDuration)
        { 
            this.wins = wins;
            this.losses = losses;
            this.knockout = knockout;
            this.medals = medals;
        }    

        public string Medals
        {
            get { return medals; }
            set { medals = value; }
        }

        public string Wins
        {
            get { return wins; }
            set { wins = value; }
        }

        public string Losses
        {
            get { return losses; }
            set { losses = value; }
        }

        public string Knockout
        {
            get { return knockout; }
            set { knockout = value; }
        }
    }
}
