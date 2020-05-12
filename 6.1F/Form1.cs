using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] Input()
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(N.Text);
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(0,100);
            }
            return mas;
        }
        private void Print(int[] mas)
        {
            {
                for (int i = 0; i < mas.Length; ++i)
                {
                    V.Text += mas[i];
                    V.Text += Environment.NewLine;
                }
            }
        }
        private void Change(int[] mas, int a)
        {
            V.Text += Environment.NewLine;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > a)
                    V.Text += " " + i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] mas = Input();
                V.Text = "";
                int n = Convert.ToInt32(MA.Text);
                Print(mas);
                Change(mas, n);
            }
            catch
            {
                V.Text = "Неккоректно введённые данные";
            }

        }
        private int[,] Input(out int n, out int m)
        {
            Random rnd = new Random();
            n = int.Parse(NN.Text);
            m = int.Parse(MM.Text);
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = rnd.Next(0,100);
                }
            return a;
        }
        private void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, VV.Text += Environment.NewLine)
                for (int j = 0; j < a.GetLength(1); ++j)
                    VV.Text += a[i, j] + "  ";
        }
        private void Change(int[,] a, int n)
        {
            VV.Text += Environment.NewLine;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a[i, j] > n)
                        VV.Text += "["+i+","+ j+"]" + "  ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VV.Text = "";
                int n = Convert.ToInt32(CH.Text);
                int q, m;
                int[,] mas = Input(out q, out m);
                Print(mas);
                Change(mas, n);
            }
            catch
            {
                VV.Text = "Неккоректно введены данные";
            }
        }
    }
}
