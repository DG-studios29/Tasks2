using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		}

		public override string ToString()
		{
			string infoDisplay = "";
			infoDisplay += "Player Stats: " + HP.ToString() + "\n";
			infoDisplay += x.ToString() ;
			infoDisplay += y.ToString() ;
			infoDisplay += "Damage: 2 "+ damage.ToString() + "\n";
			return infoDisplay;
			
		}

		public override Movement returnMove(Movement move)
		{
			{
				if (this.characterVision[(int)move] is EmptyTileClass)
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
