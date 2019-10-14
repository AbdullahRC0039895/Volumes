using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void L2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LP2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnC1_Click(object sender, EventArgs e)
        {
            double SR1, SR2, SR3;
            //show when each text box is being used in each set of code//

            try
            {
                SR1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                SR1 = 0.0;
                //if answer is not whole number it will not be seen and will be an error
            }
            try
            {
                SR2 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                SR2 = 0.0;
                //if answer is not whole number it will not be seen and will be an error
            }
            try
            {
                SR3 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                SR3 = 0.0;
                //if answer is not whole number it will not be seen and will be an error
            }

            double resistance = SR1 + SR2 + SR3;
            LT1.Text = "R Total =" + resistance;
            //this is the calculation which is used to calculate the total resistance//
        }

        private void BtnC2_Click(object sender, EventArgs e)
        {
            double PR1, PR2, PR3;
            //show when each text box is being used in each set of code//

            try
            {
                PR1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                PR1 = 0.0;
                //if answer is not whole number it will not be seen and will be an error
            }
            try
            {
                PR2 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                PR2 = 0.0;
                //if answer is not whole number it will not be seen and will be an error
            }
            try
            {
                PR3 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                PR3 = 0.0;
                //if answer is not whole number it will not be seen and will be an error
            }

            double resistance = 1 / ((1 / PR1) + (1 / PR2) + (1 / PR3));
            LT.Text = "R Total =" + resistance;
            //This is the calculation which is used to calculate the total resistance//
        }
    }
}
