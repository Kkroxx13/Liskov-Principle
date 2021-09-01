using System;
using System.Collections.Generic;
using System.Text;

namespace LiscovPrinciple
{
    public class EvenSumCalculator : Calculator
    {
        public EvenSumCalculator(int[] numbers) : base(numbers) { }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();

    }
}
