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
            //problems 
            // 1) need to modify health of hero during battle 
            // 2) need to stop battle once hero health is depleted 


            // TEST 2
            // hi - Hello there 
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


            // NEED TO DO
            // need to find a way in whcih they fight, maybe a array with only two indexs
            // when one slot is emptied it is filled from que ?
            // test whether hero helath end enemy health is zero?


            Hero myHero;            
            
            // Main Character code below 
            Console.WriteLine("Enter your Hero Name");
            //string name = Console.ReadLine();
            string name = "Hero2077";
            Console.WriteLine("Choose your sex- m or f");
            while (true)
            {
                //string sex = Console.ReadLine();
                string sex = "m";
                if (sex == "m")
                {                    
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
            while (true) 
            {
                //string weapon = Console.ReadLine();
                string weapon = "Sword";
                if (weapon == "Sword")
                {
                    myHero = new Sword(myHero);
                    Weapon = weapon; 
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

            myHero.getHeroStats();

            Console.WriteLine("Choose first of two buffs to add to your character");
            Console.WriteLine("Choose from the below\n'Unyielding strength' (+25 str) - type str\n" +
                "'As Swift as the wind' (+25 spd) - type spd\n" + "'Holy Fortitute' (+25 hth) - type hth");
            while (true)
            {
                //string buff1 = Console.ReadLine();
                string buff1 = "str";
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
                    myHero = new hthBuff(myHero);
                    Buff1 = buff1;
                    break;
                }
                else
                    Console.WriteLine("please make a valid selection");
            }
            myHero.getHeroStats();



            Console.WriteLine("Choose Second of two buffs to add to your character - can not repeat");
            Console.WriteLine("Choose from the below\n'Unyielding strength' (+25 str) - type str\n" +
                "'As Swift as the wind' (+25 spd) - type spd\n" + "'Holy Fortitute' (+25 hth) - type hth");
            while (true)
            {
                //string buff2 = Console.ReadLine();
                string buff2 = "hth";
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
                    myHero = new hthBuff(myHero);
                    //Buff2 = buff2;
                    break;
                }
                else
                    Console.WriteLine("please make a valid selection");
            } 
            myHero.getHeroStats();


            
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

            level1.Add(new Enemy(spearMan, 1, 1, 1)); // are modifers to strength, speed and health ???
            level1.Add(new Enemy(axeMan, 1, 1, 1));
            level1.Add(new Enemy(swordMan, 1, 1, 1));
            level1.Add(new Enemy(bowMan, 1, 1, 1));
            level1.Add(new Enemy(bossMan, 1, 1, 1)); // no mods for level 1 

            // create level 1 sprear 2 and 3 into the dictionary factory 

            // not using all at the same time 
            // have setters to bumb the enemies up 

            
            /*
            foreach (var item in level1)
            {
                Console.WriteLine("health " + item.Health + " Strength " + item.Strength + " Speed" + item.Speed);
            }
            Console.WriteLine(" ");
            
            level2.Add(new Enemy(spearMan, 2, 2, 2)); // increase by 1 
            level2.Add(new Enemy(axeMan, 2, 2, 2));
            level2.Add(new Enemy(swordMan, 2, 2, 2));
            level2.Add(new Enemy(bowMan, 2, 2, 2));
            level2.Add(new Enemy(bossMan, 2, 2, 2));

            foreach (var item in level2)
            {
                Console.WriteLine("health " + item.Health + " Strength " + item.Strength + " Speed" + item.Speed);
            }
            Console.WriteLine(" ");

            */
            //level3.Add(new Enemy(spearMan, 3, 3, 3)); // increase by 2 
            //level3.Add(new Enemy(axeMan, 3, 3, 3));
            //level3.Add(new Enemy(swordMan, 3, 3, 3));
            //level3.Add(new Enemy(bowMan, 3, 3, 3));
            //level3.Add(new Enemy(bossMan, 3, 3, 3));
            
            foreach (var item in level3)
            {
                Console.WriteLine("health " + item.Health + " Strength " + item.Strength + " Speed" + item.Speed);
            }  
            

            

        
           

            // create a loop to add enemiies into battle 

            bool survive = true;

            do
            {
                Console.WriteLine("###########################Test###########################");

                for (int i = 0; i < level1.Count; i++)
                {
                    Console.WriteLine("enemy has been queued up " + level1[i].Health);
                    int tester = Battle(myHero, level1[i]);
                    Console.WriteLine(tester);
                    myHero.Health = tester;
                    if (tester <= 0)
                    {
                        survive = false;
                        Console.WriteLine("Your hero is perished");
                        break;
                    }
            
                    Console.WriteLine("hero health " + myHero.Health);
                    //if(myHero.getHeroHth() == 0)
                    //{
                    //    break;
                    //}
                }
            

                Console.WriteLine("###########################Test###########################");


            } while (survive==true);



            /*
            myHero.getHeroStats(myHero.Strength, myHero.Speed, myHero.Health);
            Console.WriteLine("enemyTYPE: " + level2[0].Type);

            //Console.WriteLine("enemy str: "+enemy.); //need a way to find enemy health.
            Console.WriteLine();



            Console.WriteLine("##############################################################");

            // view level enemy types 
            foreach (var item in level1)
            {
                Console.WriteLine(item.EnemyModel.Type);
            }


            // break levels into sub levels 
            Queue<Enemy> level1p1 = new Queue<Enemy>();
            foreach (var item in level1)
            {
                level1p1.Enqueue(item);
            }

            */
            //
            // List -  add the hero and one enemy to alost at a time
            // take turns 
            // do while perosn has health 
            // read line (attack or heal)
            // attack roll and damage roll 
            // attack roll will test if its faster than the person speed value
            // roll dice for example to generate random number and if number is higher than speed then attack will hit 
            // trigger attack 

            // attack() if value higher than spd value then it hits and clalls damage 
            // damage() random number from 10-30 taken from healthpoints of that person 
            // after beat level you will be awarede a power up - 
            // random bonus to hth spd or str 



            /*
            // test to see if i can kill enemies 
            foreach (var item in level1p1)
            {
                item.EnemyModel.Health = 0;
            }

            // if enemy is defeated remove from que ad to array list - dead bodies 
            ArrayList defeatedEnemies = new ArrayList();
            foreach (var item in level1p1)
            {
                if (item.EnemyModel.Health == 0) // if their health is equal to zero then add to this
                {
                    defeatedEnemies.Add(item);
                }
            }

            Console.WriteLine("You have defeated this many enemies " + defeatedEnemies.Count);
            // view all enemies defeated 

            */



            // levae decorator part for custimazation of main character, will starts with 5 strength, health speed for example 
            // decorator will be assigned 10 points for player to distrubute 
            // enemies should be standard and can add modifiers 

            //Battle(myHero, level1[0]);

        }


        // auto battle, take turns to attack between hero and enemy
        //function return a string value, "heroWin" or "enemyWin"
        //return a collenction which has enemy information

        
        private static int Battle(Hero myHero, Enemy enemy)
        {
            //Battle battle = new Battle();
            double hhp = myHero.Health;
            double ehp = enemy.Health;
            int i = (myHero.Speed >= enemy.Speed) ? 2 : 0; //test who will attack first

            Random rd = new Random();

            double weaponModifier = ElementDamageMuliplier(myHero.HeroType, enemy.Type);

            while(true)
            {
                if (i % 2 == 0) //when i is even, which means the hero's turn to attack
                {
                    double random = (double)rd.Next(3, 7) / 5;
                    int damage = (int)(myHero.Strength * random * weaponModifier);
                    ehp -= damage; // character Strength * (random strenth muliplier from 0.6X to 1.2X) * Weapon type modifier
                    Console.WriteLine("Hero attacked and cause {0} to the enemy {1}/{2}", damage,ehp,enemy.Health);
                    //Console.WriteLine("strength: {0} Random: {1} WeaponModifier {2}", myHero.Strength, random, weaponModifier);
                    i++;
                }
                else //when i is odd, which means the enemy's turn to attack
                {
                    double random = (double)rd.Next(3, 7) / 5;
                    int damage = (int)(enemy.Strength * random * weaponModifier);
                    hhp -= damage;
                    //battle.setHeroHth(damage);
                    //myHero.setHealth(damage);
                    Console.WriteLine("The enemy cause {0} to our hero {1}/{2}", damage, hhp, myHero.Health);
                    //Console.WriteLine("strength: {0} Random: {1} WeaponModifier {2}", myHero.Strength, random, weaponModifier);
                    i++;
                }
                //if either side's hp is nonpositive, the battle ends 

                if (ehp <= 0)
                {
                    Console.WriteLine("The enemy is defeated");
                    break;
                }
                else if (hhp <= 0)
                {
                    break;
                }

            }
            return (int)hhp;
            //return winner;
            //return myHero.getHeroStats(myHero.Strength, myHero.Speed, myHero.Health);
        }

        //private static void Reward(Hero myHero)
        //{
        //    Random rd = new Random();
        //    int i = rd.Next(1, 4);
        //    switch (i)
        //    {
        //        case 1:

        //        default:
        //            break;
        //    }

        //}

        private static double ElementDamageMuliplier(string t1, string t2)
        {
            if(t1.Equals("Sword Man") && t2.Equals("Bow Man"))
            {
                return 1.5;
            }
            if (t1.Equals("Bow Man") && t2.Equals("Axe Man"))
            {
                return 1.5;
            }
            if (t1.Equals("Axe Man") && t2.Equals("Spear Man"))
            {
                return 1.5;
            }
            if (t1.Equals("Spear Man") && t2.Equals("Sword Man"))
            {
                return 1.5;
            }
            return 1.1;
        }


    }
}
