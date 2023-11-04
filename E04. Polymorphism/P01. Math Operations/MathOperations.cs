using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class MathOperations
    {
        public int Add(int firstValue, int secondValue) 
        {
            return firstValue + secondValue;
        }
        public double Add(double firstValue, double secondValue, double thirdValue) 
        {
            return firstValue + secondValue + thirdValue;
        }
        public decimal Add(decimal firstValue, decimal secondValue, decimal thirdValue) 
        {
            return firstValue + secondValue + thirdValue;
        }
    }
}
