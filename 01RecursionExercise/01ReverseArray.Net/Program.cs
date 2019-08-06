using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ReverseArray.Net
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] arr = Console.ReadLine().Split(' ')
				.Select(x => char.Parse(x)).ToArray();

			char[] newArr = new char[arr.Length];
			newArr = ReverseArray(0, arr.Length - 1, arr, newArr);

			for (int i = 0; i < newArr.Length; i++)
			{
				Console.Write(newArr[i]);
				Console.Write(" ");
			}

		}

		private static char[] ReverseArray(int start, int end, char[] arr, char[] newArr)
		{
			if (start > end)
			{
				return newArr;
			}
			newArr[end - start] = arr[start];

			ReverseArray(start + 1, end, arr, newArr);
			return newArr;
		}
	}
}
