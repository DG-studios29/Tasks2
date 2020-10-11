using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{ 
       [Serializable]
    class MapClass 
	{
        public Random rnd = new Random();

        private TileClass[,] map;
        private HeroClass hero;
        private EnemyClass[] enemies;
        private int width;
        private int height;

        public MapClass(int min_width, int max_width, int min_height, int max_height, int num_enemies)
        {
            this.width = rnd.Next(min_width, max_width + 1);
            this.height = rnd.Next(min_height, max_height + 1);

            this.map = new TileClass[height, width];

            //Check that the number of enemies spawned does not exceed the limit
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
                enemies[i] = (GoblinClass)create(TileClass.tileType.Enemy);
                map[enemies[i].getY(), enemies[i].getX()] = enemies[i];
            }

            updateVision();
            Console.WriteLine(enemies.Length);
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
            int[] spawn_location = getSpawnPosition();

            if (type == TileClass.tileType.Hero)
            {
                return new HeroClass(spawn_location[1], spawn_location[0], 10);
            }
            else if (type == TileClass.tileType.Enemy)
            {
                return new GoblinClass(spawn_location[1], spawn_location[0]);
            }
            else
            {
                return new EmptyTileClass(spawn_location[1], spawn_location[0]);
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
                    emp = (EmptyTileClass)map[character.getY() - 1, character.getX()];
                    map[character.getY() - 1, character.getX()] = c;
                    map[character.getY(), character.getX()] = emp;
                    c.Move(CharacterClass.Movement.Up);
                    emp.setY(emp.getY() + 1);
                    break;
                case CharacterClass.Movement.Down:
                    emp = (EmptyTileClass)map[character.getY() + 1, character.getX()];
                    map[character.getY() + 1, character.getX()] = c;
                    map[character.getY(), character.getX()] = emp;
                    c.Move(CharacterClass.Movement.Down);
                    emp.setY(emp.getY() - 1);
                    break;
                case CharacterClass.Movement.Left:
                    emp = (EmptyTileClass)map[character.getY(), character.getX() - 1];
                    map[character.getY(), character.getX() - 1] = c;
                    map[character.getY(), character.getX()] = emp;
                    c.Move(CharacterClass.Movement.Left);
                    emp.setX(emp.getX() + 1);
                    break;
                case CharacterClass.Movement.Right:
                    emp = (EmptyTileClass)map[character.getY(), character.getX() + 1];
                    map[character.getY(), character.getX() + 1] = c;
                    map[character.getY(), character.getX()] = emp;
                    c.Move(CharacterClass.Movement.Right);
                    emp.setX(emp.getX() - 1);
                    break;
            }

            this.updateVision();
        }

        private TileClass[] returnVision(int x, int y)
        {
            TileClass[] characterVision = new TileClass[4];

            characterVision[0] = map[y - 1, x];  
            characterVision[1] = map[y + 1, x];  
            characterVision[2] = map[y, x - 1];  
            characterVision[3] = map[y, x + 1];

            characterVision[4] = map[y - 1, x - 1];
            characterVision[5] = map[y - 1, x + 1];
            characterVision[6] = map[y + 1, x - 1];
            characterVision[7] = map[y + 1, x + 1];

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
    }
}
