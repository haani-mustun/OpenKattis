using System;

namespace QALY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumOfPeriods = int.Parse(Console.ReadLine());
            float cumulativeQALY = 0.0f;

            for (int i = 0; i < NumOfPeriods; i++)
            {
                float[] values = Array.ConvertAll(Console.ReadLine().Split(' '), s => float.Parse(s));
                cumulativeQALY += values[0] * values[1];
            }

            Console.WriteLine(cumulativeQALY);
        }
    }
}
