using System;

namespace Priemgetallen
{
    class Program
    {
        static long numberToFactor = 600851475143;

        static void Main(string[] args)
        {
            Console.WriteLine(LargestPrimeFactorOf(numberToFactor));
            Console.ReadKey();
        }

        static long LargestPrimeFactorOf(long n)
        {
            long lastPrimeFactor = 0;

            for (long i = 2; i < n; i++)
            {
                if (isPrime(i) && n % i == 0)
                {
                    lastPrimeFactor = i;
                    Console.WriteLine(i + " is a prime factor of " + n);
                }
            }

            return lastPrimeFactor;
        }

        static bool isPrime(long n)
        {
            if (n == 2) return true;
            if ((n > 2 && n % 2 == 0) || n == 1) return false;

            for (long i = 2; i <= Math.Floor(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
