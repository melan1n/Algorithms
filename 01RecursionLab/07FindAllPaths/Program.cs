using System;
using System.Collections.Generic;

namespace _07FindAllPaths
{
	class Program
	{
		public static char[,] lab;
		static List<char> path = new List<char>();

		static void Main(string[] args)
		{
			lab = ReadLab();
			FindPaths(0, 0, 'R');
		}

		private static void FindPaths(int row, int col, char direction)
		{
			if (!IsInBounds(row, col))
			{
				return;
			}

			path.Add(direction);

			if (IsExit(row, col))
			{
				PrintPath();
			}
			else if (!IsVisited(row, col) && IsFree(row, col))
			{
				Mark(row, col);
				FindPaths(row, col + 1, 'R');
				FindPaths(row + 1, col, 'D');
				FindPaths(row, col - 1, 'L');
				FindPaths(row - 1, col, 'U');
				Unmark(row, col);
			}

			path.RemoveAt(path.Count - 1);
		}

		private static void Unmark(int row, int col)
		{
			lab[row, col] = '-';
		}

		private static void Mark(int row, int col)
		{
			lab[row, col] = '*';
		}

		private static bool IsFree(int row, int col)
		{
			if (lab[row,col] == '-')
			{
				return true;
			}
			return false;
		}

		private static bool IsVisited(int row, int col)
		{
			if ("LRUD".IndexOf(lab[row, col]) != -1)
			{
				return true;
			}
			return false;
		}

		private static void PrintPath()
		{
			List<char> sublist = path.GetRange(1, path.Count - 1);
			Console.WriteLine(string.Join("", sublist));
		}

		private static bool IsExit(int row, int col)
		{
			if (lab[row,col] == 'e')
			{
				return true;
			}
			return false;
		}

		private static bool IsInBounds(int row, int col)
		{
			if (row >= 0 && row <= lab.GetUpperBound(0) && col >=0 && col <= lab.GetUpperBound(1))
			{
				return true;
			}
			return false;
		}

		private static char[,] ReadLab()
		{
			int rows = int.Parse(Console.ReadLine());
			int cols = int.Parse(Console.ReadLine());

			char[,] lab = new char[rows, cols];
			string line = Console.ReadLine();
			rows = 0;
			while (line != "")
			{
				for (int i = 0; i < line.Length; i++)
				{
					lab[rows, i] = line[i];
				}

				rows++;
				line = Console.ReadLine();
			}

			return lab;
		}
	}
}
