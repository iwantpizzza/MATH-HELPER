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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.pervaya.Show();
        }
        public static string theme;

        private void label2_Click(object sender, EventArgs e)
        {
            if (Form1.p_or_t == 1)
            {
                Form3 f3 = new Form3();
                f3.Show();
                theme = "Корень n-й степени из действительного числа";
                this.Close();
            }
            if (Form1.p_or_t == 2)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1.pervaya.Show();
              
            
        }
    }
}
