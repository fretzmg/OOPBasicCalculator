using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicCalculator
{
    class encapsulationClass
    {
        string operation = "";
        float firstInput = 0;
        public float secondInput = 0;
        bool operationPressed = false;

        public string Operation { get => operation; set => operation = value; }
        public float FirstInput { get => firstInput; set => firstInput = value; }
        public bool OperationPressed { get => operationPressed; set => operationPressed = value; }
        public float SecondInput { get => secondInput; set => secondInput = value; }
        public void Addition()
        {
            SecondInput = FirstInput + secondInput;
        }
        public void Substraction()
        {
            SecondInput = FirstInput - secondInput;
        }
        public void Multiplication()
        {
            SecondInput = FirstInput * secondInput;
        }
        public void Division()
        {
            SecondInput = FirstInput / secondInput;
        }
    }
}
