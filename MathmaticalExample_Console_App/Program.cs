using System;
using System.Text.RegularExpressions;

namespace MathmaticalExample_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number");
            string  a = Console.ReadLine();
            bool isNumeric= false;
            do
            {
                isNumeric = double.TryParse(a, out double n);
                if (isNumeric == false)
                { 
                    Console.WriteLine("Enter Value is not number");
                    Console.WriteLine("Please Enter First Number");
                    a = Console.ReadLine();
                }
            } while (isNumeric == false);

            isNumeric = false;

            Console.WriteLine("Please Enter Second Number");
            string b = Console.ReadLine();

            do
            {
                isNumeric = double.TryParse(a, out double n);
                if (isNumeric == false)
                {
                    Console.WriteLine("Enter Value is not number");
                    Console.WriteLine("Please Enter Second Number");
                    b = Console.ReadLine();
                }
            } while (isNumeric == false);

            math obj = new math();
            Console.WriteLine("Addition of Number=={0}",obj.Addition(Convert.ToDouble(a), Convert.ToDouble(b)));
            Console.WriteLine("Subtraction of Number== {0}",obj.Subtraction(Convert.ToDouble(a), Convert.ToDouble(b)));
            Console.WriteLine("Division of Number== {0}",obj.Division(Convert.ToDouble(a), Convert.ToDouble(b)));
            Console.WriteLine("Multiplication of Number == {0}",obj.Multiplication(Convert.ToDouble(a), Convert.ToDouble(b)));

            Console.ReadKey();
        }
    }
}
