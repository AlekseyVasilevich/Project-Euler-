//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?

using System;

namespace _3
{
    class Program
    {
        static void Main()
        {
            long n = 600851475143;
            long largestPrimeFactor = 2;
            while(true)
            {
                if(n % largestPrimeFactor == 0)
                {
                    n /= largestPrimeFactor;
                }
                if(n == 1)
                {
                    break;
                }
                largestPrimeFactor++;
            }
            Console.WriteLine(largestPrimeFactor);
        }
    }
}

