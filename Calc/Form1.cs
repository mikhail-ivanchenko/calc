﻿using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private int i;

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

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, res;

            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            res = a + b;
            textBox3.Text = res.ToString();
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



        private void button5_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            float res;

            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            res = a % b;
            textBox3.Text = res.ToString();
            
             
               
            

          
            
               
            
        }
    }
}
