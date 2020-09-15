using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CrazyThreading.ThreadingSamples
{
    class CrazyPC
    {
        public static Random _random = new Random(); //Random Number ( "_" in front of the variable is for global variables
        public static void CrazyFunctionCall()
        {
            //creating thread objects
            Thread crazyMouseThread = new Thread(new ThreadStart(CrazyMouseThread));

            //start thread
            crazyMouseThread.Start();

            //wait for user imput
            Console.ReadKey();

            //kill thread
            crazyMouseThread.Abort();
        }

        static void CrazyMouseThread()
        {
           
            Console.WriteLine("CrazyMouseThread Started");

            int moveX = 0;
            int moveY = 0;

            while (true)
            {
                moveX = _random.Next(50) - 25;
                moveY = _random.Next(50) - 25;

                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                Thread.Sleep(50);
            }

            Thread.Sleep(1000);
            
        }

        static void CrazyKeyboardThread()
        {

        }

        static void CrazySoundThread()
        {

        }

        static void CrazyPopUpThread()
        {

        }
    }
}
