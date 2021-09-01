using System;
using System.Linq;

namespace LiscovPrinciple
{ 
   
    
   
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine("The Sum of all numbers is {0}",sum.Calculate());

            Calculator evensum = new EvenSumCalculator(numbers);
            Console.WriteLine("The sum of all even numbers is {0}",evensum.Calculate());

        }
    }
}
