using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
            SayName(textBoxName.Text);
        }

        /// <summary>
        /// Test Function written for demo
        /// </summary>
        /// <param name="text"></param>
        private void SayName(string text)
        {
            // Name of the employee will be printed.

            /* The line of comments*/

            labelResult.Text = "Hello : " + text;
        }
    }
}
