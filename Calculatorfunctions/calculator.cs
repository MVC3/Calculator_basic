using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculatorfunctions
{
    public class calculator
    {
        public int calculate(int a, int b, string Operator)
        {
            
            if (c == OperatorType.Add)
            { 
            }
            return ;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Substract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }



    
    }

    public enum OperatorType
    { 
    Add= "+",
    Substract = "-",
    Multiply = "3",
    Divide = "4",
    }
}
