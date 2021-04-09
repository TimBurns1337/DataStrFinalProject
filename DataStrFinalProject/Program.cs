using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStrFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyModelFactory enemy = EnemyModelFactory.getEnemyModelFactory();

            IEnemyModel spearMan = enemy.getCraftModel("Spear");
            IEnemyModel axeMan = enemy.getCraftModel("Axe");
            IEnemyModel swordMan = enemy.getCraftModel("Sword");
            IEnemyModel bowMan = enemy.getCraftModel("Bow");
            IEnemyModel bossMan = enemy.getCraftModel("Boss"); // 2x strong or some special ability ???

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
                Console.WriteLine(item);
            }


            // break levels into sub levels 
            Queue<Enemy> level1p1 = new Queue<Enemy>();
            foreach (var item in level1)
            {
                level1p1.Enqueue(item);
            }


            // if enemy is defeated remove from que ad to array list - dead bodies 
            ArrayList defeatedEnemies = new ArrayList();
            foreach (var item in level1p1)
            {
                if (item.health == 0) // if their health is equal 2 zero then add to this
                {
                    defeatedEnemies.Add(item);
                }
            }

            // view all enemies defeated 
            foreach (var item in defeatedEnemies)
            {
                Console.WriteLine(item);
            }

            // levae decorator part for custimazation of main character, will starts with 5 strength, health speed for example 
            // decorator will be assigned 10 points for player to distrubute 
            // enemies should be standard and can add modifiers 
        }
    }
}
