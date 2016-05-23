using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FanGuide
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sport = "Tennis";
            string name = tName.Text;
            string surName = tSurname.Text;
            string nationality = tNationality.Text;
            string age = tAge.Text;
            string careerDuration = tYearsInSport.Text;
            string height = tHeight.Text;
            string weight = tWeight.Text;
            string megals = tMedals.Text;
            string seriesOfWin = tSeries.Text;
            string attack = tAttack.Text;
            string defense = tDefence.Text;
            string wins = tWins.Text;
            string losses = tLosses.Text;

            TennisPlayer cache = new TennisPlayer(name, surName, nationality, age, height, weight, careerDuration, seriesOfWin, defense, attack,wins,losses);

            //dataGridView2.Rows.Add(name, surName, nationality, age, height, weight, careerDuration, seriesOfWin, defense, attack, wins, losses);
        }
    }
}
