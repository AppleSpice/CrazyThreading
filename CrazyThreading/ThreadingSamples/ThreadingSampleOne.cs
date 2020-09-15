using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CrazyThreading.ThreadingSamples
{
    class ThreadingSampleOne
    {
        static Random randomObject = new Random();
        public static void DemoThread()
        {
            Thread sampleThread1 = new Thread(new ThreadStart(SampleThreadOne));
            Thread sampleThread2 = new Thread(new ThreadStart(SampleThreadTwo));
            Thread sampleThread3 = new Thread(new ThreadStart(SampleThreadThree));

            sampleThread1.Start();
            sampleThread2.Start();
            sampleThread3.Start();

            Console.ReadKey();
            sampleThread1.Abort();
            sampleThread2.Abort();
            sampleThread3.Abort();
        }
        

        static void SampleThreadOne()
        {
            while(true)
            {
                Console.WriteLine("Line 1");
                Thread.Sleep(5000);
            }
        }

        static void SampleThreadTwo()
        {
            while (true)
            {
                Console.WriteLine("agaggagaggagagagagagagaggagag thread 2");
                Thread.Sleep(3000);
            }
        }

        static void SampleThreadThree()
        {
            while (true)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                int numberOfSecondsToSleep = randomObject.Next((10) + 1);
                Console.WriteLine("Have a Good day");
                Thread.Sleep(numberOfSecondsToSleep * 1000);
            }
        }
    }

    
}


/*
Documentation
https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread?view=netcore-3.1

https://docs.microsoft.com/en-us/dotnet/standard/threading/using-threads-and-threading
*/