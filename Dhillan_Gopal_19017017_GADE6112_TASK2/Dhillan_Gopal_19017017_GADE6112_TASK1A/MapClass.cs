﻿using System;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class MapClass
	{
		public Random rnd = new Random();
		private ItemClass[] iteams;
		private TileClass[,] map;
		private HeroClass hero;
		private EnemyClass[] enemies;
		private int width;
		private int height;

		public MapClass(int min_width, int max_width, int min_height, int max_height, int num_enemies, int gold)
		{
			this.width = rnd.Next(min_width, max_width + 1);
			this.height = rnd.Next(min_height, max_height + 1);

			this.map = new TileClass[height, width];


			int max_num_enemies = ((width - 2) * (height - 2)) - 1;
			if (num_enemies > max_num_enemies)
			{
				num_enemies = max_num_enemies;
			}
			this.enemies = new EnemyClass[num_enemies];

			generateEmptyMap();
			this.hero = (HeroClass)create(TileClass.tileType.Hero);
			map[hero.getY(), hero.getX()] = hero;

			for (int i = 0; i < enemies.Length; ++i)
			{
				enemies[i] = (EnemyClass)create(TileClass.tileType.Enemy);
				map[enemies[i].getY(), enemies[i].getX()] = enemies[i];
			}

			int maxnumGold = ((width - 2) * (height - 2)) - 1 - enemies.Length;
			if (gold > maxnumGold)
			{
				gold = maxnumGold;
			}
			this.iteams = new ItemClass[gold];

			
			for (int i = 0; i < iteams.Length; ++i)
			{
				iteams[i] = (GoldClass)create(TileClass.tileType.Gold);
				map[iteams[i].getY(), iteams[i].getX()] = iteams[i];
			}
			updateVision();

		}

		private void generateEmptyMap()
		{
			for (int i = 0; i < height; ++i)
			{
				for (int j = 0; j < width; ++j)
				{
					if (i == 0 || i == (height - 1))
					{
						map[i, j] = new ObstacleClass(i, j);
					}
					else if (j == 0 || j == (width - 1))
					{
						map[i, j] = new ObstacleClass(i, j);
					}
					else
					{
						map[i, j] = new EmptyTileClass(i, j);
					}
				}
			}
		}

		private TileClass create(TileClass.tileType type)
		{
			int[] spawnLocation = getSpawnPosition();

			if (type == TileClass.tileType.Hero)
			{
				return new HeroClass(spawnLocation[1], spawnLocation[0], 10);
			}
			else if (type == TileClass.tileType.Enemy)
			{
				return enemyGen(spawnLocation[1], spawnLocation[0]);
			}
			else if (type == TileClass.tileType.Gold)
			{
				return new GoldClass(spawnLocation[1], spawnLocation[0]);
			}
			else
			{
				return new EmptyTileClass(spawnLocation[1], spawnLocation[0]);
			}

		}
		public EnemyClass enemyGen(int y, int x)// this will give a random enemy
		{
			if (rnd.Next(1, 3) == 1)
			{
				return new MagesClass(y, x, TileClass.tileType.Enemy, 5, 5);
			}
			else
			{
				return new GoblinClass(y, x);
			}
		}

		private void updateVision()
		{
			hero.setVision(returnVision(hero.getX(), hero.getY()));

			for (int i = 0; i < enemies.Length; ++i)
			{

				enemies[i].setVision(returnVision(enemies[i].getX(), enemies[i].getY()));
			}
		}

		public void foucsUpdateVision()
		{
			updateVision();
		}

		public void removeFromMap(TileClass character)
		{
			if (character.getTileType() == TileClass.tileType.Enemy)
			{
				EnemyClass[] new_list = new EnemyClass[enemies.Length - 1];
				int index = 0;

				for (int i = 0; i < enemies.Length; ++i)
				{
					if (enemies[i].IsDead())
					{
						map[enemies[i].getY(), enemies[i].getX()] = new EmptyTileClass(enemies[i].getY(), enemies[i].getX());
					}
					else
					{
						new_list[index] = enemies[i];
						++index;
					}
				}

				enemies = new_list;
				updateVision();
			}
		}

		public void updateCharaterPosition(TileClass character, CharacterClass.Movement direction)
		{
			CharacterClass c = (CharacterClass)map[character.getY(), character.getX()];
			EmptyTileClass emp;

			switch (direction)
			{
				case CharacterClass.Movement.Up:
					emp = (EmptyTileClass)map[c.getY() - 1, c.getX()];
					map[c.getY() - 1, c.getX()] = c;
					map[c.getY(), c.getX()] = emp;
					c.Move(CharacterClass.Movement.Up);
					emp.setY(emp.getY() + 1);
					break;
				case CharacterClass.Movement.Down:
					emp = (EmptyTileClass)map[c.getY() + 1, c.getX()];
					map[c.getY() + 1, c.getX()] = c;
					map[c.getY(), c.getX()] = emp;
					c.Move(CharacterClass.Movement.Down);
					emp.setY(emp.getY() - 1);
					break;
				case CharacterClass.Movement.Left:
					emp = (EmptyTileClass)map[c.getY(), c.getX() - 1];
					map[c.getY(), c.getX() - 1] = c;
					map[c.getY(), c.getX()] = emp;
					c.Move(CharacterClass.Movement.Left);
					emp.setX(emp.getX() + 1);
					break;
				case CharacterClass.Movement.Right:
					emp = (EmptyTileClass)map[c.getY(), c.getX() + 1];
					map[c.getY(), c.getX() + 1] = c;
					map[c.getY(), c.getX()] = emp;
					c.Move(CharacterClass.Movement.Right);
					emp.setX(emp.getX() - 1);
					break;
			}

			this.updateVision();
		}

		private TileClass[] returnVision(int x, int y)
		{
			TileClass[] characterVision = new TileClass[8];
			
			characterVision[0] = map[y - 1, x];  
			characterVision[1] = map[y + 1, x];  
			characterVision[2] = map[y, x - 1]; 
			characterVision[3] = map[y, x + 1];  

			//Mage character Vision
			characterVision[4] = map[y - 1, x + 1];  
			characterVision[5] = map[y + 1, x + 1];  
			characterVision[6] = map[y + 1, x - 1];  
			characterVision[7] = map[y - 1, x - 1]; 

			return characterVision;

		}

		private int[] getSpawnPosition()
		{
			int x_position = rnd.Next(1, width);
			int y_position = rnd.Next(1, height);

			if (map[y_position, x_position] is EmptyTileClass)
			{
				int[] s_point = new int[2];
				s_point[0] = y_position;
				s_point[1] = x_position;

				return s_point;
			}
			else
			{
				return getSpawnPosition();
			}
		}

		public void setMap(TileClass[,] map)
		{
			this.map = map;
		}

		public TileClass[,] getMap()
		{
			return this.map;
		}

		public void setHero(HeroClass hero)
		{
			this.hero = hero;
		}

		public HeroClass getHero()
		{
			return this.hero;
		}

		public void setEnemies(EnemyClass[] enemies)
		{
			this.enemies = enemies;
		}

		public EnemyClass[] getEnemies()
		{
			return this.enemies;
		}

		public void setWidth(int width)
		{
			this.width = width;
		}
		public ItemClass[] getiteam()
		{
			return this.iteams;
		}
		public void setItems(ItemClass[] newItems)
		{
			this.iteams = newItems;
		}
		public int getWidth()
		{
			return this.width;
		}

		public void setHeight(int height)
		{
			this.height = height;
		}

		public int getHeight()
		{
			return this.height;
		}
		public ItemClass GetItemAtPosition(int x, int y)
		{
			ItemClass item = null;
			for (int i = 0; i < iteams.Length; ++i)
			{
				if (iteams[i].getX() == x && iteams[i].getY() == y)
				{
					item = iteams[i];
				}

			}
			return item;
		}
	}
}
