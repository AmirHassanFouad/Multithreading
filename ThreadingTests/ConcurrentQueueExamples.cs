//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    public class ConcurrentQueueExamples
//    {
//        static void Main()
//        {
//            var q = new ConcurrentQueue<int>();
//            q.Enqueue(1);
//            q.Enqueue(2);


//            if (q.TryPeek(out int result))
//                Console.WriteLine(result);

//            if (q.TryDequeue(out int dequeued))
//                Console.WriteLine(dequeued);
//        }
//    }
//}
