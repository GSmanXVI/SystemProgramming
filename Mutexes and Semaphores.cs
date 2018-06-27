using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Counter
    {
        public static int count; 
    }

    class Program
    {
        static bool isNew;
        static Mutex globalMutex = new Mutex(true, "gleb", out isNew);

        static void Main(string[] args)
        {
            //Mutex
            Thread[] threads = new Thread[5];
            var semaphore = new Semaphore(3, 3); //free = 1
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(() =>
                {
                    semaphore.WaitOne(); //free--
                    for (int j = 1; j <= 1000000; ++j)
                    {
                        //Console.Write(Thread.CurrentThread.Name);
                        Counter.count++;
                    }
                    semaphore.Release(); //free++
                });
                threads[i].Name = i.ToString();
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i].Join();
            }
            Console.WriteLine("counter = {0}", Counter.count);



            //if (isNew)
            //{
            //    Console.WriteLine("Hello!");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Environment.Exit(0);
            //}



            //globalMutex.WaitOne();
            //Console.WriteLine("Hello!");
            //Console.ReadKey();
            //globalMutex.ReleaseMutex();
            //Console.ReadKey();



            //Mutex
            //Thread[] threads = new Thread[5];
            //var mutex = new Mutex();
            //for (int i = 0; i < threads.Length; ++i)
            //{
            //    threads[i] = new Thread(() =>
            //    {
            //        mutex.WaitOne();
            //        for (int j = 1; j <= 1000000; ++j)
            //        {
            //            Counter.count++;
            //        }
            //        mutex.ReleaseMutex();
            //    });
            //    threads[i].Start();
            //}
            //for (int i = 0; i < threads.Length; ++i)
            //{
            //    threads[i].Join();
            //}
            //Console.WriteLine("counter = {0}", Counter.count);
        }
    }
}
