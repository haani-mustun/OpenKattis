using System;

namespace NastyHacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                int[] revenueValues = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                if (revenueValues[1] - revenueValues[2] > revenueValues[0])
                {
                    Console.WriteLine("advertise");
                }
                else if (revenueValues[1] - revenueValues[2] == revenueValues[0])
                {
                    Console.WriteLine("does not matter");
                }
                else
                {
                    Console.WriteLine("do not advertise");
                }
            }
        }
    }
}
