using System.Collections.Generic;

namespace DataStrFinalProject
{
    internal class EnemyModelFactory
    {
        Dictionary<string, EnemyModel> enemyModelList = new Dictionary<string, EnemyModel>();
        private static EnemyModelFactory uniqueModel = new EnemyModelFactory();
        internal static EnemyModelFactory getEnemyModelFactory()
        {
            return uniqueModel;
        }

        internal IEnemyModel getEnemyModel(string type)
        {
            if (!enemyModelList.ContainsKey(type))
            {
                EnemyModel enemyModel;
                switch (type)
                {
                    case "Spear":
                        enemyModel = new EnemyModel("Spear Man", 10, 50, 75); // str, spd, hth 
                        break;
                    case "Axe":
                        enemyModel = new EnemyModel("Axe Man", 12, 40, 85);
                        break;
                    case "Sword":
                        enemyModel = new EnemyModel("Sword Man", 11, 45, 80);
                        break;
                    case "Bow":
                        enemyModel = new EnemyModel("Bow Man", 8, 80, 50);
                        break;
                    case "Boss":
                        enemyModel = new EnemyModel("Boss", 20, 100, 150);
                        break;
                    default:
                        enemyModel = null;
                        break;
                }
                enemyModelList[type] = enemyModel; // add type to dictionary for use later 
            }
            return enemyModelList[type]; // return type if already created 
        }

        private EnemyModelFactory()
        {
        }

        public int getHealth(string type)
        {
            int health;
            switch (type)
            {
                case "Spear":
                    health = 75 + Enemy.HTHBuff;
                    break;
                case "Axe":
                    health = 85 + Enemy.HTHBuff;
                    break;
                case "Sword":
                    health = 80 + Enemy.HTHBuff;
                    break;
                case "Bow":
                    health = 50 + Enemy.HTHBuff;
                    break;
                case "Boss":
                    health = 150 + Enemy.HTHBuff;
                    break;
                default:
                    health = 0;
                    break;
            }
            return health;
        }
    }

    internal class EnemyModel : IEnemyModel
    {
        public EnemyModel(string type, int strength, int speed, int health)
        {
            Type = type;
            Strength = strength;
            Speed = speed;
            Health = health;
        }
        public EnemyModel()
        {

        }

        public string Type { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
    }
}
