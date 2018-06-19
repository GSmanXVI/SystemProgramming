using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Net;
using Newtonsoft.Json;

namespace ConsoleApp12
{
    class Program
    {
        static void Func(dynamic obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Hello, {obj.Name} {obj.Surname}!");
            }
        }

        static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Hello from Thread!");
            }
        }

        static int x = 0;
        static object locker = new object();

        static void Func3()
        {

            lock (locker)
            {
                for (int i = 0; i < 100; i++)
                {
                    x++;
                    Console.WriteLine($"{Thread.CurrentThread.Name} - {x}");
                    
                }
                Console.WriteLine(locker.GetHashCode());
            }
            Console.WriteLine(locker.GetHashCode());
        }

        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            var title = Console.ReadLine();
            var result = webClient.DownloadString($"http://www.omdbapi.com/?apikey=2c9d65d5&t={title}");
            dynamic data = JsonConvert.DeserializeObject(result);
            Console.WriteLine(data.Ratings[0].Source);





            //for (int i = 1; i < 6; i++)
            //{
            //    var start = new ThreadStart(Func3);
            //    var thread = new Thread(start);
            //    thread.Name = i.ToString();
            //    thread.Start();
            //}




            //var start = new ThreadStart(Func3);
            //var thread = new Thread(start);
            //thread.Start();





            //var thread1 = new Thread(
            //    new ThreadStart(
            //        () =>
            //        {
            //            for (int i = 0; i < 1000; i++)
            //            {
            //                Console.WriteLine($"{i} - {Thread.CurrentThread.Name}");
            //            }
            //        }
            //));
            //thread1.Name = "Thread one";
            //thread1.Priority = ThreadPriority.Lowest;
            //thread1.Start();

            //var thread2 = new Thread(
            //    new ThreadStart(
            //        () =>
            //        {
            //            for (int i = 0; i < 1000; i++)
            //            {
            //                Console.WriteLine($"{i} - {Thread.CurrentThread.Name}");
            //            }
            //        }
            //));
            //thread2.Name = "--Thread two";
            //thread2.Priority = ThreadPriority.Highest;
            //thread2.Start();


            //var start = new ParameterizedThreadStart(Func);
            //var thread = new Thread(start);
            //thread.IsBackground = true;
            //thread.Start(new { Name = "Gleb", Surname = "Skripnikov" });
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine($"Hello from Main!");
            //}

            //Console.Read();




            //var start = new ThreadStart(Func2);
            //var thread = new Thread(start);
            //thread.IsBackground = true;
            //thread.Start();
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine($"Hello from Main!");
            //}



            //var callback = new TimerCallback(Func);
            //var timer = new Timer(callback, 
            //    new { Name = "Gleb", Surname = "Skripnikov" }, 
            //    1000, 500);

            //Console.Read();
            //timer.Dispose();
        }
    }
}
