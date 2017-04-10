using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haffman
{
	class node  : IComparable
	{
		public char Symbol { get; set; }
		public node Left { get; set; }
		public node Right { get; set; }
		public int Weight { get; set; }
		public string Code { get; set; }

		public node()
		{
			Symbol = (char)0;
			Left = Right = null;
			Weight = 0;
			Code = "";
		}

		public node(char symbol, int weight)
		{
			Symbol = symbol;
			Left = Right = null;
			Weight = weight;
			Code = "";
		}

		public static bool operator > (node left, node right)
		{
			if (left.Weight > right.Weight)
				return true;
			return false;
		}

		public static bool operator < (node left, node right)
		{
			if (left.Weight > right.Weight)
				return true;
			return false;
		}

		public static bool operator == (node left, node right)
		{
			if (left.Weight == right.Weight)
				return true;
			return false;
		}

		public static bool operator != (node left, node right)
		{
			if (left.Weight != right.Weight)
				return true;
			return false;
		}

		public int CompareTo(object obj)
		{
			return Weight.CompareTo((obj as node).Weight);
		}
	}
}
