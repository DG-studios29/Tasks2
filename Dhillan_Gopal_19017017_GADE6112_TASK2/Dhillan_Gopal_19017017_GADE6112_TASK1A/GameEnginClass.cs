using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
    [Serializable]
    class GameEnginClass
    {
        private MapClass map;

        public GameEnginClass(int min_width, int max_width, int min_height, int max_height, int num_enemies,int gold)
        {
            map = new MapClass(min_width, max_width, min_height, max_height, num_enemies,gold);
        }
        public GameEnginClass()
        { }
        public TileClass[,] getMapView()
        {
            return map.getMap();
        }

        public int getWidth()
        {
            return map.getWidth();
        }

        public int getHeight()
        {
            return map.getHeight();
        }

        public string getHeroStats()
        {
            return map.getHero().ToString();
        }

        public string getEnemiesRemaining()
        {
            string info = "";

            for (int i = 0; i < map.getEnemies().Length; ++i)
            {
                if (i <= 5)
                {
                    info += map.getEnemies()[i].ToString() + "\n\n";
                }
            }

            if (map.getEnemies().Length > 6)
            {
                info += "+" + (map.getEnemies().Length - 6) + " more enem" + ((map.getEnemies().Length - 6) > 1 ? "ies" : "y");
            }

            return info;
        }

        public string getAttackingOptions()
        {
            string info = "";

            if (map.getHero().getVision()[0] is EnemyClass) { info += "[UP]  " + map.getHero().getVision()[0].ToString() + "\n\n"; }
            if (map.getHero().getVision()[1] is EnemyClass) { info += "[DOWN]  " + map.getHero().getVision()[1].ToString() + "\n\n"; }
            if (map.getHero().getVision()[2] is EnemyClass) { info += "[LEFT]  " + map.getHero().getVision()[2].ToString() + "\n\n"; }
            if (map.getHero().getVision()[3] is EnemyClass) { info += "[RIGHT]  " + map.getHero().getVision()[3].ToString() + "\n\n"; }

            return info;
        }

        public Boolean movePlayer(CharacterClass.Movement move)
        {
            if (map.getHero().returnMove(move) != CharacterClass.Movement.Nomovement)
            {
                map.updateCharaterPosition(map.getHero(), move);
                moveEnemies();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remainStill()
        {
            moveEnemies();
            return true;
        }

        private void moveEnemies()
        {
            EnemyClass[] enemies = map.getEnemies();

            for (int i = 0; i < enemies.Length; ++i)
            {
                CharacterClass.Movement move = enemies[i].returnMove(CharacterClass.Movement.Nomovement);  //None is just a placeholder
                map.updateCharaterPosition(enemies[i], move);
            }
        }

        public String attackEnemy(CharacterClass.Movement move)
        {
            HeroClass h = map.getHero();
            TileClass target = new EmptyTileClass(0, 0); 

            switch (move)
            {
                case CharacterClass.Movement.Up:
                    target = map.getMap()[h.getY() - 1, h.getX()];
                    break;
                case CharacterClass.Movement.Down:
                    target = map.getMap()[h.getY() + 1, h.getX()];
                    break;
                case CharacterClass.Movement.Left:
                    target = map.getMap()[h.getY(), h.getX() - 1];
                    break;
                case CharacterClass.Movement.Right:
                    target = map.getMap()[h.getY(), h.getX() + 1];
                    break;
            }

            if (target is EnemyClass)
            {

                h.Attack((CharacterClass)target);
                CharacterClass c_target = (CharacterClass)target;

                if (c_target.IsDead())
                {
                    map.removeFromMap(c_target);
                }

                moveEnemies();

                if (!c_target.IsDead())
                {
                    return "1" + c_target.ToString();     //Returning 1 infront of string indicates success
                }
                else
                {
                    return "1The enemy is dead";
                }

            }
            else
            {
                return "0";                         //Returning 0 infront of string indicates failure
            }


        }
        public Boolean saveGame()
        {
            try
            {
                FileStream file = new FileStream("save.dat", FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, map);

                file.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        static public MapClass loadGame()
        {
            try
            {
                FileStream file = new FileStream("save.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                MapClass m = (MapClass)bf.Deserialize(file);

                file.Close();

                return m;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public void setMap(MapClass loadMap)
		{
            this.map = loadMap;
		}
    }
}
