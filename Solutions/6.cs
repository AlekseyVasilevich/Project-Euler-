//The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385
//The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            int sum=0, sum1=0, sum2=0;
            for(int i=1; i<=100; i++)
            {
                sum1 += Convert.ToInt32(Math.Pow(i, 2));
            }
          
            for(int i=1; i<=100; i++)
            {
                sum2 += i;
            }
            sum2 = Convert.ToInt32(Math.Pow(sum2, 2));

            sum = sum2 - sum1;
            DateTime stopTime=DateTime.Now;
            TimeSpan duration=stopTime - startTime;
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("Solution took {0} ms", duration.TotalMilliseconds);
            Console.ReadLine();

        }
    }
}
