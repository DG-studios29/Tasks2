using System;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class GoldClass : ItemClass
	{
		private Random goldrnd = new Random();
		private int goldAmount;
		
		public int getgoldAmount()
		{
			return goldAmount;
		}
		public GoldClass(int x, int y) : base(x, y)
		{
			this.type = TileClass.tileType.Gold;
			goldAmount = goldrnd.Next(1, 5);
		}
	}
}
