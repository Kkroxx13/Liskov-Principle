using System;
using System.Collections.Generic;
using System.Text;

namespace LiscovPrinciple
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;
        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();
    }

}
