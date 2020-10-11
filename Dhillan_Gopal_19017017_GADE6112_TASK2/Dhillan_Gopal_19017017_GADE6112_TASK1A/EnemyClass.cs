using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	abstract class EnemyClass : CharacterClass
	{
		protected Random rnd = new Random();
		public EnemyClass(int x, int y, TileClass.tileType type, int damage, int hp) : base(x, y, type)
		{
			setDamage(damage);
			setHp(hp);
			setMaxHp(hp);
			this.type = TileClass.tileType.Enemy;
		}


		public override string ToString()
		{
			string infoDisplay = "";
			infoDisplay += "Enemies in Game\n\n";
			infoDisplay += x.ToString();
			infoDisplay += y.ToString() + "\n";
			infoDisplay += "Damage: " + damage.ToString();
			return infoDisplay;
			
		}

		
	}
}
