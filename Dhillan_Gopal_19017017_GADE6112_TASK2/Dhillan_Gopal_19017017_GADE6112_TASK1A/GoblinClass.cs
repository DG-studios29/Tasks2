using System;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class GoblinClass : EnemyClass
	{

		public GoblinClass(int x, int y) : base(x, y, TileClass.tileType.Enemy, 1, 10)
		{

		}

		public override Movement returnMove(CharacterClass.Movement move)
		{
			int[] possible_moves = { 0, 1, 2, 3 };
			Boolean moveFound = false;
			CharacterClass.Movement direction = CharacterClass.Movement.Nomovement;


			while (!moveFound)
			{
				direction = (CharacterClass.Movement)possible_moves[rnd.Next(0, possible_moves.Length)];

				if (this.characterVision[(int)direction] is EmptyTileClass)
				{
					moveFound = true;

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
					moveFound = true;
				}

			}
			return direction;

		}

	}

}
