using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R45_M3_Class_21_Work_02
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i=10; i <= 30; i += 10)
            {
                Console.WriteLine($"Passing {i}");
                CallPrint(i);
            }
            Console.WriteLine("Waiting..");
            Console.ReadLine();
        }
        static void CallPrint(int x)
        {
            Task.Run(() => PrintTimeConsuming(x));
        }
        static void PrintTimeConsuming(int n)
        {
            Console.WriteLine($"Got {n}");
            for(int i=1; i <= n; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
                Task.Delay(250).Wait();
            }
        }
    }
}
