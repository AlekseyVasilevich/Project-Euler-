//A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//a^2 + b^2 = c^2
//For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.
using System;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            int a = 0, b = 0, c = 0;
            int sum = 1000;
            bool found = false;
            for (a = 1; a < sum / 3; a++)
            {
                for (b = a; b < sum / 2; b++)
                {
                    c = sum - (a + b);
                    if (a * a + b * b == c * c)
                    {
                        found = true;
                        break;
                    }
                }
                if (found==true)
                {
                    break;
                }
            }
            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine(a * b * c);
            DateTime endTime = DateTime.Now;
            TimeSpan duration = endTime - startTime;
            Console.WriteLine(duration.TotalMilliseconds);
            Console.ReadKey();
            
        }
    }
}
