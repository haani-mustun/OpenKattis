using System;

namespace HeartRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                float[] BeatsAndTime = Array.ConvertAll(Console.ReadLine().Split(' '), s => float.Parse(s));
                float bpm = (60 * BeatsAndTime[0]) / BeatsAndTime[1];
                float minbpm = bpm - (60 / BeatsAndTime[1]);
                float maxbpm = bpm + (60 / BeatsAndTime[1]);

                Console.WriteLine(minbpm + " " + bpm + " " + maxbpm);
            }
        }
    }
}
