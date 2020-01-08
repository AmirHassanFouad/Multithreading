//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    public class ConcurrentBagExamples
//    {

//        static void Main()
//        {
//            // queue FIFO
//            // stack LIFO
//            // bag no ordering
//            var bag = new ConcurrentBag<int>();
//            var tasks = new List<Task>();
//            for (int i = 0; i < 10; i++)
//            {
//                var i1 = i;
//                tasks.Add(Task.Factory.StartNew(() =>
//                {
//                    bag.Add(i1);
//                    Console.WriteLine($"{Task.CurrentId} has added {i1}");
//                    // observe peek is not ordered
//                    if(bag.TryPeek(out int result))
//                        Console.WriteLine($"{Task.CurrentId} has peeked the value {result}");
                     
//                }));

//            }

//            Task.WaitAll(tasks.ToArray());
//        }
//    }
//}
