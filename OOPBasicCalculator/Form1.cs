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
        bool operationPressed = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void zeroNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + zeroNum.Text;
        }
        private void oneNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + oneNum.Text;
        }
        private void twoNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + twoNum.Text;
        }
        private void threeNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + threeNum.Text;
        }
        private void fourNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + fourNum.Text;
        }
        private void fiveNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + fiveNum.Text;
        }
        private void sixNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + sixNum.Text;
        }
        private void sevenNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + sevenNum.Text;
        }
        private void eightNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + eightNum.Text;
        }
        private void nineNumbtn_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                outputTxtBox.Text = "";
                operationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + nineNum.Text;
        }
        private void pointbtn_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = outputTxtBox.Text + pointbtn.Text;
            pointbtn.Enabled = false;
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {
            outputTxtBox.Clear();
            pointbtn.Enabled = true;
        }
        private void CEbtn_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = " ";
            operation = "";
            pointbtn.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstInput = float.Parse(outputTxtBox.Text);
            operationPressed = true;
            pointbtn.Enabled = true;
        }
        private void btnSubstract_Click(object sender, EventArgs e)
        {
            operation = "-";
            firstInput = float.Parse(outputTxtBox.Text);
            operationPressed = true;
            pointbtn.Enabled = true;
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "x";
            firstInput = float.Parse(outputTxtBox.Text);
            operationPressed = true;
            pointbtn.Enabled = true;
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation = "/";
            firstInput = float.Parse(outputTxtBox.Text);
            operationPressed = true;
            pointbtn.Enabled = true;
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
                MessageBox.Show("No operation inputted.");

            }
            operation = "";
        }      
    }
}
