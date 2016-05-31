using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_FanGuide
{
    /// <summary>
    /// Форма добавления спортсмена(боксер)
    /// </summary>
    [Serializable]
    public partial class Form4 : Form
    {
        List<Boxer> lst = new List<Boxer>();

        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 f1 = Owner as Form1;
            
            string name = bName.Text;
            string surName = bSurname.Text;
            string nationality = bNationality.Text;
            string age = bAge.Text;
            string careerDuration = bYearsInSport.Text;
            string height = bHeight.Text;
            string weight = bWeight.Text;
            string medals = bMedals.Text;
            string knockouts = bKnockout.Text;
            string wins = bWins.Text;
            string losses = bLosses.Text;

            Boxer cache = new Boxer(name, surName, nationality, age, height, weight, careerDuration, medals, wins, losses, knockouts);

            //добавление в список боксеров
            f1.listB.Add(cache);

            //обновление таблицы через привязку
            f1.UpdateDGV();

            Close();
        }
    }
}

