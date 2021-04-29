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
                        enemyModel = new EnemyModel("Spear Man", 10, 50, 45); // str, spd, hth 
                        break;
                    case "Axe":
                        enemyModel = new EnemyModel("Axe Man", 12, 40, 55);
                        break;
                    case "Sword":
                        enemyModel = new EnemyModel("Sword Man", 11, 45, 40);
                        break;
                    case "Bow":
                        enemyModel = new EnemyModel("Bow Man", 8, 80, 30);
                        break;
                    case "Boss":
                        enemyModel = new EnemyModel("Boss", 20, 75, 100);
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
}
