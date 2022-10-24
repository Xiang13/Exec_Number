using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 找出數值區間內的所有質數
			int n1 = 2;
			int n2 = 100;

			for(int i = n1; i <= n2; i++)
			{
				for (int k = 2; k <= i; k++)
				{
					if (i % k == 0 && i != k)
					{
						break;
					}
					if (i % k == 0 && i == k)
					{
						Console.WriteLine(i);
					}
				}
				
			}

		}
	}
}
