using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form3 fm = new Form3();
            Utils.Link(fm, panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            Utils.Link(fm, panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            Utils.Link(fm, panel2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            Utils.Link(fm, panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
