using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class CalculatorOperation : CalculatorBase
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }

        public override int Multiply(int x, int y)
        {
            return x * y;
        }

        public override int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
