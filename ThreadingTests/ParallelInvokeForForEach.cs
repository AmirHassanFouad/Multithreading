//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    public class ParallelInvokeForForEach
//    {
//        public static IEnumerable<int> Range(int start, int end, int step)
//        {
//            for (int i = start; i < end; i += step)
//            {
//                yield return i;
//            }
//        }

//        static void Main()
//        {
//            var a = new Action(() => Console.WriteLine($"first {Task.CurrentId}"));
//            var b = new Action(() => Console.WriteLine($"second {Task.CurrentId}"));
//            var c = new Action(() => Console.WriteLine($"third {Task.CurrentId}"));

//            Parallel.Invoke(a, b, c);

//            // loop from 1 to 10 because 11 is exclusived
//            var po = new ParallelOptions();
//            //po.CancellationToken
//            //po.MaxDegreeOfParallelism
//            Parallel.For(1, 11, po, i =>
//             {
//                 // observe they are not ordered
//                 Console.WriteLine(i * i);
//             });


//            //string[] words = { "oh", "what", "a", "night" };
//            //Parallel.ForEach(words, word =>
//            //{
//            //    Console.WriteLine($"{word} has length {word.Length}  (task {Task.CurrentId})");
//            //});

//            Parallel.ForEach(Range(1, 20, 3), Console.WriteLine);
//        }
//    }
//}
