using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KvalEgzPM01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            X_numericUpDown.Maximum = decimal.MaxValue;
            X_numericUpDown.Minimum = decimal.MinValue;
            Y_numericUpDown.Maximum = decimal.MaxValue;
            Y_numericUpDown.Minimum = decimal.MinValue;
            this.Size = new System.Drawing.Size(850, 385);
        }

        private void открыть_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files(*.html)|*.HTML|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                webBrowser.Navigate(new Uri(fileName));
                this.Size = new System.Drawing.Size(850,500);
                Text = fileName;
            }
        }

        private void Cheak_button_Click(object sender, EventArgs e)
        {
            if (webBrowser.Url == new Uri(@"C:\Users\user\source\repos\KvalEgzPM01\KvalEgzPM01\web\Page1.html"))
            {
                bool border = false;
                if (Y_numericUpDown.Value == 4 * X_numericUpDown.Value)
                {
                    border = true;
                }
                else if (Y_numericUpDown.Value > 4 * X_numericUpDown.Value)
                {
                    MessageBox.Show("Точка непринадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка непринадлежности области";
                    return;
                }
                if (Y_numericUpDown.Value == -4 * X_numericUpDown.Value)
                {
                    border = true;
                }
                else if (Y_numericUpDown.Value > -4 * X_numericUpDown.Value)
                {
                    MessageBox.Show("Точка непринадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка непринадлежности области";
                    return;
                }
                if (Y_numericUpDown.Value == X_numericUpDown.Value * X_numericUpDown.Value - 5)
                {
                    border = true;
                }
                else if (Y_numericUpDown.Value < X_numericUpDown.Value * X_numericUpDown.Value - 5)
                {
                    MessageBox.Show("Точка непринадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка непринадлежности области";
                    return;
                }
                if (border == true)
                {
                    MessageBox.Show("Точка находится на границе", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка находится на границе";
                }
                else
                {
                    MessageBox.Show("Точка принадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка принадлежности области";
                }
            }
            else if (webBrowser.Url == new Uri(@"C:\Users\user\source\repos\KvalEgzPM01\KvalEgzPM01\web\Page2.html"))
            {
                bool border = false;
                if (Y_numericUpDown.Value == 1)
                {
                    border = true;
                }
                else if (Y_numericUpDown.Value > 1)
                {
                    MessageBox.Show("Точка непринадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка непринадлежности области";
                    return;
                }
                if (Y_numericUpDown.Value == Math.Abs(X_numericUpDown.Value))
                {
                    border = true;
                }
                else if (Y_numericUpDown.Value < Math.Abs(X_numericUpDown.Value))
                {
                    MessageBox.Show("Точка непринадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка непринадлежности области";
                    return;
                }
                if (X_numericUpDown.Value == 1)
                {
                    border = true;
                }
                else if (X_numericUpDown.Value > 1)
                {
                    MessageBox.Show("Точка непринадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка непринадлежности области";
                    return;
                }
                if (X_numericUpDown.Value == -1)
                {
                    border = true;
                }
                else if (X_numericUpDown.Value < -1)
                {
                    MessageBox.Show("Точка непринадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка непринадлежности области";
                    return;
                }
                if (border == true)
                {
                    MessageBox.Show("Точка находится на границе", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка находится на границе";
                }
                else
                {
                    MessageBox.Show("Точка принадлежности области", "Результат расчёта");
                    Статус_toolStripStatusLabel.Text = "Точка принадлежности области";
                }
            }
            else
            {
                MessageBox.Show("Неизвестная страница", "Результат расчёта");
                Статус_toolStripStatusLabel.Text = "Неизвестная страница";
            }

        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Маркин Андрей Викторович"+"\n"+"Курс: ПКсп-117"+"\n"+"Вариант: 1", "О программе");
        }

        private void выход_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
