using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
    
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

  
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn0.Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textBox1.Text += btndot.Text;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }
    }
}
