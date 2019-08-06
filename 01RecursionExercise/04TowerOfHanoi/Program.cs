using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TowerOfHanoi
{
	class Program
	{
		public static int bottomDisk = int.Parse(Console.ReadLine());
		private static int stepsTaken = 0;

		public static Stack<int> source = new Stack<int>(Enumerable.Range(1, bottomDisk).Reverse());
		public static Stack<int> destination = new Stack<int>();
		public static Stack<int> spare = new Stack<int>();
		static void Main(string[] args)
		{
			MoveDisks(bottomDisk, source, destination, spare);
		}

		private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
		{
			if (bottomDisk == 1)
			{
				stepsTaken++;
				destination.Push(source.Pop());
				PrintStacks();
			}
			else
			{
				MoveDisks(bottomDisk - 1, source, spare, destination);
				destination.Push(source.Pop());
				stepsTaken++;
				PrintStacks();
				MoveDisks(bottomDisk - 1, spare, destination, source);
			}
		}

		private static void PrintStacks()
		{
			Console.WriteLine("source: {0}", string.Join(", ", source.Reverse()));
			Console.WriteLine("destination: {0}", string.Join(", ", destination.Reverse()));
			Console.WriteLine("spare: {0}", string.Join(", ", spare.Reverse()));
			Console.WriteLine(stepsTaken);
			Console.WriteLine();
		}
	}
}


