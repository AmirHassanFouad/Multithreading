//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//    public class ConcurrentDictionaryExamples
//    {
//        private static ConcurrentDictionary<string, string> capitals = new ConcurrentDictionary<string, string>();

//        public static void AddParis()
//        {
//            var success = capitals.TryAdd("France", "Paris");
//            string who = Task.CurrentId.HasValue ? ($"Task {Task.CurrentId}") : "Main thread";
//            Console.WriteLine($"{who} {(success ? "added" : "did not add")} the element");
//        }

//        static void Main()
//        {
//            Task.Factory.StartNew(AddParis).Wait();
//            AddParis();

//           // capitals["Russia"] = "Leningrad";
//            //udpate dict by indexer
//            //capitals["Russia"] = "Moscow";
//            // for update it will return the string in the last param (Leningrade --> Moscow) but if add it will return just Moscow
//            //capitals.AddOrUpdate("Russia", "Moscow", (k, oldValue) => oldValue + "--> Moscow");
//            //Console.WriteLine(capitals["Russia"]);

//            capitals["Sweden"] = "Uppsala";
//            var capOfSweden = capitals.GetOrAdd("Sweden", "Stokholm"); // if not exist add it with the value 

//            const string toRemove = "Russia";
//            var isRemoved = capitals.TryRemove(toRemove, out string removed);
//            if(isRemoved)
//                Console.WriteLine($"Removed {removed}");
//            else
//                Console.WriteLine($"failed to remove capital of {toRemove}");

//        }
//    }
//}
