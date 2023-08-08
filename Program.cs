using Calculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorOperation calculator = new CalculatorOperation();

            int x = 10;
            int y = 20;

            Console.WriteLine($"Add : {calculator.Add(x, y)}");
            Console.WriteLine($"Subtract : {calculator.Subtract(x, y)}");
            Console.WriteLine($"Multiply : {calculator.Multiply(x, y)}");
            Console.ReadLine();




        }
    }
}
