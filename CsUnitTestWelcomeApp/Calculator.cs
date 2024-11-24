using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUnitTestWelcomeApp
{
    public class Calculator
    {
        public int Sum(int x, int y)
        { 
            return x + y; 
        }
        public int Mult(in int x, in int y)
        {
            return x * y;
        }
    }
}
