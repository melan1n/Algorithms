using System;
using System.Linq;

namespace _05GeneratingCombinations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] set = Console.ReadLine().Split(' ')
				.Select(x => int.Parse(x)).ToArray();

			int k = int.Parse(Console.ReadLine());
			int[] vector = new int[k];

			GenCombs(set, vector, 0, 0);
		}

		private static void GenCombs(int[] set, int[] vector, int index, int border)
		{
			if (index >= vector.Length)
			{
				Console.WriteLine(string.Join(" ", vector));
			}
			else
			{
				for (int i = border; i < set.Length; i++)
				{
					vector[index] = set[i];
					GenCombs(set, vector, index + 1, i + 1);
				}
			}
		}
	}
}
