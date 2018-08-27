using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace almostRandom
{
	class Program
	{
		public static Stopwatch sw = new Stopwatch();

		/// <summary>
		/// Main
		/// </summary>
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\t===  WolfPaw Studios Presents  ===");
			Console.WriteLine("\t==       Almost    Random       ==");
			Console.WriteLine("\t===   A lunchtime production   ===");
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("\r\n\r\n");
			Console.WriteLine("\r\n\r\n===========================================================\r\n\r\n\t== START PROCESS ==\r\n\r\n");

			sw.Start();

			Console.Write("Generating arrays...");
			int[] arrayFor35 = new int[20];
			int[] arrayFor46 = new int[20];
			for (int i = 0; i < arrayFor35.Length; i++)
			{
				Thread.Sleep(4);
				arrayFor35[i] = new Random((method1_short())).Next(100,999);
				arrayFor46[i] = new Random((int)(method2() / 1000)).Next(100, 999);
				Console.Write(".");
			}
			
			Console.WriteLine($"\r\n\r\nD: { sw.ElapsedMilliseconds.ToString() }ms\r\n\r\n");

			sw.Restart();

			Console.WriteLine("Method 1 for random [LONG] generation:");
			Console.WriteLine(method1());
			Thread.Sleep(15);
			Console.WriteLine(method1());
			Thread.Sleep(20);
			Console.WriteLine(method1());
			Thread.Sleep(15);
			Console.WriteLine(method1());
			Thread.Sleep(20);
			Console.WriteLine(method1());

			Console.WriteLine($"\r\n\r\nD: { sw.ElapsedMilliseconds.ToString() }ms\r\n\r\n");

			sw.Restart();

			Console.WriteLine("Method 1 for random [SHORT] generation:");
			Console.WriteLine(method1_short());
			Thread.Sleep(15);
			Console.WriteLine(method1_short());
			Thread.Sleep(20);
			Console.WriteLine(method1_short());
			Thread.Sleep(15);
			Console.WriteLine(method1_short());
			Thread.Sleep(20);
			Console.WriteLine(method1_short());

			Console.WriteLine($"\r\n\r\nD: { sw.ElapsedMilliseconds.ToString() }ms\r\n\r\n");

			sw.Restart();

			Console.WriteLine("Method 2 for random [LONG] generation:");
			Console.WriteLine(method2());
			Thread.Sleep(15);
			Console.WriteLine(method2());
			Thread.Sleep(20);
			Console.WriteLine(method2());
			Thread.Sleep(15);
			Console.WriteLine(method2());
			Thread.Sleep(20);
			Console.WriteLine(method2());

			Console.WriteLine($"\r\n\r\nD: { sw.ElapsedMilliseconds.ToString() }ms\r\n\r\n");

			sw.Restart();

			Console.WriteLine("Method 3 for [ARRAY] random shuffle:");
			Console.WriteLine($"array: [ { String.Join(", ", arrayFor35) } ]\r\n");
			method3(arrayFor35);
			Thread.Sleep(15);
			method3(arrayFor35);
			Thread.Sleep(15);
			method3(arrayFor35);
			Thread.Sleep(15);
			method3(arrayFor35);
			Thread.Sleep(15);
			method3(arrayFor35);

			Console.WriteLine($"\r\n\r\nD: { sw.ElapsedMilliseconds.ToString() }ms\r\n\r\n");

			sw.Restart();

			Console.WriteLine("Method 4 for [ARRAY] random shuffle:");
			Console.WriteLine($"array: [ { String.Join(", ", arrayFor46) } ]\r\n");
			method4(arrayFor46);
			Thread.Sleep(15);
			method4(arrayFor46);
			Thread.Sleep(15);
			method4(arrayFor46);
			Thread.Sleep(15);
			method4(arrayFor46);
			Thread.Sleep(15);
			method4(arrayFor46);

			Console.WriteLine($"\r\n\r\nD: { sw.ElapsedMilliseconds.ToString() }ms\r\n\r\n");

			sw.Restart();

			Console.WriteLine("Method 5 for selecting [SINGLE VALUE] from [ARRAY]:");
			Console.WriteLine($"array: [ { String.Join(", ", arrayFor35) } ]\r\n");
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);
			Console.WriteLine(method5(arrayFor35));
			Thread.Sleep(15);

			Console.WriteLine($"\r\n\r\nD: { sw.ElapsedMilliseconds.ToString() }ms\r\n\r\n");

			sw.Restart();

			Console.WriteLine("Method 6 for selecting [SINGLE VALUE] from [ARRAY]:");
			Console.WriteLine($"array: [ { String.Join(", ", arrayFor46) } ]\r\n");
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);
			Console.WriteLine(method6(arrayFor46));
			Thread.Sleep(15);

			sw.Stop();

			Console.WriteLine($"\r\n\r\nD: { sw.ElapsedMilliseconds.ToString() }ms\r\n\r\n");
			
			Console.WriteLine("\r\n\r\n===========================================================\r\n\r\n\t");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("=== END PROCESS ===\r\n\r\n");
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Press any key to quit!");
			Console.ReadKey();
		}

		/// <summary>
		/// M1: Generate random long
		/// </summary>
		public static long method1()
		{
			long ret = 0;

			Random r1 = new Random((int)((Environment.TickCount / Math.PI) * Math.Sin(new Random().Next())));
			Thread.Sleep(2);
			Random r2 = new Random((int)((Environment.TickCount / (Math.PI * 2)) + Math.BigMul(((int)Environment.WorkingSet * Environment.SystemPageSize), Environment.CurrentManagedThreadId) * r1.NextDouble()));
			string s1 = r1.Next(1000000000, 2147483647).ToString();
			string s2 = r2.Next(1000000000, 2147483647).ToString();
			string r = "";

			for (int i = 0; i < s1.Length; i++)
			{
				if (i % 2 == 0)
				{
					if (i == 0)
					{
						if (new Random().Next() % 2 == 0)
						{
							r += '0';
						}
						else
						{
							r += '1';
						}
					}
					else
					{
						r += s1[i];
					}
				}
				else
				{
					r += s2[i];
				}
			}

			ret = Convert.ToInt64(r);

			return ret;
		}

		/// <summary>
		/// M1: Generate random short
		/// </summary>
		public static short method1_short()
		{
			short ret = 0;

			Random r1 = new Random((int)((Environment.TickCount / Math.PI) * Math.Sin(new Random().Next())));
			Thread.Sleep(2);
			Random r2 = new Random((int)((Environment.TickCount / (Math.PI * 2)) + Math.BigMul(((int)Environment.WorkingSet * Environment.SystemPageSize), Environment.CurrentManagedThreadId) * r1.NextDouble()));
			string s1 = r1.Next(10000, 32767).ToString();
			string s2 = r2.Next(10000, 32767).ToString();
			string r = "";

			for (int i = 0; i < s1.Length; i++)
			{
				if (i % 2 == 0)
				{
					if (i == 0)
					{
						if (new Random().Next() % 2 == 0)
						{
							r += '0';
						}
						else
						{
							r += '1';
						}
					}
					else
					{
						r += s1[i];
					}
				}
				else
				{
					r += s2[i];
				}
			}

			ret = Convert.ToInt16(r);

			return ret;
		}

		/// <summary>
		/// M2: Generate random long
		/// </summary>
		public static long method2()
		{
			long ret = 0L;

			byte[] bytes = new byte[33];
			new Random().NextBytes(bytes);

			List<bstruct> bs = new List<bstruct>();
			
			byte[] md5bytes = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(bytes);

			foreach (byte b in md5bytes)
			{
				Thread.Sleep(2);
				bstruct _bs = new bstruct();
				_bs.b = (new System.Security.Cryptography.SHA256CryptoServiceProvider().ComputeHash(new byte[] { b }));
				_bs.probint = (new Random(b + Environment.TickCount * b).Next());
				bs.Add(_bs);
			}

			string stmp = "";
			double tmp = 0d;
			foreach (var b in bs)
			{
				if (b.probint % 2 == 0)
				{
					tmp += b.b.Sum(x => ((double)x / Math.PI)) % 1;
				}
			}

			stmp = tmp.ToString().Substring(4);

			ret = Convert.ToInt64(stmp);

			return ret;
		}

		/// <summary>
		/// M3: Shuffle array (Fisher-Yates)
		/// </summary>
		public static void method3(int[] arr)
		{
			int tmp = 0;
			int[] a2 = new int[arr.Length];
			arr.CopyTo(a2, 0);

			for (int i = 1; i < a2.Length + 1; i++)
			{
				Thread.Sleep(2);
				int r = new Random(method1_short()).Next(0, a2.Length);
				tmp = a2[a2.Length - i];
				a2[a2.Length - i] = a2[r];
				a2[r] = tmp;
			}

			Console.WriteLine($"Method3 - array: [ { String.Join(", ", a2) } ]");
		}

		/// <summary>
		/// M4: Shuffle array (WolfyD)
		/// </summary>
		public static void method4(int[] arr)
		{
			int[] a2 = new int[arr.Length];
			int[] a3 = new int[arr.Length];
			arr.CopyTo(a3, 0);
			for (int i = 1; i < a2.Length + 1; i++)
			{
				Thread.Sleep(2);
				int r = new Random(method1_short()).Next(0, a3.Length);
				a2[i - 1] = a3[r];
				a3 = a3.Except(new int[] { a3[r] }).ToArray();
				if (a3.Length == 1)
					continue;
			}

			Console.WriteLine($"Method4 - array: [ { String.Join(", ", a2) } ]");
		}

		/// <summary>
		/// M5: Random number from Array
		/// </summary>
		public static int method5(int[] arr)
		{
			int[] a2 = new int[arr.Length];
			arr.CopyTo(a2, 0);
			int tmp = 0;
			int len = new Random().Next(1, a2.Length);
			for (int i = 0; i < len; i++)
			{
				Thread.Sleep(5);
				int r = new Random(method1_short() + tmp + new Random().Next()).Next(0, a2.Length);
				tmp = a2[r];
			}

			return tmp;
		}

		/// <summary>
		/// M6: Random number from Array
		/// </summary>
		public static int method6(int[] arr)
		{
			int[] a2 = new int[arr.Length];
			arr.CopyTo(a2, 0);
			List<int> atmp = new List<int>();
			int tmp = 0;

			for (int i = 0; i < a2.Length; i++)
			{
				Thread.Sleep(5);
				int r = new Random(method1_short() + tmp + new Random().Next()).Next(0, arr.Length);
				if ((i * r) % 2 == 0)
					atmp.Add(arr[r]);
				else
					tmp += arr[r];
			}

			tmp = atmp[new Random(tmp).Next(0, atmp.Count)];

			return tmp;
		}
	}

	public class bstruct
	{
		public int probint { get; set; }
		public byte[] b { get; set; }
	}

}
