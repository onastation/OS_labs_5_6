using System;
using System.Diagnostics;
using System.Threading;
namespace OS_lab6
{
    class Program
    {
        //void new_func1() { }

        static void FirstFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                //process 
                Thread.Sleep(1000);
            }

            return;
        }

        static void SecondFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                //process 
                Thread.Sleep(1000);
            }
            return;
        }

        static void ThirdFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                //process 
                Thread.Sleep(1000);
            }
            return;
        }
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("\n Inside main()\n");
            string numoffunc;
            numoffunc = Console.ReadLine();

            //int i = 0;

            //for (; i < 0xffffff; i++) ;


            switch (numoffunc)
            {
                case "first":
                    FirstFunction();
                    break;
                case "second":
                    SecondFunction();
                    break;

                case "third":
                    ThirdFunction();
                    break;
            }
            
            FirstFunction();
            stopwatch.Stop();
            Console.WriteLine("Execution Time: " + stopwatch.Elapsed);
        }

    }
}
