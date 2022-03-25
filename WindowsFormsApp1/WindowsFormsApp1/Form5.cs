using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static  double s;
        public static int zadanie;
        public static int a;
        public static int n;
        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            a = s.ToString();
            if (a==textBox1.Text)
            {
                label3.Text = "Правильно";
            }
            else { label3.Text = "Неправильно"; }
            
        }

        

        private void Form5_Shown(object sender, EventArgs e)
        {
            int n = 0, a = 0, zadanie;
            Random stepen = new Random();
            zadanie = stepen.Next(1, 7);
            if (zadanie == 1)
            {
                n = 2;
                a = 4;
            }
            if (zadanie == 2)
            {
                n = 2;
                a = 16;
            }
            if (zadanie == 3)
            {
                n = 2;
                a = 4;
            }
            if (zadanie == 4)
            {
                n = 3;
                a = 8;
            }
            if (zadanie == 5)
            {
                n = 3;
                a = 64;
            }
            if (zadanie == 6)
            {
                n = 5;
                a = 32;
            }
            if (zadanie == 7)
            {
                n = 7;
                a = 128;
            }

            s = Math.Pow((double)a, (double)1 / n);
            label1.Text = n.ToString();
            label2.Text = ("√" + a).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random stepen = new Random();
            zadanie = stepen.Next(1, 7);
            if (zadanie == 1)
            {
                n = 2;
                a = 4;
            }
            if (zadanie == 2)
            {
                n = 2;
                a = 16;
            }
            if (zadanie == 3)
            {
                n = 2;
                a = 4;
            }
            if (zadanie == 4)
            {
                n = 3;
                a = 8;
            }
            if (zadanie == 5)
            {
                n = 3;
                a = 64;
            }
            if (zadanie == 6)
            {
                n = 5;
                a = 32;
            }
            if (zadanie == 7)
            {
                n = 7;
                a = 128;
            }
            label1.Text = n.ToString();
            label2.Text = ("√" + a).ToString();
            s = Math.Pow((double)a, (double)1 / n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }
    }
}
