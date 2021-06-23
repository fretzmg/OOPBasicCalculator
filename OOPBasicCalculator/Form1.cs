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

        string operation = "";
        double outputValue = 0;
        

        public Calculator()
        {
            InitializeComponent();
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + sixNum.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + threeNum.Text;
        }

        private void twoNum_Click(object sender, EventArgs e)
        {          
            if (operation.Length > 0)     
            {
                outputTxtBox.Text = "";  
            }
            outputTxtBox.Text = outputTxtBox.Text + twoNum.Text;
        }

        private void nineNum_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + nineNum.Text;
        }

        private void sevenNum_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + sevenNum.Text;
        }

        private void eightNum_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + eightNum.Text;
        }

        private void fourNum_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + fourNum.Text;
        }

        private void fiveNum_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + fiveNum.Text;
        }

        private void oneNum_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + oneNum.Text;
        }

        private void zeroNum_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                outputTxtBox.Text = "";
            }
            outputTxtBox.Text = outputTxtBox.Text + zeroNum.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            outputTxtBox.Clear();
            outputValue = 0;
            operation = "";
            point.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + point.Text;
            point.Enabled = false;
        }

        private void outputTxtBox_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = " ";
            operation = "";
            point.Enabled = true;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button btnOperation = (Button)sender;
            operation = btnOperation.Text;
            outputValue = double.Parse(outputTxtBox.Text);
            point.Enabled = true;
        }

        private void equalsButton(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    outputTxtBox.Text = (outputValue + double.Parse(outputTxtBox.Text)).ToString();
                    break;
                case "-":
                    outputTxtBox.Text = (outputValue - double.Parse(outputTxtBox.Text)).ToString();
                    break;
                case "*":
                    outputTxtBox.Text = (outputValue * double.Parse(outputTxtBox.Text)).ToString();
                    break;
                case "/":
                    outputTxtBox.Text = (outputValue / double.Parse(outputTxtBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation = "";
        }

        
    }
}
