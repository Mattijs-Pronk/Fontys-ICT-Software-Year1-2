using System;

namespace Algoritme
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int sum = 0;

            for(int num = 3; num < max; num++)
            {
                if((num % 3 == 0) || (num % 5 == 0))
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
