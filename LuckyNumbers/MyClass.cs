using System;
using System.Collections;
using System.Collections.Generic;

namespace LuckyNumbers
{
	public class Lottery
	{
		public IList<int> LuckyNumbers
		{
			get;
			set;
		}
		public Lottery()
		{
			LuckyNumbers = new List<int>();
		}
		public void AddNumbers(int[] numbers)
		{
			LuckyNumbers.Add(numbers);

		}
		public void shuffleNumber()
		{
		}
		public void NormalizeToLottoNumber()
		{
			foreach (var item in LuckyNumbers)

			{
				if (item > 37)
				{

				}
			}
		}

	}
}
