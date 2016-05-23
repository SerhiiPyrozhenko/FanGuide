using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FanGuide
{
    class TennisPlayer : Person
    {
        protected string sport = "Footballer";


        protected string wins;
        protected string losses;
        protected string winsSeries;
        protected string defense;
        protected string attack;


        public TennisPlayer(string name, string surName, string nationality, string age, string height, string weight,
            string careerDuration, string winsSeries, string defense, string attack, string wins, string losses) 
            : base(name, surName, nationality, age, height, weight, careerDuration)
        {
            this.winsSeries = winsSeries;
            this.defense = defense;
            this.attack = attack;
            this.wins = wins;
            this.losses = losses;
        }


        public string WinSeries
        {
            get { return winsSeries; }
            set { winsSeries = value; }
        }

        public string Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public string Defense
        {
            get { return defense; }
            set { defense = value; }
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
    }
}
