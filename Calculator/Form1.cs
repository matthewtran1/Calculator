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

        double num1;
        double num2;
        string operation;
        double result;
        double sqrtNum;
     
        public Form1()
        {
            InitializeComponent();
        }



        private void btn1_Click(object sender, EventArgs e) //add text to textbox depending on the btn pressed
        {
            textBox1.Text += "1";
         
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btndot_Click(object sender, EventArgs e)       //Does not work yet
        {
            textBox1.Text += ".";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))                //check if textbox is empty
            {
                //do nothing if empty
            }
            else
            {
                operation = "/";                        //Set operation
                num1 = int.Parse(textBox1.Text);        //Set num1 to textbox text
                textBox1.Clear();                       //clear textbox for next input
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                //do nothing
            }
            else
            {
                operation = "*";                        //Set operation
                num1 = int.Parse(textBox1.Text);        //Set num1 to textbox text
                textBox1.Clear();                       //clear textbox for next input
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                //do nothing
            }
            else
            {
                operation = "-";                        //Set operation
                num1 = int.Parse(textBox1.Text);        //Set num1 to textbox text
                textBox1.Clear();                       //clear textbox for next input
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                //do nothing
            }
            else
            {
                operation = "+";                        //Set operation
                num1 = int.Parse(textBox1.Text);        //Set num1 to textbox text
                textBox1.Clear();                        //clear textbox for next input
            }
        }

        private void btnequals_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                //do nothing
            }
            else
            {
                num2 = int.Parse(textBox1.Text);        //num2 is the text after the first clear

                switch (operation)                       //calculate result depending on operation
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
   
                }

                textBox1.Text = result + "";            //convert to string      
            }
        }

        private void button12_Click(object sender, EventArgs e)         //Clear textbox and variables
        {
            textBox1.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btnsqrt_Click(object sender, EventArgs e)          //remove last number inputted
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                //do nothing
            }

            else
            {

               textBox1.Text = textBox1.Text.Remove(textBox1.Text.LastIndexOf(""),1);

            }
          
           
        }

        private void btnsigns_Click(object sender, EventArgs e)         //button to change the sign of the number
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                //do nothing
            }
            else
            {

                if (!textBox1.Text.Contains("-")) //Checks if there is no negative sign, if so add a negative sign at index 0
                {


                    textBox1.Text = textBox1.Text.Insert(0, "-");               


                }

                else if (textBox1.Text.Contains("-"))  //checks if there is a negative  sign, if so remove negative sign
                {

                    textBox1.Text = textBox1.Text.Replace("-", "");

                }
            }

            

        }
    }
}
