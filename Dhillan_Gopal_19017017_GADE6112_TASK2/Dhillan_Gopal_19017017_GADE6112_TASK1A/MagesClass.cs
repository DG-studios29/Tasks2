using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
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
			
		}

		public override Movement returnMove(Movement move = Movement.Nomovement)
		{
			throw new NotImplementedException();
		}
		public override changeRange()
		{

		}
	}
}
