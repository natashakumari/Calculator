using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natasha_Kumari_Final_Project
{
    class Calculator
    {
        public float Operand1 { get; set; }

        public float Operand2 { get; set; }
        public float Result { get; }

        public Calculator(float op1,float op2)
        {
            Operand1 = op1;
            Operand2 = op2;
        }

        public float Addition(float f1,float f2)
        {
            return f1 + f2;
        }

        public float Subtraction(float f1, float f2)
        {
            return f1 + f2;
        }

        public float Division(float f1, float f2)
        {
            return f1 + f2;
        }

        public float Multiplication(float f1, float f2)
        {
            return f1 + f2;
        }

        //public float Power(float f1, float f2)
        //{

        //    return f1;
        //}

    }
}
