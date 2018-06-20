using System;
using System.Threading;

namespace ConsoleApp12
{
    class Param
    {
        public string One { get; set; }
        public string Two { get; set; }
    }

    class Program
    {
        static void Func(object param)
        {
            var obj = param as Param;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}");
            }
            (param as CountdownEvent).Signal();
        }

        static void Main(string[] args)
        {
            //Thread pool
            using (var countdownEvent = new CountdownEvent(4))
            {
                ThreadPool.QueueUserWorkItem(Func, countdownEvent);
                ThreadPool.QueueUserWorkItem(Func, countdownEvent);
                ThreadPool.QueueUserWorkItem(Func, countdownEvent);
                ThreadPool.QueueUserWorkItem(Func, countdownEvent);

                countdownEvent.Wait();
            }


            Console.WriteLine("Done!");
        }
    }
}
