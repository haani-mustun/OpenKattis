using System;

namespace Tarifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int StandardRateX = int.Parse(Console.ReadLine());
            int NumberOfMonths = int.Parse(Console.ReadLine());
            int[] NumOfMegabytes = new int[NumberOfMonths];
            for (int i = 0; i < NumberOfMonths; i++)
            {
                NumOfMegabytes[i] = int.Parse(Console.ReadLine());
            }

            int PassOver = 0;
            foreach(int i in NumOfMegabytes)
            {
                PassOver += (StandardRateX - i);
            }
            PassOver += StandardRateX;
            Console.WriteLine(PassOver);
        }
    }
}
