using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_FanGuide
{
    /// <summary>
    /// Форма добавления спортсмена(тенисист).
    /// </summary>
    [Serializable]
    public partial class Form3 : Form
    {
        List<TennisPlayer> lst = new List<TennisPlayer>();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 f1 = Owner as Form1;

            string name = tName.Text;
            string surName = tSurname.Text;
            string nationality = tNationality.Text;
            string age = tAge.Text;
            string careerDuration = tYearsInSport.Text;
            string height = tHeight.Text;
            string weight = tWeight.Text;
            string seriesOfWin = tSeries.Text;
            string attack = tAttack.Text;
            string defense = tDefence.Text;
            string wins = tWins.Text;
            string losses = tLosses.Text;

            TennisPlayer cache = new TennisPlayer(name, surName, nationality, age, height, weight, careerDuration, seriesOfWin, defense, attack,wins,losses);
            
            //добавление в список тенисиста
            f1.listT.Add(cache);

            //обновление таблицы через привязку
            f1.UpdateDGV();

            Close();
        }
    }
}

