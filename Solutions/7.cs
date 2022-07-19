//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//What is the 10 001st prime number?
using System;

namespace _7
{
    internal class Program
    {
        static bool isPrime(int num)
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
            int counter = 3;
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
            DateTime startTime=DateTime.Now; 
            int numOfPrime=1;
            int num=1;
            while(numOfPrime < 10001)
            {
                num+=2;
                if (isPrime(num))
                {
                    numOfPrime++;
                }
                
            }
            Console.WriteLine(num);
            DateTime stopTime=DateTime.Now;
            TimeSpan duration=stopTime - startTime;
            Console.WriteLine("Solutions took - " + duration.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
