using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Sample
{
    public partial class Form1 : Form
    {
        private double previousNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "0";
        }


        /// <summary>
        /// Event for Plus button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            previousNumber = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "";
        }


        private double Add(double x,double y)
        {
            return x + y;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(textBox_Result.Text);

            //previousNumber
            //secondNumber

            textBox_Result.Text = Add(previousNumber, secondNumber).ToString();
        }
    }
}
