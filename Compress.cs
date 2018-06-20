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
using System.IO;
using System.IO.Compression;

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
                Console.WriteLine($"{obj.One} {obj.Two} - {i} - {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        static void Main(string[] args)
        {
            ////Compress
            //var fileBytes = File.ReadAllBytes("text.txt");
            //using (FileStream fileStream = new FileStream("text.txt.gz", FileMode.Create))
            //{
            //    using (GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Compress))
            //    {
            //        gZipStream.Write(fileBytes, 0, fileBytes.Length);
            //    }
            //}




            ////Decompress
            //using (FileStream fileStreamResult = new FileStream("text2.txt", FileMode.Create))
            //{
            //    using (FileStream fileStream = new FileStream("text.txt.gz", FileMode.Open))
            //    {
            //        using (GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Decompress))
            //        {
            //            byte[] bytes = new byte[1000];
            //            var bytesCount = 0;
            //            while ((bytesCount = gZipStream.Read(bytes, 0, 1000)) != 0)
            //            {
            //                fileStreamResult.Write(bytes, 0, bytesCount);
            //            }
            //        }
            //    }   
            //}



            ////Thread pool
            //ThreadPool.QueueUserWorkItem(Func, new Param { One = "1", Two = "2" } );
            //ThreadPool.QueueUserWorkItem(Func, new Param { One = "1", Two = "2" });
            //ThreadPool.QueueUserWorkItem(Func, new Param { One = "1", Two = "2" });
            //ThreadPool.QueueUserWorkItem(Func, new Param { One = "1", Two = "2" });

            //Console.Read();
        }
    }
}
