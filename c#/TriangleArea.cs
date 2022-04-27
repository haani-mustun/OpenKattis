using System;

namespace TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), s => float.Parse(s));

            Console.WriteLine((inputs[0] * inputs[1]) / 2);
        }
    }
}
