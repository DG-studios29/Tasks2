using System;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{

	[Serializable]
	class EmptyTileClass : TileClass
	{
		public EmptyTileClass(int x, int y) : base(x, y)
		{
			this.x = x;
			this.y = y;
		}


	}
}
