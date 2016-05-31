using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_FanGuide
{
    /// <summary>
    /// Форма добавления спортсмена(футболист);
    /// </summary>
    [Serializable]
    public partial class Form2 : Form
    {
        List<Footballer> lst = new List<Footballer>();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 f1 = Owner as Form1;
                
            string name = fName.Text;
            string surName = fSurname.Text;
            string nationality = fNationality.Text;
            string age = fAge.Text;
            string careerDuration = fYearsInSport.Text;
            string height = fHeight.Text;
            string weight = fWeight.Text;
            string salary = fSalary.Text;
            string position = fPosition.Text;
            string team = fTeam.Text;
            string wins = fWins.Text;
            string losses = fLosses.Text;

            Footballer cache = new Footballer(name, surName, nationality, age, height, weight, careerDuration, position, salary, team, wins, losses);

            //добавление в список футболистов
            f1.listF.Add(cache);

            //обновление таблицы через привязку
            f1.UpdateDGV();

            Close();
        }
    }
}
