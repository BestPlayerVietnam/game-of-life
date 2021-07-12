using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellAuto
{
    public partial class Form1 : Form
    {

        int gen = 0;
        bool[,] currentStep = new bool[35, 98];
        bool[,] nextStep = new bool[35, 98];
        Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.EndEdit();
            dataGridView1.RowCount = 35;
            dataGridView1.ColumnCount = 98;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Height = 10;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Columns[j].Width = 10;
                       currentStep[i, j] = false;
                }
            }
        }

        /*
         *Creates a single universe with some chance to cells become alive
         */
        private void GenerateRandomLife_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            CreateRandomUniverse();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (currentStep[i, j])
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    else
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
        /*
         * Makes our universe alive and setup the rule of life
         */
        public void nextGen()
        {
            int left, right, up, down;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (i != 0)
                        up = i - 1;
                    else
                        up = dataGridView1.RowCount - 1;                                                 
                    if (i != dataGridView1.RowCount - 1)
                        down = i + 1;
                    else
                        down = 0;
                    if (j != 0)
                        left = j - 1;
                    else
                        left = dataGridView1.ColumnCount - 1;
                    if (j != dataGridView1.ColumnCount - 1)
                        right = j + 1;
                    else
                        right = 0;
                    int lifeAround = 0; //на текущем этапе, мы превратили нашу вселенную - двумерный массив в тор.
                    if (currentStep[i, left])
                        lifeAround++;
                    if (currentStep[i, right])
                        lifeAround++;
                    if (currentStep[up, j])
                        lifeAround++;
                    if (currentStep[down, j])
                        lifeAround++;
                    if (currentStep[up, right])
                        lifeAround++;
                    if (currentStep[up, left])
                        lifeAround++;
                    if (currentStep[down, right])
                        lifeAround++;
                    if (currentStep[down, left])
                        lifeAround++; //Провели подсчет живых клеток вокруг нашей.
                    if (lifeAround == 3 && currentStep[i, j] == false)
                        nextStep[i, j] = true;
                    else if ((lifeAround < 2 || lifeAround > 3) && currentStep[i, j] == true)
                        nextStep[i, j] = false;
                    else
                        nextStep[i, j] = currentStep[i, j]; //описали условия жизни, смерти или поддержания жизни.
                }
            }
        }
        
        /*
         * С помощью данной функции превращаем завтрашний день в текущий.
         */
        public void newDay()
        {
            nextGen();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    currentStep[i, j] = nextStep[i, j];
                }
            }
        }

        /*
         * метод для отображения всего связанного с жизнью => ее отображения и изменения
         */
        public void specLife()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (currentStep[i, j])
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    else
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            dataGridView1.Refresh();
        }

        /*
         * Method which creates a new universe and makes previous dead
         */
        public void CreateRandomUniverse()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (rnd.Next(100) < 5)
                        currentStep[i, j] = true;
                    else
                        currentStep[i, j] = false;
                }
            }
        }

        /*
         * Make the single cell alive or kill her
         */
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (currentStep[e.RowIndex, e.ColumnIndex])
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.White;
                currentStep[e.RowIndex, e.ColumnIndex] = false;
            }
            else
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.Green;
                currentStep[e.RowIndex, e.ColumnIndex] = true;
            }
            dataGridView1.ClearSelection();
        }
        
        /*
         *Quit the programm 
         */
        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
         * По клику переходим в нвой день жизни
         */
        private void nextgeneration_Click(object sender, EventArgs e)
        {
            counterNum.Text = (++gen).ToString();
            newDay();
            specLife();
        }

        /*
         * Убиваем всю жизнь
         */
        private void kill_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    currentStep[i, j] = false;
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            dataGridView1.Refresh();
            timer1.Stop();
            gen = 0;
            counterNum.Text = gen.ToString();
        }
     
        /*
         * Запускаем жизнь с текущими живыми клетками.
         */
        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        /*
         * Метод описания действий в тик времени(на самом деле, мы просто имитируем переход в нвой день, но по тик таймеру)
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            nextgeneration_Click(sender, e);
        }
        /*
         * Приостанавливаем развитие жизни
         */
        private void pauseTime_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

    }
}
