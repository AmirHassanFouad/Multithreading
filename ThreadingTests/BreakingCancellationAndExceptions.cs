//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class BreakingCancellationAndExceptions
//    {
//        static ParallelLoopResult result;
//        public static void Demo()
//        {
//            var cts = new CancellationTokenSource();

//            var po = new ParallelOptions();
//            po.CancellationToken = cts.Token;

//            result = Parallel.For(0, 20, po, (x, state) =>
//             {
//                 Console.WriteLine($"{x}[{Task.CurrentId}]");
//                 if (x == 10)
//                 {
//                     // state.Stop(); // stoping the loop
//                     // state.Break(); // make a request to stop the loop execution
//                     // throw new Exception();
//                     cts.Cancel();
//                 }
//             });

//            Console.WriteLine();
//            Console.WriteLine($"was loop completed? {result.IsCompleted}");
//            if (result.LowestBreakIteration.HasValue) // corresponds to the iteration which loop breaked in
//                Console.WriteLine($"lowest break iteration: {result.LowestBreakIteration}"); // not null if the loop was breaked
//        }

//        static void Main()
//        {
//            try
//            {
//                Demo();
//            }
//            catch (AggregateException ae)
//            {
//                ae.Handle(e =>
//                {
//                    Console.WriteLine(e.Message);
//                    return true;
//                });
//            }
//            catch(OperationCanceledException e) // catch OperationCanceledException if you want to be safely exiting a cancellation
//            {
//                Console.WriteLine("cancel called");
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}
