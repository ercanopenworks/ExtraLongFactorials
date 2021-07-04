using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            extraLongFactorials(n);
        }

        private static void extraLongFactorials(int n)
        {
            BigInteger factorial = 1;
            while (n > 0)
            {
                factorial *= n;
                n--;
            }

            Console.WriteLine(factorial);
        }
    }
}
