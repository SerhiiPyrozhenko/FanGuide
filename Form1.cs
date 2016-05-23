using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_FanGuide
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void btnDelAllocated_Click(object sender, EventArgs e)
        {
            int ind = dataGridView2.SelectedCells[0].RowIndex;
            dataGridView2.Rows.RemoveAt(ind);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((stream = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader read = new StreamReader(stream);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = read.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num;
                        for(int i = 0; i< num; i++)
                        {
                            str = str1[i].Split('^');
                            for(int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        read.Close();
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter write = new StreamWriter(stream);                 
                    try
                    {
                        for(int i = 0;i < dataGridView1.RowCount - 1; i++)
                        {
                            for(int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                write.Write(dataGridView1.Rows[i].Cells[j].Value.ToString()+"^");
                            }
                            write.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        write.Close();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Hide();
            f.Show();
        }

        private void btnBodyBuilder_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Hide();
            f.Show();
        }

        private void btnBoxer_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Hide();
            f.Show();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
