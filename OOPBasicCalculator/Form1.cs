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
        encapsulationClass mv = new encapsulationClass();
        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + zeroNum.Text;
        }
        private void oneNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + oneNum.Text;
        }
        private void twoNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + twoNum.Text;
        }
        private void threeNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + threeNum.Text;
        }
        private void fourNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + fourNum.Text;
        }
        private void fiveNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + fiveNum.Text;
        }
        private void sixNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + sixNum.Text;
        }
        private void sevenNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + sevenNum.Text;
        }
        private void eightNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
            }
            outputTxtBox.Text = outputTxtBox.Text + eightNum.Text;
        }
        private void nineNumbtn_Click(object sender, EventArgs e)
        {
            if (mv.OperationPressed)
            {
                outputTxtBox.Text = "";
                mv.OperationPressed = false;
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
            mv.Operation = "";
            pointbtn.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mv.Operation = "+";
            mv.FirstInput = float.Parse(outputTxtBox.Text);
            mv.OperationPressed = true;
            pointbtn.Enabled = true;
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            mv.Operation = "-";
            mv.FirstInput = float.Parse(outputTxtBox.Text);
            mv.OperationPressed = true;
            pointbtn.Enabled = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            mv.Operation = "x";
            mv.FirstInput = float.Parse(outputTxtBox.Text);
            mv.OperationPressed = true;
            pointbtn.Enabled = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            mv.Operation = "/";
            mv.FirstInput = float.Parse(outputTxtBox.Text);
            mv.OperationPressed = true;
            pointbtn.Enabled = true;
        }

        private void equalsButton(object sender, EventArgs e)
        {
            mv.SecondInput = float.Parse(outputTxtBox.Text);
            if (mv.Operation == "+")
            {
                mv.Addition();
            }
            else if (mv.Operation == "-")
            {
                mv.Substraction();
            }
            else if (mv.Operation == "x")
            {
                mv.Multiplication();
            }
            else if (mv.Operation == "/")
            {
                mv.Division();
            }
            else
            {
                MessageBox.Show("No operation inputted.");
            }

            outputTxtBox.Text = mv.SecondInput.ToString();
            mv.Operation = "";
        }     
    }
}
