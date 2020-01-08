//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    class BlockingCollectionExamples
//    {
//        // not caring about ordering so I will use ConcurrentBag
//        //BlockingCollection is a wrapper around one of the IProducerConsumerCollection classes
//        // provides blocking and bounding capabilities
//        static BlockingCollection<int> messages = new BlockingCollection<int>(new ConcurrentBag<int>(), 10);// the 11th element will block it will basically stall whoever's trying to add the 
//        // elements until such time that a slot becomes available to the actual message

//        static CancellationTokenSource cts = new CancellationTokenSource();
//        static Random random = new Random();
//        static void ProduceAndConsume()
//        {
//            var producer = Task.Factory.StartNew(RunProducer);
//            var consumer = Task.Factory.StartNew(RunConsumer);

//            try
//            {
//                Task.WaitAll(new[] { producer, consumer }, cts.Token);
//            }
//            catch (AggregateException ae)
//            {

//                ae.Handle(e => true);
//            }
//        }

//        static void Main()
//        {
//            Task.Factory.StartNew(ProduceAndConsume, cts.Token);

//            Console.ReadKey();
//            cts.Cancel();
//        }

//        private static void RunConsumer()
//        {
//            foreach (var item in messages.GetConsumingEnumerable())
//            {
//                cts.Token.ThrowIfCancellationRequested();
//                Console.WriteLine($"-{item}\t");
//                Thread.Sleep(random.Next(1000));
//            }
//        }

//        private static void RunProducer()
//        {
//            while (true)
//            {
//                cts.Token.ThrowIfCancellationRequested();
//                int i = random.Next(100);
//                messages.Add(i);
//                Console.WriteLine($"+{i}\t");
//                Thread.Sleep(random.Next(100));
//            }
//        }
//    }
//}
