//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadingTests
//{
//	public class BankAccount
//	{
//		private int _balance;
//		public int Balance { get => _balance; private set { _balance = value; } }
//		public void Deposite(int amount)
//		{
//			// lock free programming mechanism
//			Interlocked.Add(ref _balance, amount);
//			//Interlocked.Increment()//increase by 1

//			// if I want to run statements in sequence you need to put barrier between them
//			//1
//			//2
//			//Thread.MemoryBarrier();
//			//Interlocked.MemoryBarrier();
//			//3

//		}

//		public void Widthdraw(int amount)
//		{
//			Interlocked.Add(ref _balance, -amount);
//		}
//	}
//	class InterlockedOperations
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
