using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStrFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // patterns so far 
            // Singleton, Factory, Flyweight, adapter???(interface class)
            // need to do decorator for main character and observer for status changes 

            // data structure so far 
            // Dictionary, List, ArrayList, Que (ned one more at leaast)

            EnemyModelFactory enemy = EnemyModelFactory.getEnemyModelFactory();

            IEnemyModel spearMan = enemy.getEnemyModel("Spear");
            IEnemyModel axeMan = enemy.getEnemyModel("Axe");
            IEnemyModel swordMan = enemy.getEnemyModel("Sword");
            IEnemyModel bowMan = enemy.getEnemyModel("Bow");
            IEnemyModel bossMan = enemy.getEnemyModel("Boss"); // 2x strong or some special ability ???

            List<Enemy> level1 = new List<Enemy>();
            List<Enemy> level2 = new List<Enemy>();
            List<Enemy> level3 = new List<Enemy>();

            level1.Add(new Enemy(spearMan, 0,0,0)); // 0 0 are modifers to strength, speed and health ???
            level1.Add(new Enemy(axeMan, 0, 0, 0));
            level1.Add(new Enemy(swordMan, 0, 0, 0));
            level1.Add(new Enemy(bowMan, 0, 0, 0));
            level1.Add(new Enemy(bossMan, 0, 0, 0)); // no mods for level 1 

            level2.Add(new Enemy(spearMan, 1, 1, 1)); 
            level2.Add(new Enemy(axeMan, 1, 1, 1));
            level2.Add(new Enemy(swordMan, 1, 1, 1));
            level2.Add(new Enemy(bowMan, 1, 1, 1));
            level2.Add(new Enemy(bossMan, 1, 1, 1)); 

            level3.Add(new Enemy(spearMan, 2, 2, 2)); 
            level3.Add(new Enemy(axeMan, 2, 2, 2));
            level3.Add(new Enemy(swordMan, 2, 2, 2));
            level3.Add(new Enemy(bowMan, 2, 2, 2));
            level3.Add(new Enemy(bossMan, 2, 2, 2));

            // view level enemy types 
            foreach (var item in level1)
            {
                Console.WriteLine(item.enemyModel.Type);
            }


            // break levels into sub levels 
            Queue<Enemy> level1p1 = new Queue<Enemy>();
            foreach (var item in level1)
            {
                level1p1.Enqueue(item);
            }

            // test to see if i can kill enemies 
            foreach (var item in level1p1)
            {
                item.enemyModel.Health = 0;
            }

            // if enemy is defeated remove from que ad to array list - dead bodies 
            ArrayList defeatedEnemies = new ArrayList();
            foreach (var item in level1p1)
            {
                if (item.enemyModel.Health == 0) // if their health is equal 2 zero then add to this
                {
                    defeatedEnemies.Add(item);
                }
            }

            Console.WriteLine("You have defeated this many enemies " + defeatedEnemies.Count);
            // view all enemies defeated 

            


            // levae decorator part for custimazation of main character, will starts with 5 strength, health speed for example 
            // decorator will be assigned 10 points for player to distrubute 
            // enemies should be standard and can add modifiers 
        }
    }
}
