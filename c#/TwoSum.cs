using System;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            Console.WriteLine(input[0] + input[1]);
        }
    }
}
