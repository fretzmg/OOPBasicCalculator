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
        float firstInput = 0;
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
            firstInput = 0;
            operation = "";
            point.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + point.Text;
            point.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = " ";
            operation = "";
            point.Enabled = true;
        }
        private void equalsButton(object sender, EventArgs e)
        {          
            if (operation == "+")
            {
                Addition();
            }
            else if (operation == "-")
            {
                Substraction();
            }
            else if (operation == "x")
            {
                Multiplication();
            }
            else if (operation == "/")
            {
                Division();
            }
            else
            {
                MessageBox.Show("Further calculations cannot be executed!");

            }
            operation = "";
        }
        private void Addition()
        {
            outputTxtBox.Text = (firstInput + float.Parse(outputTxtBox.Text)).ToString();
        }
        private void Substraction()
        {
            outputTxtBox.Text = (firstInput - float.Parse(outputTxtBox.Text)).ToString();
        }
        private void Multiplication()
        {
            outputTxtBox.Text = (firstInput * float.Parse(outputTxtBox.Text)).ToString();
        }
        private void Division()
        {
            outputTxtBox.Text = (firstInput / float.Parse(outputTxtBox.Text)).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstInput = float.Parse(outputTxtBox.Text);
            point.Enabled = true;
        }
        private void btnSubstract_Click(object sender, EventArgs e)
        {
            operation = "-";
            firstInput = float.Parse(outputTxtBox.Text);
            point.Enabled = true;
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "x";
            firstInput = float.Parse(outputTxtBox.Text);
            point.Enabled = true;
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation = "/";
            firstInput = float.Parse(outputTxtBox.Text);
            point.Enabled = true;
        }
    }
}
