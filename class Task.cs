using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static IEnumerable<int> Func(dynamic x)
        {
            int result = 5;
            for (int i = 0; i < (int)x; i++)
            {
                result *= result;
                Console.WriteLine("Test!");
                yield return result;
            }
        }

        static void Main(string[] args)
        {
            //var task = new Task<IEnumerable<int>>(Func, 4);
            //task.Start();
            //foreach (var item in task.Result)
            //{
            //    Console.WriteLine(item);
            //}




            //var task = new Task<int>(x =>
            //{
            //    int result = 5;
            //    for (int i = 1; i < (int)x; i++)
            //    {
            //        result *= result;
            //        yield return result;
            //    }

            //}, 2);
            //task.Start();
            //Console.WriteLine(task.Result);





            //var task = new Task((dynamic x) =>
            //{
            //    for (int i = 0; i < x.Count; i++)
            //    {
            //        Console.WriteLine($"{i} {x.Name}");
            //    }
            //}, new { Name = "Gleb", Count = 10 });
            //task.Start();
            //task.Wait();




            //var task3 = Task.Run(
            //    () => Console.WriteLine("Task 3"));

            //var task2 = Task.Factory.StartNew(
            //    () => Console.WriteLine("Task 2"));

            //var task1 = new Task(() =>
            //{
            //    Console.WriteLine("Task 1");
            //});
            //task1.Start();

            //Task.WaitAny(task1, task2, task3);
            //Task.WaitAll(task1, task2, task3);
            //task1.Wait();
            //task2.Wait();
            //task3.Wait();
        }
    }
}
