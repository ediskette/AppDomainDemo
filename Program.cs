using System;
using System.Diagnostics;
using DemoLibrary;


namespace AppDomainDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessRequestBatch();
            GC.Collect();
            Console.WriteLine("Completed the batch press enter to continue");
            Console.ReadLine();
        }

        private static void ProcessRequestBatch() {
            Stopwatch watch = new Stopwatch();
            Processor demoProcessor = new Processor();
            watch.Start();

            for (int index = 0; index < 10000; index++)
            {
                int id = index % 5000;
                Console.WriteLine(demoProcessor.ProcessRequest(id));

            }

            watch.Stop();
            Console.WriteLine("The processing took {0} ms to complete...", watch.ElapsedMilliseconds);
        }
    }
}
