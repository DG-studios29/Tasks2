using System;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	abstract class CharacterClass : TileClass
	{
		public enum Movement
		{
		
			Up,
			Down,
			Left,
			Right,
			Nomovement
		}


		protected int HP;
		public int hp
		{
			get
			{
				return HP;
			}
			set
			{
				HP = value;
			}
		}


		protected int MaxHP;
		public int maxHP
		{
			get
			{
				return MaxHP;
			}
			set
			{
				MaxHP = value;
			}
		}



		protected int Damage;
		public int damage
		{
			get
			{
				return Damage;
			}
			set
			{
				Damage = value;
			}
		}



		protected TileClass[] characterVision;
		public TileClass[] CharacterVision
		{
			get
			{
				return characterVision;
			}
			set
			{
				characterVision = value;
			}
		}

		public CharacterClass(int temphp, int tempmaxHP, int tempdamage, TileClass[] tempcharacterVision, int x, int y, tileType typetemp) : base(x, y, typetemp)
		{

			this.hp = temphp;
			this.maxHP = tempmaxHP;
			this.damage = tempdamage;
			CharacterVision = tempcharacterVision;

		}

		public CharacterClass(int Xtemp, int Ytemp, tileType typetemp) : base(Xtemp, Ytemp, typetemp)
		{
		}

		public virtual void Attack(CharacterClass target)
		{
			target.setHp(target.getHp() - this.damage);
		}
		public bool IsDead()
		{
			if (HP <= 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public virtual bool checkRange(CharacterClass target)
		{
			// use distanceto < 1 return true
			if (DistanceTo(target) > 1)
			{
				return true;

			}
			else
			{// use distanceto > 1 return true

				return false;
			}

		}
		private int DistanceTo(CharacterClass target)
		{
			return (Math.Abs(base.x - target.x) + Math.Abs(base.y - target.y));
		}

		public void Move(Movement move)
		{

			if (move == Movement.Up) { --this.y; }
			else if (move == Movement.Down) { ++this.y; }
			else if (move == Movement.Left) { --this.x; }
			else if (move == Movement.Right) { ++this.x; }
			else { }
		}

		public abstract override string ToString();

		private int distanceTo(CharacterClass target)
		{
			int x= Math.Abs(target.getX() - this.x);
			int y = Math.Abs(target.getY() - this.y);

			return x + y;
		}
		public void setHp(int hp)
		{
			this.hp = hp;
			if (hp <= 0)
			{
				hp = 0;
			}
		}
		public int getHp()
		{
			return this.hp;
		}

		public void setMaxHp(int max_hp)
		{
			this.MaxHP = max_hp;
		}

		public int getMaxHp()
		{
			return this.MaxHP;
		}

		public void setDamage(int damage)
		{
			this.damage = damage;
		}

		public int getDamage()
		{
			return this.damage;
		}
		public void setVision(TileClass[] characterVision)
		{
			this.characterVision = characterVision;
		}

		public TileClass[] getVision()
		{
			return this.characterVision;
		}
		public abstract Movement returnMove(Movement move = 0);

		
		

		

		

		



	}
}


