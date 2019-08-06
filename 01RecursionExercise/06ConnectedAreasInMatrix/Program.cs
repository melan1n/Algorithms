using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ConnectedAreasInMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedSet<Area> areas = new SortedSet<Area>();

			FindNonVisitedCell(0, 0);
		}

		private static void FindNonVisitedCell(int row, int col)
		{
			if (!IsInBounds(row, col))
			{
				return;
			}
			else if(IsBorderOrAsteriks(row, col))
			{
				FindNonVisitedCell()
			}
		}

		private static void PrintAreas()
		{
			throw new NotImplementedException();
		}
	}

	internal class Area
	{
		public int topLeftX { get; set; }
		public int topLeftY { get; set; }
		public int size { get; set; }
	}
}
