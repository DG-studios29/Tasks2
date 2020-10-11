using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{ [Serializable]
		class MagesClass : EnemyClass
		{

			private int magesDamage;
			public int Magesdamage
			{
				get
				{
					return Magesdamage;
				}
				set
				{
					Magesdamage = value;
				}
			}
			private int magesHp;

			public int magesHP
			{
				get
				{
					return magesHP;
				}
				set
				{
					magesHP = value;
				}
			}
			public MagesClass(int x, int y, tileType type, int damage, int hp) : base(x, y, type, damage, hp)
			{
				magesHp = 5;
				Magesdamage = 5;
			}

			public override Movement returnMove(Movement move = 0)
			{
				return 0;
				
			}
			public override bool checkRange(CharacterClass target)
		{
				bool enmeyFound = false;
				for (int i = 0; i < characterVision.Length; ++i)
				{
					if (characterVision[i] is EnemyClass || characterVision[i] is HeroClass)
					{
						enmeyFound = true;

					}
				}
				return enmeyFound;

			}
		}
	
}
