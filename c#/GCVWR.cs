using System;

namespace GCVWR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] WeightAndItems = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int[] ItemWeights = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            float GminusT = (WeightAndItems[0] - WeightAndItems[1]) * 0.9f;
            int CombinedItemWeight = 0;
            for (int i = 0; i < WeightAndItems[2]; i++)
            {
                CombinedItemWeight += ItemWeights[i];
            }
            Console.WriteLine(GminusT - CombinedItemWeight);
        }
    }
}
