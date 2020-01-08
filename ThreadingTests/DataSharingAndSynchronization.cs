//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//	public class BankAccount
//	{
//		public object padlock = new object();
//		public int Balance { get; private set; }
//		public void Deposite(int amount)
//		{
//			// not atomic operation, critical section need locking to make one thread operate at a time
//			// so the other thread need to wait  until the padlock is removed and then it can lock and do its own thing
//			lock (padlock)
//			{
//				Balance += amount;
//			}
//		}

//		public void Widthdraw(int amount)
//		{
//			lock (padlock)
//			{
//				Balance -= amount;
//			}
//		}
//	}
//	class DataSharingAndSynchronization
//	{
//		static void Main(string[] args)
//		{
//			var tasks = new List<Task>();
//			var ba = new BankAccount();

//			for (int i = 0; i < 10; i++)
//			{
//				tasks.Add(Task.Factory.StartNew(() =>
//				{
//					for (int j = 0; j < 1000; j++)
//						ba.Deposite(100);
//				}));

//				tasks.Add(Task.Factory.StartNew(() =>
//				{
//					for (int j = 0; j < 1000; j++)
//						ba.Widthdraw(100);
//				}));

//			}

//			Task.WaitAll(tasks.ToArray());
//			Console.WriteLine($"final balance is {ba.Balance}");
//		}
//	}
//}
