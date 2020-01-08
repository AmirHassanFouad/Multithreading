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
//		public int Balance { get; private set; }
//		public void Deposite(int amount)
//		{
//			Balance += amount;
//		}

//		public void Widthdraw(int amount)
//		{
//			Balance -= amount;
//		}
//	}
//	class SpinLockAndLockRecursion
//	{
//		static SpinLock sl = new SpinLock();

//		static void LockRecursion(int x)
//		{
//			bool lockTaken = false;
//			try
//			{
//				sl.Enter(ref lockTaken);
//			}
//			catch (LockRecursionException ex)
//			{
//				Console.WriteLine($"exception: {ex}");
//			}
//			finally
//			{
//				if (lockTaken)
//				{
//					Console.WriteLine($"Took a lock, x = {x}");
//					LockRecursion(x - 1);
//					sl.Exit();
//				}
//				else
//				{
//					Console.WriteLine($"falid to take a lock, x = {x}");
//				}
//			}
//		}
//		static void Main(string[] args)
//		{

//			LockRecursion(5);
//			//var tasks = new List<Task>();
//			//var ba = new BankAccount();

//			//SpinLock sl = new SpinLock();

//			//for (int i = 0; i < 10; i++)
//			//{
//			//	tasks.Add(Task.Factory.StartNew(() =>
//			//	{
//			//		for (int j = 0; j < 1000; j++)
//			//		{
//			//			var lockTaken = false;
//			//			try
//			//			{
//			//				sl.Enter(ref lockTaken);
//			//				ba.Deposite(100);
//			//			}
//			//			finally
//			//			{
//			//				if (lockTaken) sl.Exit();
//			//			}
//			//		}
//			//	}));

//			//	tasks.Add(Task.Factory.StartNew(() =>
//			//	{
//			//		for (int j = 0; j < 1000; j++)
//			//		{
//			//			var lockTaken = false;
//			//			try
//			//			{
//			//				sl.Enter(ref lockTaken);
//			//				ba.Widthdraw(100);
//			//			}
//			//			finally
//			//			{
//			//				if (lockTaken) sl.Exit();
//			//			}
//			//		}

//			//	}));

//			//}

//			//Task.WaitAll(tasks.ToArray());
//			//Console.WriteLine($"final balance is {ba.Balance}");
//		}
//	}
//}
