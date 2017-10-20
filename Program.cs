using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
	public class Kek
	{
		public int kekys { get; set; }

		public class SortByKek : IComparer <Kek>
		{

			public int Compare(Kek obj, Kek obj2)
			{
				if (obj.kekys > obj2.kekys)
					return 1;
				else if (obj.kekys < obj2.kekys)
					return -1;
				else
					return 0;

			}
		}
	}
		class Program
	{
		static void Main(string[] args)
		{
			Kek k1 = new Kek { kekys = 322 };
			Kek k2 = new Kek { kekys = 228 };
			Kek k3 = new Kek { kekys = 1 };
			Kek k4 = new Kek { kekys = -2 };
			Kek k5 = new Kek { kekys = 17 };
			Kek k6 = new Kek { kekys = 29 };
			Kek k7 = new Kek { kekys = 0 };
			Kek k8 = new Kek { kekys = -199 };

			Kek[] Kekysi = new Kek[] { k1, k2, k3, k4, k5, k6, k7, k8 };

			Array.Sort(Kekysi,new Kek.SortByKek());

			foreach (Kek k in Kekysi)
			{
				Console.WriteLine("{0}",k.kekys);
			}
		}
	}
}
