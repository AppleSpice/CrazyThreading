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
            Thread crazyKeyboardThread = new Thread(new ThreadStart(CrazyKeyboardThread));

            //start thread
            crazyMouseThread.Start();
            crazyKeyboardThread.Start();

            //wait for user imput
            //Console.ReadKey();

            //kill thread
            //crazyMouseThread.Abort();
            //crazyKeyboardThread.Abort();
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

            
            
        }

        static void CrazyKeyboardThread()
        {
            //Need send.sendwait method
            Console.WriteLine("CrazyKeyboardThread Started");

            while (true)
            {
                //create random letters using ascii table http://www.asciitable.com

                char key = (char)(_random.Next(50) + 45);
                //SendKeys.SendWait("A");

                if (_random.Next(2) == 0)
                {
                    key = char.ToLower(key);
                }
                SendKeys.SendWait(key.ToString());
                Thread.Sleep(1000);
            }
        }

        static void CrazySoundThread()
        {

        }

        static void CrazyPopUpThread()
        {

        }
    }
}
