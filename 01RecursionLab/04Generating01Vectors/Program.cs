using System;

namespace _04Generating01Vectors
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] vector = new int[n];
			GenerateBitVector(vector, 0);
		}

		private static void GenerateBitVector(int[] vector, int index)
		{
			if (index > vector.Length - 1)
			{
				Console.WriteLine(string.Join("", vector));
				return;
			}

			for (int i = 0; i <= 1; i++)
			{
				vector[index] = i;
				GenerateBitVector(vector, index + 1);
			}
		}
	}
}
