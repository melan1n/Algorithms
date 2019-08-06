namespace SumOfCoins
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class SumOfCoins
	{
		public static void Main(string[] args)
		{
			var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
			var targetSum = 923;

			var selectedCoins = ChooseCoins(availableCoins, targetSum);

			Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
			foreach (var selectedCoin in selectedCoins)
			{
				Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
			}
		}

		public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
		{
			// TODO
			Dictionary<int, int> selectedCoins = new Dictionary<int, int>();
			var currentSum = 0;
			var reversedCoins = coins.OrderByDescending(c => c).ToArray();
			

			foreach (var coin in reversedCoins)
			{
				if ((currentSum == targetSum))
				{
					break;
				}
				if (coin > targetSum - currentSum)
				{
					continue;
				}
				else if (coin == targetSum - currentSum)
				{
					currentSum += coin;
					selectedCoins.Add(coin, 1);
				}
				else
				{
					var numberOfCoinsToTake = (targetSum - currentSum) / coin;
					currentSum += numberOfCoinsToTake * coin;
					selectedCoins.Add(coin, numberOfCoinsToTake);
				}

			}
			if (currentSum != targetSum)
			{
				throw new InvalidOperationException("Unreachable sum");
			}
			return selectedCoins;
		}
	}
}