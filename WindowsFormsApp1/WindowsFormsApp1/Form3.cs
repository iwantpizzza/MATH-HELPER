using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.pervaya.Show();
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            if (Form2.theme == "Корень n-й степени из действительного числа")
            {
                FileStream load = new FileStream("math\\Корень n-й степени из действительного числа\\test.txt", FileMode.Open);
                StreamReader read = new StreamReader(load);
                label1.Text = read.ReadToEnd();
                read.Close();
                label2.Text = Form2.theme;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            this.Close();

            

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}
