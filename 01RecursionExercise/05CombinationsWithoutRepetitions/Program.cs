using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CombinationsWithoutRepetitions
{
	class Program
	{
		public static int n = int.Parse(Console.ReadLine());
		public static int k = int.Parse(Console.ReadLine());

		static void Main(string[] args)
		{
			int[] set = new int[n];
			for (int i = 0; i < n; i++)
			{
				set[i] = i + 1;
			}
			int[] vector = new int[k];

			Solve(set, vector, 0, -1);
		}

		private static void Solve(int[] set, int[] vector, int index, int border)
		{
			if (index >= vector.Length)
			{
				for (int j = 0; j < vector.Length; j++)
				{
					Console.Write(vector[j] + " ");
				}
				Console.WriteLine();
			}
			else
			{
				for (int i = border + 1; i < set.Length; i++)
				{
					vector[index] = set[i];
					Solve(set, vector, index + 1, i);
				}
			}
		}
	}
}
