using System;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 1;
            int newLast = 0;
            int sum = 0;

            Console.WriteLine(first);

            while (newLast <= 4000000)
            {
                newLast = first + second;

                Console.WriteLine(first + second);

                if (newLast % 2 == 0)
                {
                    sum += newLast;
                }

                first = second;
                second = newLast;
                
            }
            Console.WriteLine("Solution = " + sum);
        }
    }
}
