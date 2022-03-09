using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstNum;
        string operation;

        private void button12_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                double secondnum = Convert.ToDouble(textBox1.Text);
                double result = 0;
                switch (operation)
                {
                    case  "+":
                        result = firstNum + secondnum;
                        break;
                    case  "-":
                        result = firstNum - secondnum;
                        break;
                    case "*":
                        result = firstNum * secondnum;
                        break;
                    case "/":
                        if (secondnum !=0)
                        {
                            result = firstNum / secondnum;
                        }
                        break;
                        

                    

                }

                firstNum = result;
                textBox1.Text = result.ToString();





            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string val = "1";
            check(val);

        }
        private void check(string current_value)
        {
            if (textBox1.Text=="0"||textBox1.Text == "+"||textBox1.Text=="-"||textBox1.Text=="*"||textBox1.Text=="/")
            {
                textBox1.Text = current_value;
            }
            else
            {
                textBox1.Text = textBox1.Text + current_value;
            }
            

        }




        private void button2_Click(object sender, EventArgs e)
        {
            string value = "6";
            check(value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value = "8";
            check(value);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string value = "2";
            check(value);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string value = "3";
            check(value);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string value = "4";
            check(value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string value = "5";
            check(value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string value = "7";
            check(value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = "9";
            check(value);

        }
    

        private void button9_Click(object sender, EventArgs e)
        {
            
           


            Dot_button.Enabled = true;
            if (textBox1.Text !=""&& textBox1.Text!= "+")
            {
                string val = textBox1.Text;
                firstNum = Convert.ToDouble(textBox1.Text);
                operation = "+";
                textBox1.Text = "+";
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Dot_button.Enabled = true;
            if (textBox1.Text != "" && textBox1.Text != "*")
            {
                string val = textBox1.Text;
                firstNum = Convert.ToDouble(textBox1.Text);
                operation = "*";
                textBox1.Text = "*";

            }

     
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Dot_button.Enabled = true;
            if (textBox1.Text != "" && textBox1.Text != "/")
            {
                string val = textBox1.Text;
                firstNum = Convert.ToDouble(textBox1.Text);
                operation = "/";
                textBox1.Text = "/";

            }


        }

        private void button16_Click(object sender, EventArgs e)
        {
            Dot_button.Enabled = true;
            if (textBox1.Text != "" && textBox1.Text != "-")
            {
                string val = textBox1.Text;
                firstNum = Convert.ToDouble(textBox1.Text);
                operation = "-";
                textBox1.Text = "-";

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            Dot_button.Enabled = false;
            textBox1.Text = textBox1.Text + ".";

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            textBox1.Text = text.Remove(text.Length - 1, 1);

        }
    }
}
