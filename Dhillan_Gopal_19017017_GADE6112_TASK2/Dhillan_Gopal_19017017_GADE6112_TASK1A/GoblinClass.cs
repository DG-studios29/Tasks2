using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class GoblinClass : EnemyClass
	{

		public GoblinClass(int x, int y) : base(x, y, TileClass.tileType.Enemy, 1, 10) { }

		public override Movement returnMove(CharacterClass.Movement Move)
		{
			int[] possible_moves = { 0, 1, 2, 3 };
			Boolean move_found = false;
			CharacterClass.Movement direction = CharacterClass.Movement.Nomovement;


			while (!move_found)
			{
				direction = (CharacterClass.Movement)possible_moves[rnd.Next(0, possible_moves.Length)];

				if (this.characterVision[(int)direction] is EmptyTileClass)
				{
					move_found = true;

				}
				else if (possible_moves.Length != 1)
				{

					int[] new_possible_moves = new int[possible_moves.Length - 1];
					int index = 0;

					for (int i = 0; i < possible_moves.Length; ++i)
					{
						if (possible_moves[i] != (int)direction)
						{
							new_possible_moves[index] = possible_moves[i];
							++index;
						}
					}

					possible_moves = new_possible_moves;
				}
				else
				{
					direction = CharacterClass.Movement.Nomovement;
					move_found = true;
				}

			}


			return direction;

		}

	}

}
