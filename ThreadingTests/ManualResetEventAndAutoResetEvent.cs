//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class ManualResetEventAndAutoResetEvent
//    {
//        static void Main()
//        {
//            //var evt = new ManualResetEventSlim();

//            //Task.Factory.StartNew(() =>
//            //{
//            //    Console.WriteLine("Boiling water");
//            //    evt.Set(); // signaled
//            //});

//            //var makeTea = Task.Factory.StartNew(() =>
//            //{
//            //    Console.WriteLine("waiting for water....");
//            //    evt.Wait(); // blocking wait for the signal
//            //    Console.WriteLine("Here is your tea");
//            //});
//            var evt = new AutoResetEvent(false);

//            Task.Factory.StartNew(() =>
//            {
//                Console.WriteLine("Boiling water");
//                evt.Set(); // true
//            });

//            var makeTea = Task.Factory.StartNew(() =>
//            {
//                Console.WriteLine("waiting for water....");
//                evt.WaitOne(); // false
//                Console.WriteLine("Here is your tea");
//                //evt.WaitOne(); // false again will hang ==> it wait just one  so you can wait just once
//                var ok = evt.WaitOne(1000); // false
//                if(ok)
//                    Console.WriteLine("Enjoy your tea");
//                else
//                    Console.WriteLine("no tea for you");
//            });
//            makeTea.Wait();
//        }
//    }
//}
