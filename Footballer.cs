using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FanGuide
{
    class Footballer : Person
    {
        protected string sport = "Footballer";

        protected string position;
        protected string salary;
        protected string team;
        protected string wins;
        protected string losses;


        public Footballer(string name, string surName, string nationality, string age, string height, string weight,
            string careerDuration, string position, string salary, string team, string wins, string losses) 
            : base(name, surName, nationality, age, height, weight, careerDuration)
        {
            this.position = position;
            this.salary = salary;
            this.team = team;
            this.wins = wins;
            this.losses = losses;
        }


        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Team
        {
            get { return team; }
            set { team = value; }
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
