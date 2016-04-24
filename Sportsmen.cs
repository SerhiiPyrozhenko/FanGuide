using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FansGuide
{
    class Sportsmen
    {
        private string Sport { set { Sport = value; } get { return Sport; } }
        private string Name { set { Name = value; } get { return Name; } }
        private string SurName { set { SurName = value; } get { return SurName; } }
        private string Nationality { set { Nationality = value; } get { return Nationality; } }

        private int Age { set { Age = value; } get { return Age; } }
        private string Sex { set { Sex = value; } get { return Sex; } }
        private double Height { set { Height = value; } get { return Height; } }
        private double Weigth { set { Weigth = value; } get { return Weigth; } }
        private int TimeInSport { set { TimeInSport = value; } get { return TimeInSport; } }

        public Sportsmen(string sport, string name, string surName, string nationality)
        {
            Sport = sport;
            Name = name;
            SurName = surName;
            Nationality = nationality;
        }

        public Sportsmen(int age, string sex, double height, double weidth, int timeInSport)
        {
            Age = age;
            Sex = sex;
            Height = height;
            Weigth = weidth;
            TimeInSport = timeInSport;
        }


    }
}
