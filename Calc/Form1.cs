using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, res;

            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            res = a + b;
            textBox3.Text = res.ToString();
        }
    }
}
