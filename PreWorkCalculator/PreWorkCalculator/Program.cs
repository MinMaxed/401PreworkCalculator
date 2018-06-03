using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //store result
            double result = 0;

            //Obtain First Number
            Console.WriteLine("First Number:");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            //Obtain Second Number
            Console.WriteLine("Second Number:");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            // Operation to perform on the numbers
            Console.WriteLine("Operation Type +, -, *, /, ^ (exponent)");
            string stringOperationType = Console.ReadLine();

            // Calculations based on Operation choice
            if (stringOperationType == "+")
            {
                result = firstNum + secondNum;
            }
            else if (stringOperationType == "-")
            {
                result = firstNum - secondNum;
            }
            else if (stringOperationType == "*")
            {
                result = firstNum * secondNum;
            }
            else if (stringOperationType == "/")
            {
                result = firstNum / secondNum;
            }
            else if (stringOperationType == "^")
            {
                result = Math.Pow(firstNum, secondNum);
            }

            //display solution. Future Work: Want to be able to continue to use results
            Console.WriteLine("\nResult of " + firstNum + " " + stringOperationType + " " + secondNum + " = " + result);
            Console.ReadKey();
        }
    }
}