using System;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class HeroClass : CharacterClass
	{

		public HeroClass(int x, int y, int hp) : base(x, y, TileClass.tileType.Hero)
		{
			this.setHp(hp);
			this.setMaxHp(hp);
			this.setDamage(2);
			this.type = TileClass.tileType.Hero;
		}

		public override string ToString()
		{
			string infoDisplay = "";
			infoDisplay += "Player Hp: " + HP.ToString() + "\n";
			infoDisplay += "X Postion: " + x.ToString() + "\t";
			infoDisplay += "Y Postion: " + y.ToString() + "\t" + "\n";
			infoDisplay += "Damage: 2 " + damage.ToString() + "\n";
			infoDisplay += "Amount of gold: " + this.getgoldAmount();
			return infoDisplay;

		}

		public override Movement returnMove(Movement move)
		{
			{
				if (this.characterVision[(int)move] is EmptyTileClass || this.characterVision[(int)move] is GoldClass)
				{
					return move;
				}
				else
				{
					return Movement.Nomovement;
				}
			}
		}


	}
}
