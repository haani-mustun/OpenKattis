using System;

namespace R2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int difference = input[1] - input[0];
            Console.WriteLine(input[1] + difference);
        }
    }
}
