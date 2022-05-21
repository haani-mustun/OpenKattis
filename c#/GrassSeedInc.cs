using System;

namespace Grass_Seed_Inc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double seedCost = double.Parse(Console.ReadLine());
            int numberOfLawns = int.Parse(Console.ReadLine());
            double totalCost = 0.0f;
            for (int i = 0; i < numberOfLawns; i++)
            {
                double[] lawnDimensions = Array.ConvertAll(Console.ReadLine().Split(' '), s => double.Parse(s));
                double lawnSize = lawnDimensions[0] * lawnDimensions[1];
                totalCost += seedCost * lawnSize;
            }
            Console.WriteLine(totalCost);
        }
    }
}
