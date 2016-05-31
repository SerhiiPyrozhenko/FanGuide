using System;
using System.Windows.Forms;

namespace OOP_FanGuide
{
    /// <summary>
    /// Форма, отображающая список стортсменов.
    /// </summary>

    public partial class Form1 : Form
    {
        /// <summary>
        /// Создание экземляров листа для привязки данных.
        /// </summary>
        public FootballerList listF = new FootballerList();
        public TennisPlayerList listT = new TennisPlayerList();
        public BoxerList listB = new BoxerList();

        /// <summary>
        /// Указание пути к данным.
        /// </summary>
        string pathF = @"Data\Football.bin";
        string pathB = @"Data\Boxing.bin";
        string pathT = @"Data\Tennis.bin";
        FileAccess fa = new FileAccess();

        public Form1()
        {
            InitializeComponent();
        }    
        
        private void btnDelAllocated_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure?", "Warning",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int ind = dataGridView6.SelectedCells[0].RowIndex;
                dataGridView6.Rows.RemoveAt(ind);
            }
        }

        private void btnDelAllocated2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Warning",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int ind = dataGridView2.SelectedCells[0].RowIndex;
                    dataGridView2.Rows.RemoveAt(ind);
                    //TennisPlayer t = dataGridView2.SelectedRows[0].DataBoundItem as TennisPlayer;
                    //listT.Remove(t);
                }
            }
        }

        private void btnDelAllocated3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Warning",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int ind = dataGridView5.SelectedCells[0].RowIndex;
                dataGridView5.Rows.RemoveAt(ind);
            }
        }

        /// <summary>
        /// Инициализация форм добавления
        /// </summary>
        private void btnFootballer_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.ShowDialog(this);
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.ShowDialog(this);
        }

        private void btnBoxer_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.ShowDialog(this);
        }
        /// <summary>
        /// Инициализация формы помощи
        /// </summary>
        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help f5 = new Help();
            f5.Owner = this;
            f5.ShowDialog(this);
        }


        /// <summary>
        /// Считывание и привязка данных при загрузке формы
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {      
            listF = fa.OpenF(pathF, listF);
            listB = fa.OpenB(pathB, listB);
            listT = fa.OpenT(pathT, listT);

            personListBindingSource.DataSource = listF;
            personListBindingSource1.DataSource = listT;
            personListBindingSource2.DataSource = listB;
        }

        /// <summary>
        /// Сохранение данных при закритии формы
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fa.SaveF(pathF, listF);
            fa.SaveB(pathB, listB);
            fa.SaveT(pathT, listT);   
        }

        /// <summary>
        /// Сохранение данных при нажатии кнопки save
        /// </summary>
        private void savToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fa.SaveF(pathF, listF);
            fa.SaveB(pathB, listB);
            fa.SaveT(pathT, listT);

            MessageBox.Show("The save was success");
        }
        /// <summary>
        /// Обновление таблицы после добавления нового спортсмена
        /// </summary>
        public void UpdateDGV()
        {
            personListBindingSource.ResetBindings(false);
            personListBindingSource1.ResetBindings(false);
            personListBindingSource2.ResetBindings(false);           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fa.SaveF(pathF, listF);
            fa.SaveB(pathB, listB);
            fa.SaveT(pathT, listT);
            Close();
        }

    }
}

