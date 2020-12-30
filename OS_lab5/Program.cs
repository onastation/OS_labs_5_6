using System;
using System.Diagnostics;
namespace OS_lab5
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int[,] AD = new int[2,2];
            int res = 0;

            for (int j = 500000000; j > 0; j--)
            {
                //AD[0, 0]++;
                //AD[0, 0]++;
                AD[0, 0] += 2;
            }

            //AD[1, 1] = AD[0, 0];

            Console.WriteLine(AD[0, 0]);
            stopwatch.Stop();
            Console.WriteLine("Execution Time: " + stopwatch.Elapsed);
        }

    }
}
