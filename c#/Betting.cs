using System;

namespace Betting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Percentage = float.Parse(Console.ReadLine()) / 100;
            Console.WriteLine(1 / Percentage);
            Console.WriteLine(1 / (1 - Percentage));
        }
    }
}
