using System;
using System.Threading;

namespace OS_Lab6
{
	class Program
	{
		void New_func1() { }

		public static int Func1(int a, int b)
		{
			Thread.Sleep(9);

			int res = a + b;

			return res;
		}

		public static int Func2(int a, int b, int c)
		{
			int res = 0;

			for (int i = 0; i < 10; i++)
			{
				b--;
				if (c > b)
				{
					res = Func1(a, b);
				}
				else
				{
					res = Func1(a, c);
				}
				if (res > 0)
					return res;
			}

			return res;
		}

		public static void Main(string[] args)
		{
			Func2(51, 110, 12);
		}
	}
}
