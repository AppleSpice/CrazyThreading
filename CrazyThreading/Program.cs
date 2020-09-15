using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCrazyPC();
        }

        static void RunCrazyPC()
        {
            ThreadingSamples.CrazyPC.CrazyFunctionCall();
        }

        static void RunThreadingSampleOne()
        {
            ThreadingSamples.ThreadingSampleOne.DemoThread();
            
        }

        static void RunNoThreading()
        {
            ThreadingSamples.NoThreading.NoThreadHere();
        }
    }
}
