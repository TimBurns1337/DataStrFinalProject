using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStrFinalProject
{
    class Program
    {
        public static string Weapon;
        public static string Buff1;
        //public static string Buff2;        
        static void Main(string[] args)
        {
            // Patterns so far 
            // Singleton, Factory, Flyweight, Adapter???(interface class)
            // decorator done for main character 
            // need to do observer for status changes 

            // Data Structure so far 
            // Dictionary, List, ArrayList, Que (need one more at least)
            // maybe we can create a stack or linked list for main charcter items???
            // maybe give five potions at start, one full heal, 4 25% heals that they can access
            // they can also add to this equipment list as the defeat levels / bosses and get more eq

            // IDEAS FOR FLOW
            // use read line - give three option for user to enter 
            // attack, defend(dodge), heal
            // based on there entry changes are made 
            // actions from enemys should be random, 
            // need to come up with random way for them to gen actions 
            // speed will determin which player goes first main or enemy - simple comp
            // health, once dropped to zero, determines if you are dead or not
            // can heal but takes a turn same as attack and defend 
            // attack places damage on enemy, mitigated if they choose defend 
            // defend mitages attack from enemy 


            Hero myHero;            
            
            // Main Character code below 
            Console.WriteLine("Enter your Hero Name");
            string name = Console.ReadLine();
            Console.WriteLine("Choose your sex- m or f");
            while (true)
            {
                string sex = Console.ReadLine();
                if (sex == "m")
                {
                    //myHero = new maleHero();
                    myHero = new maleHero(name);
                    break;
                }
                if (sex == "f")
                {
                    myHero = new femaleHero(name);                    
                    break;
                }                
                else
                {
                    Console.WriteLine("Invalid selection, please try again");
                }
            }

            




            // you can customize you hero 
            // pick weapon and 2 buffs - damage speed or health 
            // you can pick from spear, sword, axe or bow 
            Console.WriteLine("Select Your weapon");
            Console.WriteLine("Choose from 'Sword', 'Spear', 'Axe', and 'Bow'");
           // string weapon = Console.ReadLine();
            while (true) 
            {
                string weapon = Console.ReadLine();
                if (weapon == "Sword")
                {
                    myHero = new Sword(myHero);
                    Weapon = weapon; // for now - will add to hero array or list for extraction
                    break;
                }
                if (weapon == "Spear")
                {
                    myHero = new Spear(myHero);
                    Weapon = weapon;
                    break;
                }
                if (weapon == "Axe")
                {
                    myHero = new Axe(myHero);
                    Weapon = weapon;
                    break;
                }
                if (weapon == "Bow")
                {
                    myHero = new Bow(myHero);
                    Weapon = weapon;
                    break;
                }   
                else 
                {
                    Console.WriteLine("Invalid selection, please try again"); 
                }
            }

            myHero.getHeroStats(); // not working properly does not work below
            // may not work great - mayb eprint individually so u can add to it 
            //Console.WriteLine("Your current strength is " + myHero.getHeroStr());
            
            //Console.WriteLine("test string " + myHero.HeroType + " " + myHero.Strength.ToString() + " ");

            
             
           
            
            Console.WriteLine("Choose first of two buffs to add to your character");
            Console.WriteLine("Choose from the below\n'Unyielding strength' (+25 str) - type str\n" +
                "'As Swift as the wind' (+25 spd) - type spd\n" + "'Holy Fortitute' (+25 hth) - type hth");
            while (true)
            {
                string buff1 = Console.ReadLine();
                if (buff1 == "str")
                {
                    myHero = new strBuff(myHero);
                    Buff1 = buff1;                    
                    break;
                }
                else if (buff1 == "spd")
                {
                    myHero = new spdBuff(myHero);
                    Buff1 = buff1;
                    break;
                }
                else if (buff1 == "hth")
                {
                    myHero = new strBuff(myHero);
                    Buff1 = buff1;
                    break;
                }
                else
                    Console.WriteLine("please make a valid selection");
            }
            Console.WriteLine("The name and class of your hero is " + myHero.getHeroType());
            Console.WriteLine("Your current strength is " + myHero.getHeroStr());
            Console.WriteLine("Your current speed is " + myHero.getHeroSpd());
            Console.WriteLine(myHero.Strength + " " + myHero.Speed);
            
                    
            
            Console.WriteLine("Choose Second of two buffs to add to your character - can not repeat");
            Console.WriteLine("Choose from the below\n'Unyielding strength' (+25 str) - type str\n" +
                "'As Swift as the wind' (+25 spd) - type spd\n" + "'Holy Fortitute' (+25 hth) - type hth");
            while (true)
            {
                string buff2 = Console.ReadLine();
                if (buff2 == "str" && Buff1 != "str")
                {
                    myHero = new strBuff(myHero);
                    //Buff2 = buff2;
                    break;
                }
                if (buff2 == "spd" && Buff1 != "spd")
                {
                    myHero = new spdBuff(myHero);
                    //Buff2 = buff2;
                    break;
                }
                if (buff2 == "hth" && Buff1 != "hth")
                {
                    myHero = new strBuff(myHero);
                    //Buff2 = buff2;
                    break;
                }
                else
                    Console.WriteLine("please make a valid selection");
            }

            //Console.WriteLine("You chose '" + Weapon + "' as your main, you have a " + Buff1 + " buff and a " + Buff2 + " buff ");
            //myHero.getHeroStats(); // not working here 
            //Console.WriteLine("test");

            Console.WriteLine("The name and class of your hero is " + myHero.getHeroType());
            Console.WriteLine("Your current strength is " + myHero.getHeroStr());
            Console.WriteLine("Your current speed is " + myHero.getHeroSpd());
            Console.WriteLine(myHero.Strength + " " + myHero.Speed);


            /*






            // Enemy Code below 

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

            level2.Add(new Enemy(spearMan, 1, 1, 1)); // 1x stronger
            level2.Add(new Enemy(axeMan, 1, 1, 1));
            level2.Add(new Enemy(swordMan, 1, 1, 1));
            level2.Add(new Enemy(bowMan, 1, 1, 1));
            level2.Add(new Enemy(bossMan, 1, 1, 1)); 

            level3.Add(new Enemy(spearMan, 2, 2, 2)); // 2x strong
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
                if (item.enemyModel.Health == 0) // if their health is equal to zero then add to this
                {
                    defeatedEnemies.Add(item);
                }
            }

            Console.WriteLine("You have defeated this many enemies " + defeatedEnemies.Count);
            // view all enemies defeated 

            


            // levae decorator part for custimazation of main character, will starts with 5 strength, health speed for example 
            // decorator will be assigned 10 points for player to distrubute 
            // enemies should be standard and can add modifiers 
            

            */
        }
    }
}
