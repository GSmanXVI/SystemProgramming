using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleApp12
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var domain = AppDomain.CreateDomain("MyDomain");
            var assembly = domain.Load(AssemblyName.GetAssemblyName("ClassLibrary1.dll"));
            var module = assembly.Modules.First();
            Console.WriteLine(module);

            var type = module.GetType("ClassLibrary1.Class1");
            var method = type.GetMethod("ShowMessage");

            var obj = assembly.CreateInstance("ClassLibrary1.Class1");
            method.Invoke(obj, new object[] { "Hello, world!" });

            AppDomain.Unload(domain);


            //Process process = Process.Start("notepad.exe");
            //ProcessModule module = process.MainModule;
            //Console.WriteLine(module.Ge);




            //Assembly assembly = Assembly.GetExecutingAssembly();
            //var type = assembly.GetType("ConsoleApp12.Person");
            //foreach (var item in type.GetFields())
            //{
            //    Console.WriteLine(item);
            //}





            //Console.WriteLine(assembly.FullName);


            //foreach (var item in assembly.GetTypes())
            //{
            //    Console.WriteLine(item);
            //}

            //var x = new { Param1 = 12, Param2 = "Text" };
            //dynamic obj = assembly.CreateInstance("ConsoleApp12.Person");
            //obj.Name = "Gleb";
            //obj.Age = 24;
            //Console.WriteLine(obj.Name);


            //if (args.Length > 0)
            //{
            //    foreach (var item in args)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}



            //var process = Process.Start("notepad++.exe", @"C:\Users\skripnikov\source\repos\ConsoleApp12\ConsoleApp12\bin\Debug\Dapper Examples.txt");
            //Console.ReadKey();



            //var process1 = Process.Start("notepad.exe");
            //var process2 = Process.Start("notepad++.exe");
            //var process3 = Process.Start("devenv.exe");




            //var process = Process.GetProcessById(2640);
            //process.CloseMainWindow();




            //var processes = Process.GetProcesses();
            //foreach (var item in processes)
            //{
            //    item.Kill();
            //}



            //var process = Process.GetProcessById(16468);
            //process.Kill();



            //var process = Process.GetCurrentProcess();
            //Console.WriteLine(process.Id);
            //Console.WriteLine(process.ProcessName);
            //Console.WriteLine(process.PriorityClass);
            //Console.WriteLine(process.StartTime);
            //Console.WriteLine(process.Modules.Count);
            //Console.WriteLine(process.MainModule);
            //foreach (var item in process.Modules)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();
        }
    }
}
