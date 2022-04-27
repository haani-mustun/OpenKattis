using System;

namespace Planina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int interations = int.Parse(Console.ReadLine());

            int startSqrted = 2;
            int rateOfIncrease = 1;

            for (int i = 0; i < interations; i++)
            {
                startSqrted += rateOfIncrease;
                rateOfIncrease *= 2;
            }

            int total = startSqrted * startSqrted;

            Console.WriteLine(total);
        }
    }
}
