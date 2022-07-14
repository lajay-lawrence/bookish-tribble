using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameworkConsoleApp
{
    class Program
    {
        private static readonly ManualResetEvent manualEvent = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            for(int index=0;index<5;index++)
            {
                Console.WriteLine("Docker image is ready");

            }
            manualEvent.WaitOne();
        }
    }
}
