using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                                        float c;
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            c = a - b;
            textBox3.Text =  c.ToString();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            float A = float.Parse(textBox1.Text);
            float B = float.Parse(textBox2.Text);
            float result;
            result = A * B;
            textBox3.Text = result.ToString();
        }


    }
}
