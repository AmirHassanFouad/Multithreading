//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class MergeOptions
//    {
//        static void Main()
//        {
//            var numbers = Enumerable.Range(1, 20).ToArray();

//            //ParallelMergeOptions.NotBuffered will give you items as soon as they are available
//            //ParallelMergeOptions.FullyBuffered will not have any items consumed until all the items are produced
//            var results = numbers
//                .AsParallel()
//                .WithMergeOptions(ParallelMergeOptions.FullyBuffered)
//                .Select(x =>
//                {
//                    var result = Math.Log10(x);
//                    Console.Write($"produced {result}\t");
//                    return result;
//                });

//            foreach (var result in results)
//            {
//                Console.Write($"consumed {result}\t");
//            }
//        }
//    }
//}
