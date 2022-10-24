using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 百元買百雞, 享用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元, 字彙表: 公雞(Cock), 母雞(Hen), 小雞(Chicken)

			int count = 0; // 計算圈數
			for (int cock = 0; cock <= 100/5; cock++)  // 算出公雞數量 不會超過 20隻
			{
				for (int hen = 0; hen <= (100 - 5 * cock) / 3; hen++)  // 算出母雞數量
				{
					int chicken = 100 - cock - hen;  // 算出小雞數量

					// 判斷總價數否為一百
					double price = 5 * cock + 3 * hen + (double)chicken / 3.0;
					// 用 int    型別, 如有小數點, 會捨去小數點, 三個相加會等於100
					// 用 double 型別 5*cock + 3*hen +  (chicken/3.0) ==>有小數點, 代表三個相加超過一百, 判斷才會正確
					if (price == 100)
					{
						Console.WriteLine($"公雞{cock}隻, 母雞{hen}隻, 小雞{chicken}隻");
					}
					count += 1;
				}
			}
			Console.WriteLine(count);
		}
	}
}
