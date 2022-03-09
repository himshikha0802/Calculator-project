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
            if (textBox1.Text == "+")
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
            textBox1.Text = textBox1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !=""&& textBox1.Text!= "+")
            {
                string val = textBox1.Text;
                firstNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "+";
                operation = "+";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
