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
            zadanie = stepen.Next(1, 13);
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
                n = 3;
                a = 512;
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
            if (zadanie == 8)
            {
                n = 8;
                a = 1;
            }
            if (zadanie == 9)
            {
                n = 3;
                a = -1;
            }
            if (zadanie == 10)
            {
                n = 5;
                a = -1;
            }
            if (zadanie == 11)
            {
                n = 9;
                a = 512;
            }
            if (zadanie == 12)
            {
                n = 10;
                a = 1024;
            }
            if (zadanie == 13)
            {
                n = 2;
                a = 128;
            }
            label1.Text = n.ToString();
            label2.Text = ("√" + a).ToString();
            s = Math.Pow((double)a, (double)1 / n);
        }

       
        

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.pervaya.Show();

        }
    }
}
