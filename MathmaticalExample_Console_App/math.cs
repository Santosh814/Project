using System;
using System.Collections.Generic;
using System.Text;

namespace MathmaticalExample_Console_App
{
    public class math
    {
        public string Addition(double a, double b)
        {
            double c = a + b;

            return Convert.ToString(c);
        }

        public string Subtraction(double a, double b)
        {
            double c = a - b;

            return Convert.ToString(c);
        }

        public string Division(double a, double b)
        {
            double c = 0.0;
            if (b != 0)
            {
                c = a / b;

                return Convert.ToString(c);
            }
            else {
                return "divide by 0 not possible";
            }
            
        }

        public string Multiplication(double a, double b)
        {
            double c = a * b;

            return Convert.ToString(c);
        }
    }
}
