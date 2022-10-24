using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// 判斷某數值是不是質數
			int n = 23;

			double num = (int)Math.Sqrt(n);

			for (int i = 2; i <= num; i++)
			{
				if(n % i == 0)
				{
					Console.WriteLine("不是質數");
					return;
				}
			}
			Console.WriteLine("是質數");
		}
	}
}
