//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    public class BarrierExamples
//    {

//        static Barrier barrier = new Barrier(2, b =>
//        {
//            Console.WriteLine($"phase #{b.CurrentPhaseNumber} is finished.");
//        });

//        public static void Water()
//        {
//            Console.WriteLine("Putting the Kettle on (takes a bit longer)");
//            Thread.Sleep(2000);
//            barrier.SignalAndWait(); // 2
//            Console.WriteLine("Pouring water into cup"); // 0
//            barrier.SignalAndWait(); // 1
//            Console.WriteLine("Putting the kettle away");
//        }

//        public static void Cup()
//        {
//            Console.WriteLine("Finding the nicest cup od tea (fast)");
//            barrier.SignalAndWait(); // 1
//            Console.WriteLine("Adding tea");
//            barrier.SignalAndWait(); // 2
//            Console.WriteLine("Adding sugar");
//        }


//        static void Main()
//        {
//            var water = Task.Factory.StartNew(Water);
//            var cup = Task.Factory.StartNew(Cup);

//            var tea = Task.Factory.ContinueWhenAll(new[] { water, cup }, tasks =>
//             {
//                 Console.WriteLine("Enjoy your cup of tea");
//             });

//            tea.Wait();
//        }
//    }
//}
