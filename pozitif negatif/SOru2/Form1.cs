using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            int rnd;
            for (int i = 0; i < 100; i++)
            {
                rnd = random.Next(-100, 101);
                listBox1.Items.Add(rnd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                int a = (int)listBox1.Items[i];
                Pozitif(a);
                Negatif(a);
            }
        }

        private void Pozitif(int a)
        {
            if (a > 0 && radioButton1.Checked)
            {
                üç(a);
                beş(a);
                yedı(a);
            }
        }

        private void Negatif(int a)
        {
            if (a < 0 && radioButton2.Checked)
            {
                üç(a);
                beş(a);
                yedı(a);
            }

        }

        private void yedı(int a)
        {
            if (a % 7 == 0 && yedi.Checked)
            {
                listBox2.Items.Add(a);
            }
        }

        private void beş(int a)
        {
            if (a % 5 == 0 && bes.Checked)
            {
                listBox2.Items.Add(a);
            }
        }

        private void üç(int a)
        {
            if (a % 3 == 0 && uc.Checked)
            {
                listBox2.Items.Add(a);
            }
        }
    }
}
