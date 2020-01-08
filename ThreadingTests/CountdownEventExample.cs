//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class CountdownEventExample
//    {
//        private static int taskCount = 5;
//        static CountdownEvent cte = new CountdownEvent(taskCount);
//        // CountdownEvent => signal & wait separated Vs Barrier SignalWait are in one Method

//        static Random random = new Random();

//        static void Main()
//        {
//            for (int i = 0; i < taskCount; i++)
//            {
//                Task.Factory.StartNew(() =>
//                {
//                    Console.WriteLine($"Entring task {Task.CurrentId}");
//                    Thread.Sleep(random.Next(3000));
//                    cte.Signal();
//                    Console.WriteLine($"Exiting task {Task.CurrentId}");
//                });
//            }

//            var finalTask = Task.Factory.StartNew(() =>
//            {
//                Console.WriteLine($"waitning for other tasks to complete in {Task.CurrentId}");
//                cte.Wait();
//                Console.WriteLine("All tasks completed");
//            });

//            finalTask.Wait();
//        }
//    }
//}
