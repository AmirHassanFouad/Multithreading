//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class TasksContinuation
//    {
//        static void Main()
//        {
//            //var task = Task.Factory.StartNew(() =>
//            //{
//            //    Console.WriteLine("Boiling water");
//            //});

//            //var task2 = task.ContinueWith(t =>
//            //{
//            //    Console.WriteLine($"completed task {t.Id}, pour water into cup");
//            //});

//            //task2.Wait();

//            var task = Task.Factory.StartNew(() => "Task 1");
//            var task2 = Task.Factory.StartNew(() => "Task 2");


//            var task3 = Task.Factory.ContinueWhenAny(new[] { task, task2 },
//               t =>
//               {
//                   Console.WriteLine("task completed:");
//                   Console.WriteLine($" - {t.Result}");

//                   Console.WriteLine("all tasks done");
//               });

//            //var task3 = Task.Factory.ContinueWhenAll(new[] { task, task2 },
//            //    tasks =>
//            //    {
//            //        Console.WriteLine("tasks completed:");
//            //        foreach (var item in tasks)
//            //            Console.WriteLine($" - {item.Result}");

//            //        Console.WriteLine("all tasks done");
//            //    });

//            task3.Wait();
//        }
//    }
//}
