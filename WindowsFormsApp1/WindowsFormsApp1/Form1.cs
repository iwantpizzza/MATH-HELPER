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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string rejim;
        private void button1_Click(object sender, EventArgs e)
        {
            p_or_t = 1;
            Form2 themi = new Form2();
            themi.Show();
            this.Hide();
          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public static Form1 pervaya = new Form1();
        public static int p_or_t;
       
        private void button2_Click(object sender, EventArgs e)
        {
            p_or_t = 2;
            Form2 themi = new Form2();
            themi.Show();
            this.Hide();


        }
    }
}
