//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class AsParallelAndParallelQuery
//    {
//        static void Main()
//        {
//            const int count = 20;
//            var items = Enumerable.Range(1, count).ToArray();
//            var results = new int[count];

//            items.AsParallel().ForAll(x =>
//            {
//                Console.WriteLine($"{x} [{Task.CurrentId}]");
//                results[x - 1] = x;
//            });

//            //Console.WriteLine("-------");
//            //foreach (var item in results)
//            //{
//            //    // ordered
//            //    Console.WriteLine(item);
//            //}

//            var s = items.AsParallel().AsOrdered().Select(x => x); // ordered
//            var s = items.AsParallel().AsUnordered().Select(x => x); // unordered
//        }

//    }
//}
