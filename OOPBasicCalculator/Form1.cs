using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBasicCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + sixNum.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + threeNum.Text;
        }

        private void equals_Click(object sender, EventArgs e)
        {

        }

        private void twoNum_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + twoNum.Text;
        }

        private void nineNum_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + nineNum.Text;
        }

        private void sevenNum_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + sevenNum.Text;
        }

        private void eightNum_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + eightNum.Text;
        }

        private void fourNum_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + fourNum.Text;
        }

        private void fiveNum_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + fiveNum.Text;
        }

        private void oneNum_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + oneNum.Text;
        }

        private void zeroNum_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + zeroNum.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + point.Text;
            

        }

        private void outputTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!outputTxtBox.Text.Contains("."))
            {
                point.Enabled = true;
            }
            else
            {
                
                point.Enabled = false;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = " ";
        }
    }
}
