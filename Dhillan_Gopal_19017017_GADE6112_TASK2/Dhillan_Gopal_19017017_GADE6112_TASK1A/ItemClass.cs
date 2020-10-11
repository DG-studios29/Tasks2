using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{	[Serializable]
	abstract class ItemClass : TileClass
	{
		protected ItemClass(int x, int y) : base(x, y)
		{

		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
