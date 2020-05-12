using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] Input()
        {
            int n = int.Parse(Nn.Text);
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
            {
                a[i] = rand.Next(-100, 200);
            }
            return a;
        }
        public void Print(int[] a)
        {
            string str = "";
            for (int i = 0; i < a.GetLength(0); ++i)
            str += a[i] + " ";
            mas.Text = Convert.ToString(str);
        }


        public void Change(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; ++i)
                sum += a[i];
            if (sum <= 999 && sum > 99)
            rez.Text = Convert.ToString("Сумма всех элементов массива: " + sum+ Environment.NewLine+ "Сумма является трехзначным числом");
            else
            rez.Text = Convert.ToString("Сумма всех элементов массива: " + sum + Environment.NewLine + "Сумма не является трехзначным числом");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] myArray = Input();
                Print(myArray);
                Change(myArray);
            }
            catch { rez.Text = Convert.ToString("Некорректный ввод!"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rez.Clear();
            mas.Clear();
            Nn.Clear();
        }
    }
}
