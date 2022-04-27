using System;

namespace WhichIsGreater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            if (inputs[0] > inputs[1])
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
