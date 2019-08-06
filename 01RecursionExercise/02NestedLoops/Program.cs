using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02NestedLoops
{
	class Program
	{

		public static int n = int.Parse(Console.ReadLine());
		
		static void Main(string[] args)
		{

			string[] vector = new string[n];

			Solve(0, n, vector);
		}

		private static void Solve(int start, int n, string[] vector)
		{
			if (start > vector.Length - 1)
			{
				for (int j = 0; j < vector.Length; j++)
				{
					Console.Write(vector[j] + " ");
				}
				Console.WriteLine();
				return;
			}
			for (int i = 1; i <= n; i++)
			{
				vector[start] = i.ToString();
			Solve(start + 1, n, vector);

			}


		}
	}
}
