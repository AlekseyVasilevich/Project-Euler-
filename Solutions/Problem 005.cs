//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            long number = 2520;
            while(true)
            {
                int countOfDivider = 0;
                for (long i=1; i<=20; i++)
                {                
                    if(number% i == 0)
                    {
                        countOfDivider++;
                    }
                }   
                if(countOfDivider == 20)
                {
                    break;
                }
                number += 20;
            }
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;
            Console.WriteLine(number);
            Console.WriteLine("Solution took {0} ms", duration.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
