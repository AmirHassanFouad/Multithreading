//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class SemaphoreSlimExamples
//    {
//        static void Main()
//        {
//            var semaphore = new SemaphoreSlim(2, 10);

//            for (int i = 0; i < 20; i++)
//            {
//                Task.Factory.StartNew(() =>
//                {
//                    Console.WriteLine($"Entering Task {Task.CurrentId}");
//                    semaphore.Wait(); // releaseCount--
//                    Console.WriteLine($"Processing Task {Task.CurrentId}");
//                });
//            }

//            while(semaphore.CurrentCount <= 2)
//            {
//                Console.WriteLine($"semaphore count {semaphore.CurrentCount}");
//                Console.ReadKey();
//                semaphore.Release(2); // ReleaseCount += 2
//            }
//        }
//    }
//}
