using System;

namespace JumboJavelin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfJavelins = int.Parse(Console.ReadLine());
            int[] javelinLengths = new int[numOfJavelins];

            for (int i = 0; i < numOfJavelins; i++)
            {
                javelinLengths[i] = int.Parse(Console.ReadLine());
            }

            int totalLength = 0;

            for (int i = 0; i < javelinLengths.Length; i++)
            {
                totalLength += javelinLengths[i];
            }

            Console.WriteLine(totalLength - numOfJavelins + 1);
        }
    }
}
