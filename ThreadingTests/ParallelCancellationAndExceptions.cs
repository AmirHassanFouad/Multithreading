//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class ParallelCancellationAndExceptions
//    {
//        static void Main()
//        {
//            var cts = new CancellationTokenSource();
//            var items = ParallelEnumerable.Range(1, 20);

//            // specify cancellation token before select operator
//            var results = items.WithCancellation(cts.Token).Select(i =>
//            {
//                double result = Math.Log10(i);

//                //if (result > 1) throw new InvalidOperationException();


//                Console.WriteLine($"i = {i} tid: {Task.CurrentId}");
//                return result;
//            });

//            try
//            {
//                foreach (var item in results)
//                {
//                    if (item > 1)
//                        cts.Cancel();

//                    // although cts.Cancel() if item > 1, may be elements greater than 1 will be printed because of concurrent operations
//                    Console.WriteLine($"result = {item}");
//                }
//            }
//            catch (AggregateException ae)
//            {
//                ae.Handle(e =>
//                {
//                    Console.WriteLine($"{e.GetType().Name}: {e.Message}");
//                    return true;
//                });
//            }
//            catch (OperationCanceledException e)
//            {
//                Console.WriteLine("canceled");
//            }
//        }
//    }
//}
