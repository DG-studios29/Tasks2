using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class GoldClass : ItemClass
	{
		private Random goldrnd = new Random();
		private int goldAmount;
		public int goldamount
		{
			get
			{
				return goldamount;
			}
			set
			{
				goldamount = value;
			}
		}
		public GoldClass(int x, int y) : base(x, y)
		{
			goldamount = goldrnd.Next(1, 5);
		}
	}
}
