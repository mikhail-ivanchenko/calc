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

        private void button3_Click(object sender, EventArgs e)
        {
            float A, B, RES;
            A = float.Parse(textBox1.Text);
            B = float.Parse(textBox2.Text);
            RES = A /B;
            textBox3.Text = RES.ToString();
        }
    }
}
