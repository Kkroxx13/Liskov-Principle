using System;
using System.Collections.Generic;
using System.Text;

namespace LiscovPrinciple
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        { }
        public override int Calculate() => _numbers.Sum();
    }
}
