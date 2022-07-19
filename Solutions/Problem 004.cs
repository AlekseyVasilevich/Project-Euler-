//A palindromic number reads the same both ways.
//The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.
using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max = 1;
            for(int i=100; i<=999; i++)
            {
                for(int j=i; j<=999; j++)
                {
                    num = i * j;
                    if(IsPalindrome(num)==true)
                    {
                        if(num>max)
                        {
                            max = num;
                        }            
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }

        static bool IsPalindrome(int num)
        {
            int numLength = GetLength(num);
            int[] digits = new int[numLength];
            for (int i = numLength - 1; i >= 0; i--)
            {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength / 2; i++)
            {
                if (digits[i] != digits[numLength - i - 1])
                    return false;
            }
            return true;
        }

        static int GetLength(int num)
        {
            int n = 0;
            while (num > 0)
            {
                num /= 10;
                n++;
            }
            return n;
        }
    }
}
