using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public abstract class CalculatorBase
    {
        public abstract int Add(int x, int y);
        public abstract int Subtract(int x, int y);
        public abstract int Multiply(int x, int y);

    }
}
