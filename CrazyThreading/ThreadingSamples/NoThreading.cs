using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyThreading.ThreadingSamples
{
    class NoThreading
    {

        //This won't work
        public static void NoThreadHere()
        {
            NoThread1();
            NoThread2();
        }

        static void NoThread1()
        {
            while(true)
            {
                Console.WriteLine("Thread 1 moment");
            }
        }

        static void NoThread2()
        {
            while (true)
            {
                Console.WriteLine("Thread 2 moment ahhahahhahahahahahahahaha");
            }
        }
    }
}
