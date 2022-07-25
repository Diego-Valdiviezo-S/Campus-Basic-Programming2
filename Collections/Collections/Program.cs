using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stopwatch timer = new Stopwatch();


            timer.Start();
            Class1.ReverseWithQueue(arr);
            timer.Stop();
            TimeSpan timeQueue = timer.Elapsed;
            Console.WriteLine("Time Queue: " + timeQueue.ToString());

            timer.Start();
            Class1.ReverseWithList(arr);
            timer.Stop();
            TimeSpan timeList = timer.Elapsed;
            Console.WriteLine("Time List: " + timeList.ToString());

            timer.Start();
            Class1.ReverseWithDict(arr);
            timer.Stop();
            TimeSpan timeDict = timer.Elapsed;
            Console.WriteLine("Time Dictionary: " + timeList.ToString());

            Console.ReadKey();
        }

           

        }

    }

