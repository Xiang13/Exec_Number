using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 有一個數值, 是四位數, 左邊兩個數字相同, 右邊兩個數字相同, 這個四位數值, 剛好也是某整數的平方, 請問這個四位數值是什麼 ?
			for (int i = 1; i < 10; i++)  // 前面數字 1 ~ 9
			{
				for (int k = 0; k < 10; k++)  // 後面數字 0 ~ 9
				{
					int number = i * 1100 + k * 11;  // i * 1100 代表前兩位數, k * 11 代表後兩位數
					double sqrt = Math.Sqrt(number);  // 這個值開根號

					if (sqrt == Math.Floor(sqrt))  // 無條件捨去
					{
						Console.WriteLine($"sqrt:{sqrt}");
						Console.WriteLine(number);
					}
				}

			}


			int begin = (int)Math.Ceiling(	Math.Sqrt(1000)	);  // 34
			int end = (int)Math.Floor(	Math.Sqrt(9999)	);	// 99

		}
	}
}
