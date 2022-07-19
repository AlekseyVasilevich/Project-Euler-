//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.
using System;

namespace _10
{
    internal class Program
    {
        static bool isPrime(long num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            if (num % 2 == 0)
            {
                return false;
            }
            long counter = 3;
            while ((counter * counter) <= num)
            {
                if (num % counter == 0)
                {
                    return false;
                }
                else
                {
                    counter += 2;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            long sum = 2;
            for(long i=3; i<=2000000; i+=2)
            {
                if(isPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum=" + sum);
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;
            Console.WriteLine("Total time: " + duration.TotalSeconds);
        }
    }
}
