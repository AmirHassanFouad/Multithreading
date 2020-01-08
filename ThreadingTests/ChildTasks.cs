//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    public class ChildTasks
//    {
//        static void Main()
//        {
//            var parent = new Task(() =>
//            {
//                // detached
//                // has no relationship with the parent task
//                var child = new Task(() =>
//                {
//                    Console.WriteLine("child task starting");
//                    Thread.Sleep(3000);
//                    Console.WriteLine("child task Finishing");
//                   // throw new Exception();
//                }, TaskCreationOptions.AttachedToParent);

//                var completionHandler = child.ContinueWith(t =>
//                {
//                    Console.WriteLine($"Hooray, task {t.Id}'s state is {t.Status}"); ;
//                }, TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.OnlyOnRanToCompletion);

//                var failHandler = child.ContinueWith(t =>
//                {
//                    Console.WriteLine($"Oops, task {t.Id}'s state is {t.Status}"); ;
//                }, TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.OnlyOnFaulted);

//                child.Start();
//            });

//            parent.Start();

//            try
//            {
//                parent.Wait();// without TaskCreationOptions.AttachedToParent for child task then the parent will not wait for child tasks
//            }
//            catch (AggregateException ae)
//            {

//                ae.Handle(e => true);
//            }
//        }
//    }
//}
