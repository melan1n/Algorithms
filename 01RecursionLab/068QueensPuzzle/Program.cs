using System;

namespace _068QueensPuzzle
{
	class Program
	{
		public static int solutions = 0;

		static void Main(string[] args)
		{
			int[,] board = new int[8, 8];
			FillBoard(board);
			int n = 8;

			SolvePuzzle(board, 0, n);
			//Console.WriteLine($"Total solutions: {solutions}");
		}

		private static void SolvePuzzle(int[,] board, int row, int n)
		{
			if (row == n)
			{
				PrintBoard(board);
			}
			else
			{
				for (int j = 0; j < 8; j++)
				{
					if (board[row, j] == 0)
					{
						board[row, j] = -1;
						
						MarkAllAttacked(board, row, j);
						SolvePuzzle(board, row + 1, n);
						UnmarkAllAttacked(board, row, j);
					}
				}
			}
		}

		private static void UnmarkAllAttacked(int[,] board, int i, int j)
		{
			board[i, j] = 0;

			for (int row = i + 1; row < 8; row++)
			{
				if (board[row, j] > 0)
				{
					board[row, j]--;
				}
				
			}
			int round = 1;

			for (int row = i+1; row < 8; row++)
			{
				if (j + round <= 7 && board[row, j + round] > 0)
				{
					board[row, j + round]--;
				}
				if (j - round >= 0 && board[row, j - round] > 0)
				{
					board[row, j - round]--;
				}
				round++;

			}
		}

		private static void MarkAllAttacked(int[,] board, int i, int j)
		{
			for (int row = i + 1; row < 8; row++)
			{
				board[row, j]++;
			}
			int round = 1;

			for (int row = i + 1; row < 8; row++)
			{
				if (j + round <= 7)
				{
					board[row, j + round]++;
				}
				if (j - round >= 0)
				{
					board[row, j - round]++;
				}
				round++;
			}
		}

		private static void PrintBoard(int[,] board)
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (board[i, j] == -1)
					{
						Console.Write('*');
					}
					else
					{
						Console.Write('-');
					}
					Console.Write(' ');
				}
				Console.Write(Environment.NewLine);
			}
			Console.WriteLine();

			solutions++;
		}

		private static void FillBoard(int[,] board)
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					board[i, j] = 0;
				}
			}
		}
	}
}
