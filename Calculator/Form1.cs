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

        private void button1_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";      //Clears textbox
            input += "1";
            this.textBox1.Text += input;  //Add input to the textbox

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;


        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;


        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;

        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;

        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;

        }

        private void button10_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;

        }

        private void button11_Click(object sender, EventArgs e) //dot
        {

            input += ".";

        }

        private void button15_Click(object sender, EventArgs e) //divide sign
        {

            operand1 = input;          //set first input
            operation = '/';           //set operation
            input = string.Empty;      //clear input to record next value

        }
        private void button16_Click(object sender, EventArgs e) //multiply
        {

            operand1 = input;
            operation = '*';
            input = string.Empty;

        }
        private void button17_Click(object sender, EventArgs e) //minus
        {

            operand1 = input;
            operation = '-';
            input = string.Empty;

        }
        private void button18_Click(object sender, EventArgs e) //plus
        {

            operand1 = input;
            operation = '+';
            input = string.Empty;

        }

        private void button19_Click(object sender, EventArgs e) //equals
        {



        }



    }
}
