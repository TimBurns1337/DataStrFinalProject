using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStrFinalProject
{
    class Program
    {
        public static string Weapon;
        public static string Buff1;
        public static int health;
        public static int healthUpdate;
        public static int healthConstant;
              
        static void Main(string[] args)
        {
        // LIST OF ALL DATA STRUCTURES AND PATTERNS USED 

        // Data Structures 
        // Array List in item class used to store heros items 
        // Dictionary in enemy model calss to store models of enemies 
        // List in main class to store levels and act as a place for battle
        // Queue in the main class to design and structure each stage in each level 
        // Stack to store and keep track of the enmies we have defeated 

        // Data Patterns 
        // Decorator : we used adapter in the hero creation so that the user can customize there hero the way they like,
            //pick name, sex, weapons and buffs. 
        // Adapter: we used the adapter pattern in hero and enemy creation. We made interfaces for our Hero and Enemy.
            //This allowed use to set some methods to use for both and customize that attribute and those methods as we 
            //saw fit.
        // Factory : We used the factory method in the creation of enemies.This allowed us to minimize the code 
            //required to produce lots of different enemy types easily based on the type that is passed.
        // Singleton :  We used singleton in the enemy creation as well, to make our enemy model factory class singleton.
            //This was we can make sure that no enemies can be created without using our unique instance of 
            //the enemy model factory. 
        // Flyweight: We used the flyweight method in combination with our factory method to customize the enemies 
            //as they are being created by the factory model.This again let us cut down on the code need to create 
            //and customize all the enemies.



                       Hero myHero;

            // Main Character code below 
            Console.WriteLine("Enter your Hero Name");
            string name = Console.ReadLine();
            //string name = "Hero2077";
            Console.WriteLine("Choose your sex- m or f");
            while (true)
            {
                string sex = Console.ReadLine();
                //string sex = "m";
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
                    Console.WriteLine("Choose your sex- m or f");
                }
            }
            // you can customize you hero 
            // pick weapon and 2 buffs - damage speed or health 
            // you can pick from spear, sword, axe or bow 
            Console.WriteLine("Select Your weapon");
            Console.WriteLine("Choose from 'Sword', 'Spear', 'Axe', and 'Bow'");           
            while (true) 
            {
                string weapon = Console.ReadLine();
                //string weapon = "Sword";
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
                    Console.WriteLine("Choose from 'Sword', 'Spear', 'Axe', and 'Bow'");
                }
            }

            myHero.getHeroStats(); // show hero stats 

            //***************generate the pack(itemBox) for the hero*************
            Item pack = new Item();
            pack.AddItem(myHero.WeaponType);
            pack.AddItem("Apple");
            //******************************************

            // add buffs
            Console.WriteLine("Choose first of two buffs to add to your character");
            Console.WriteLine("Choose from the below\n'Unyielding strength' (+25 str) - type str\n" +
                "'As Swift as the wind' (+25 spd) - type spd\n" + "'Holy Fortitute' (+25 hth) - type hth");
            while (true)
            {
                string buff1 = Console.ReadLine();
                //string buff1 = "str";
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
                {
                    Console.WriteLine("please make a valid selection");
                    Console.WriteLine("Choose first of two buffs to add to your character");
                    Console.WriteLine("Choose from the below\n'Unyielding strength' (+25 str) - type str\n" +
                        "'As Swift as the wind' (+25 spd) - type spd\n" + "'Holy Fortitute' (+25 hth) - type hth");
                }
                    
            }
            myHero.getHeroStats();



            Console.WriteLine("Choose Second of two buffs to add to your character - can not repeat");
            Console.WriteLine("Choose from the below\n'Unyielding strength' (+25 str) - type str\n" +
                "'As Swift as the wind' (+25 spd) - type spd\n" + "'Holy Fortitute' (+25 hth) - type hth");
            while (true)
            {
                string buff2 = Console.ReadLine();
                //string buff2 = "hth";
                if (buff2 == "str" && Buff1 != "str")
                {
                    myHero = new strBuff(myHero);                   
                    break;
                }
                if (buff2 == "spd" && Buff1 != "spd")
                {
                    myHero = new spdBuff(myHero);                    
                    break;
                }
                if (buff2 == "hth" && Buff1 != "hth")
                {
                    myHero = new hthBuff(myHero);                    
                    break;
                }
                else
                {
                    Console.WriteLine("please make a valid selection");
                    Console.WriteLine("Choose Second of two buffs to add to your character - can not repeat");
                    Console.WriteLine("Choose from the below\n'Unyielding strength' (+25 str) - type str\n" +
                        "'As Swift as the wind' (+25 spd) - type spd\n" + "'Holy Fortitute' (+25 hth) - type hth");
                }
                    
            } 
            myHero.getHeroStats();


            
            // Enemy Code below 
            EnemyModelFactory enemy = EnemyModelFactory.getEnemyModelFactory();

            IEnemyModel spearMan = enemy.getEnemyModel("Spear");
            IEnemyModel axeMan = enemy.getEnemyModel("Axe");
            IEnemyModel swordMan = enemy.getEnemyModel("Sword");
            IEnemyModel bowMan = enemy.getEnemyModel("Bow");
            IEnemyModel bossMan = enemy.getEnemyModel("Boss"); 
            

            // lists used for levels ?
            //*********************************************************************************************************
            // List - Data structure 1
            List<Enemy> level1 = new List<Enemy>();
            List<Enemy> level2 = new List<Enemy>();
            List<Enemy> level3 = new List<Enemy>();
            //***********************************************************************************************************
            // stack - data structure 2 
            Stack<Enemy> deadBodies = new Stack<Enemy>();
           
            //***************************************************************************************************************
            // queue - data structure 3 
            Queue<Enemy> level1_stage1 = new Queue<Enemy>();
            Queue<Enemy> level1_stage2 = new Queue<Enemy>();
            level1_stage1.Enqueue(new Enemy(spearMan, 1, 1, 1)); // are modifers to strength, speed and health ???
            level1_stage1.Enqueue(new Enemy(axeMan, 1, 1, 1));
            level1_stage1.Enqueue(new Enemy(swordMan, 1, 1, 1));
            level1_stage1.Enqueue(new Enemy(bowMan, 1, 1, 1));
            level1_stage1.Enqueue(new Enemy(bossMan, 1, 1, 1));

            level1_stage2.Enqueue(new Enemy(spearMan, 1, 1, 1)); // are modifers to strength, speed and health ???
            level1_stage2.Enqueue(new Enemy(axeMan, 1, 1, 1));
            level1_stage2.Enqueue(new Enemy(spearMan, 1, 1, 1)); // are modifers to strength, speed and health ???
            level1_stage2.Enqueue(new Enemy(axeMan, 1, 1, 1));
            level1_stage2.Enqueue(new Enemy(swordMan, 1, 1, 1));
            level1_stage2.Enqueue(new Enemy(bowMan, 1, 1, 1));
            level1_stage2.Enqueue(new Enemy(swordMan, 1, 1, 1));
            level1_stage2.Enqueue(new Enemy(bowMan, 1, 1, 1));
            level1_stage2.Enqueue(new Enemy(bossMan, 1, 1, 1));


            // add from stage to level 
            foreach (var item in level1_stage1)
            {                
                level1.Add(item);
            }            

            bool survive = true; // test if hero survives after each battle
            int counter = 0; // keep track of enemies 
            health = myHero.Health;
            healthUpdate = myHero.Health;
            // used to keep track of health and updates 
            string userInput;
            int tester;
            // this will store heros health value and is used to reset it when battle is done 

            // below is level 1
            Console.WriteLine("Would you like to enter level 1 stage 1? Type 'yes' or 'no'");
            userInput = Console.ReadLine();    
            
            // trying to make sure userinput is what we expect 
            while (userInput != "yes" || userInput != "no") // works but now cant escape 
            {
                if (userInput == "yes")
                {
                    do
                    {
                        Console.WriteLine("###########################LEVEL 1 Test###########################");
                        Console.WriteLine(" ");
                        Console.WriteLine("There are " + level1.Count + " enimies in this level\n");
                        Console.WriteLine("Your heros current health is --> " + myHero.Health);

                        for (int i = 0; i < level1.Count; i++)
                        {
                            counter++;
                            Console.WriteLine("An enemy has been queued up with " + level1[i].Health + " health");
                            Console.WriteLine("Enemy type: " + level1[i].Type);
                            tester = Battle(myHero, level1[i]);
                            Console.WriteLine("Number of enimies fought --> " + counter);
                            Console.WriteLine("Your heros current health is --> " + tester);
                            Console.WriteLine("");
                            myHero.Health = tester;
                            deadBodies.Push(level1[i]); // added dead enemy to stack 
                            if (tester <= 0)
                            {
                                survive = false;
                                Console.WriteLine("Your hero has perished :(");
                                Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                                Environment.Exit(0);
                                break;
                            }
                            else //if the battle is won, and hero survivedm he or she gets a reward
                            {
                                Random rd = new Random();
                                int rewardType = rd.Next(1, 6);
                                myHero = new Reward(myHero, rewardType); //test reward, should be random
                                myHero.getHeroStats();
                            }
                            if (counter == level1.Count)
                            {
                                Console.WriteLine("You defeated the stage!");                                
                                foreach (var item in deadBodies)
                                {
                                    Console.WriteLine("You deafted 1 " + item.Type);
                                }
                                Console.WriteLine("You have defeated " + deadBodies.Count + " enemies");
                                survive = false;
                                break;
                            }
                            Console.WriteLine("Current hero health " + myHero.Health);                            
                        }
                        Console.WriteLine("###########################LEVEL 1 Test###########################\n\n");
                    } while (survive == true);

                    if (counter == level1.Count)
                    {
                        survive = true;
                        myHero.Health = health; // resets health 
                        healthConstant = health;
                        tester = health;
                        counter = 0;
                        Console.WriteLine("Your survived your first battle!!!");
                        Console.WriteLine("Your heros health has been restored --> " + myHero.Health);
                        break; // break out of while loop if level beaten 
                    }
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                    Environment.Exit(0);
                    //break;
                }
                else
                {
                    Console.WriteLine("Would you like to enter level 1 stage 1? Type 'yes' or 'no'");
                    userInput = Console.ReadLine();
                }
                
            } // end of first while loop to make sure answer match with what we want 
            
            
            
            level1.Clear();

            foreach (var item in level1_stage2)
            {
                level1.Add(item);
            }           

            Console.WriteLine("Would you like to enter level 1 stage 2? Type 'yes' or 'no'");
            userInput = Console.ReadLine();


            while (userInput != "yes" || userInput != "no") // works but now cant escape 
            {
                if (userInput == "yes")
                {
                    do
                    {
                        Console.WriteLine("###########################LEVEL 1 Test###########################");
                        Console.WriteLine(" ");
                        Console.WriteLine("There are " + level1.Count + " enimies in this level\n");
                        Console.WriteLine("Your heros current health is --> " + myHero.Health);

                        for (int i = 0; i < level1.Count; i++)
                        {
                            counter++;
                            Console.WriteLine("An enemy has been queued up with " + level1[i].Health + " health");
                            Console.WriteLine("Enemy type: " + level1[i].Type);
                            tester = Battle(myHero, level1[i]);
                            Console.WriteLine("Number of enimies fought --> " + counter);
                            Console.WriteLine("Your heros current health is --> " + tester);
                            Console.WriteLine("");
                            myHero.Health = tester;
                            deadBodies.Push(level1[i]); // added dead enemy to stack 
                            if (tester <= 0)
                            {
                                survive = false;
                                Console.WriteLine("Your hero has perished :(");
                                Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                                Environment.Exit(0);
                                break;
                            }
                            else //if the battle is won, and hero survivedm he or she gets a reward
                            {
                                Random rd = new Random();
                                int rewardType = rd.Next(1, 5);
                                myHero = new Reward(myHero, rewardType); //test reward, should be random
                                myHero.getHeroStats();
                            }
                            if (counter == level1.Count)
                            {
                                Console.WriteLine("You defeated the stage!");
                                foreach (var item in deadBodies)
                                {
                                    Console.WriteLine("You deafted 1 " + item.Type);
                                }
                                Console.WriteLine("You have defeated " + deadBodies.Count + " enemies");
                                survive = false;
                                break;
                            }
                            Console.WriteLine("Current hero health " + myHero.Health);
                        }
                        Console.WriteLine("###########################LEVEL 1 Test###########################\n\n");
                    } while (survive == true);

                    if (counter == level1.Count)
                    {
                        survive = true;
                        myHero.Health = health + 1000; // doing health boost here - works - made it high for testing purposes 
                        healthUpdate = myHero.Health; // keeps track of update
                        healthConstant = healthUpdate;
                        tester = health;
                        counter = 0;
                        Console.WriteLine("Your survived your second battle!!!");
                        Console.WriteLine("Your health has been increased by 10000");
                        Console.WriteLine("Your heros health has been restored --> " + myHero.Health);
                        break; // break out of while loop if level beaten 
                    }
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                    Environment.Exit(0);
                    //break;
                }
                else
                {
                    Console.WriteLine("Would you like to enter level 1 stage 2? Type 'yes' or 'no'");
                    userInput = Console.ReadLine();
                }
               
            } // end of first while loop to make sure answer match with what we want 

            level1.Clear();



            // level 2 starts 
            Queue<Enemy> level2_stage1 = new Queue<Enemy>();
            Queue<Enemy> level2_stage2 = new Queue<Enemy>();

            level2_stage1.Enqueue(new Enemy(spearMan, 2, 2, 2));
            level2_stage1.Enqueue(new Enemy(axeMan, 2, 2, 2));
            level2_stage1.Enqueue(new Enemy(swordMan, 2, 2, 2));
            level2_stage1.Enqueue(new Enemy(bowMan, 2, 2, 2));
            level2_stage1.Enqueue(new Enemy(bossMan, 2, 2, 2));

            level2_stage2.Enqueue(new Enemy(spearMan, 2, 2, 2));
            level2_stage2.Enqueue(new Enemy(axeMan, 2, 2, 2));
            level2_stage2.Enqueue(new Enemy(spearMan, 2, 2, 2));
            level2_stage2.Enqueue(new Enemy(axeMan, 2, 2, 2));
            level2_stage2.Enqueue(new Enemy(swordMan, 2, 2, 2));
            level2_stage2.Enqueue(new Enemy(bowMan, 2, 2, 2));
            level2_stage2.Enqueue(new Enemy(swordMan, 2, 2, 2));
            level2_stage2.Enqueue(new Enemy(bowMan, 2, 2, 2));
            level2_stage2.Enqueue(new Enemy(bossMan, 2, 2, 2));
            foreach (var item in level2_stage1)
            {
                level2.Add(item);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Level two created");
            Console.WriteLine("Would you like to enter level 2 stage 1? Type 'yes' or 'no'");
            userInput = Console.ReadLine();


            while (userInput != "yes" || userInput != "no") // works but now cant escape 
            {
                if (userInput == "yes")
                {
                    do
                    {
                        Console.WriteLine("########################### LEVEL 2 ###########################");
                        Console.WriteLine(" ");
                        Console.WriteLine("There are " + level2.Count + " enimies in this level\n");
                        Console.WriteLine("Your heros current health is --> " + myHero.Health);

                        for (int i = 0; i < level2.Count; i++)
                        {
                            counter++;
                            Console.WriteLine("An enemy has been queued up with " + level2[i].Health + " health");
                            Console.WriteLine("Enemy type: " + level2[i].Type);
                            tester = Battle(myHero, level2[i]);
                            Console.WriteLine("Number of enimies fought --> " + counter);
                            Console.WriteLine("Your heros current health is --> " + tester);
                            Console.WriteLine("");
                            myHero.Health = tester;
                            deadBodies.Push(level2[i]); // added dead enemy to stack 
                            if (tester <= 0)
                            {
                                survive = false;
                                Console.WriteLine("Your hero has perished :(");
                                Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                                Environment.Exit(0);
                                break;
                            }
                            else //if the battle is won, and hero survivedm he or she gets a reward
                            {
                                Random rd = new Random();
                                int rewardType = rd.Next(1, 5);
                                myHero = new Reward(myHero, rewardType); //test reward, should be random
                                myHero.getHeroStats();
                            }
                            if (counter == level2.Count)
                            {
                                Console.WriteLine("You defeated the stage!");
                                foreach (var item in deadBodies)
                                {
                                    Console.WriteLine("You deafted 1 " + item.Type);
                                }
                                Console.WriteLine("You have defeated " + deadBodies.Count + " enemies");
                                survive = false;
                                break;
                            }
                            Console.WriteLine("Current hero health " + myHero.Health);
                        }
                        Console.WriteLine("########################### LEVEL 2 ###########################\n\n");
                    } while (survive == true);

                    if (counter == level2.Count)
                    {
                        survive = true;
                        myHero.Health = healthUpdate; // resets health 
                        tester = healthUpdate;
                        healthConstant = healthUpdate;
                        counter = 0;
                        Console.WriteLine("Your survived your third battle!!!");
                        Console.WriteLine("Your heros health has been restored --> " + myHero.Health);
                        break; // break out of while loop if level beaten 
                    }
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                    Environment.Exit(0);
                    //break;
                }
                else
                {
                    Console.WriteLine("Would you like to enter level 2 stage 1? Type 'yes' or 'no'");
                    userInput = Console.ReadLine();
                }
                
            } // end of first while loop to make sure answer match with what we want

            level2.Clear();



            // level 2 statge 2 
            foreach (var item in level2_stage2)
            {
                level2.Add(item);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Level two created");
            Console.WriteLine("Would you like to enter level 2 stage 2? Type 'yes' or 'no'");
            userInput = Console.ReadLine();

            while (userInput != "yes" || userInput != "no") // works but now cant escape 
            {
                if (userInput == "yes")
                {
                    do
                    {
                        Console.WriteLine("########################### LEVEL 2 ###########################");
                        Console.WriteLine(" ");
                        Console.WriteLine("There are " + level2.Count + " enimies in this level\n");
                        Console.WriteLine("Your heros current health is --> " + myHero.Health);

                        for (int i = 0; i < level2.Count; i++)
                        {
                            counter++;
                            Console.WriteLine("An enemy has been queued up with " + level2[i].Health + " health");
                            Console.WriteLine("Enemy type: " + level2[i].Type);
                            tester = Battle(myHero, level2[i]);
                            Console.WriteLine("Number of enimies fought --> " + counter);
                            Console.WriteLine("Your heros current health is --> " + tester);
                            Console.WriteLine("");
                            myHero.Health = tester;
                            deadBodies.Push(level2[i]); // added dead enemy to stack 
                            if (tester <= 0)
                            {
                                survive = false;
                                Console.WriteLine("Your hero has perished :(");
                                Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                                Environment.Exit(0);
                                break;
                            }
                            else //if the battle is won, and hero survivedm he or she gets a reward
                            {
                                Random rd = new Random();
                                int rewardType = rd.Next(1, 5);
                                myHero = new Reward(myHero, rewardType); //test reward, should be random
                                myHero.getHeroStats();
                            }
                            if (counter == level2.Count)
                            {
                                Console.WriteLine("You defeated the stage!");
                                foreach (var item in deadBodies)
                                {
                                    Console.WriteLine("You deafted 1 " + item.Type);
                                }
                                Console.WriteLine("You have defeated " + deadBodies.Count + " enemies");
                                survive = false;
                                break;
                            }
                            Console.WriteLine("Current hero health " + myHero.Health);
                        }
                        Console.WriteLine("########################### LEVEL 2 ###########################\n\n");
                    } while (survive == true);

                    if (counter == level2.Count)
                    {
                        survive = true;
                        myHero.Health = healthUpdate + 10000; // made very large for testing 
                        tester = healthUpdate;
                        health = myHero.Health; // keep track of next update 
                        userInput = "no";
                        counter = 0;
                        Console.WriteLine("Your survived your fourth battle!!!");
                        Console.WriteLine("Your heros health has been restored --> " + myHero.Health);
                        break; // break out of while loop if level beaten 
                    }
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                    Environment.Exit(0);
                    //break;
                }
                else
                {
                    Console.WriteLine("Would you like to enter level 2 stage 2? Type 'yes' or 'no'");
                    userInput = Console.ReadLine();
                }
                
            } // end of first while loop to make sure answer match with what we want


            // level 3 starts 
            Queue<Enemy> level3_stage1 = new Queue<Enemy>();
            Queue<Enemy> level3_stage2 = new Queue<Enemy>();

            level3_stage1.Enqueue(new Enemy(spearMan, 3, 3, 3));
            level3_stage1.Enqueue(new Enemy(axeMan, 3, 3, 3));
            level3_stage1.Enqueue(new Enemy(swordMan, 3, 3, 3));
            level3_stage1.Enqueue(new Enemy(bowMan, 3, 3, 3));
            level3_stage1.Enqueue(new Enemy(bossMan, 3, 3, 3));

            level3_stage2.Enqueue(new Enemy(spearMan, 3, 3, 3));
            level3_stage2.Enqueue(new Enemy(axeMan, 3, 3, 3));
            level3_stage2.Enqueue(new Enemy(spearMan, 3, 3, 3));
            level3_stage2.Enqueue(new Enemy(axeMan, 3, 3, 3));
            level3_stage2.Enqueue(new Enemy(swordMan, 3, 3, 3));
            level3_stage2.Enqueue(new Enemy(bowMan, 3, 3, 3));
            level3_stage2.Enqueue(new Enemy(swordMan, 3, 3, 3));
            level3_stage2.Enqueue(new Enemy(bowMan, 3, 3, 3));
            level3_stage2.Enqueue(new Enemy(bossMan, 3, 3, 3));
            foreach (var item in level3_stage1)
            {
                level3.Add(item);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Level three created");
            Console.WriteLine("Would you like to enter level 3 stage 1? Type 'yes' or 'no'");
            userInput = Console.ReadLine();

            while (userInput != "yes" || userInput != "no") // works but now cant escape 
            {

                if (userInput == "yes")
                {
                    do
                    {
                        Console.WriteLine("########################### LEVEL 3 ###########################");
                        Console.WriteLine(" ");
                        Console.WriteLine("There are " + level3.Count + " enimies in this level\n");
                        Console.WriteLine("Your heros current health is --> " + myHero.Health);

                        for (int i = 0; i < level3.Count; i++)
                        {
                            counter++;
                            Console.WriteLine("An enemy has been queued up with " + level3[i].Health + " health");
                            Console.WriteLine("Enemy type: " + level3[i].Type);
                            tester = Battle(myHero, level3[i]);
                            Console.WriteLine("Number of enimies fought --> " + counter);
                            Console.WriteLine("Your heros current health is --> " + tester);
                            Console.WriteLine("");
                            myHero.Health = tester;
                            deadBodies.Push(level3[i]);
                            if (tester <= 0)
                            {
                                survive = false;
                                Console.WriteLine("Your hero has perished :(");
                                Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                                Environment.Exit(0);
                                break;
                            }
                            if (counter == level3.Count)
                            {
                                Console.WriteLine("You defeated the stage!");
                                survive = false;
                                break;
                            }
                            Console.WriteLine("Current hero health " + myHero.Health);
                        }
                        Console.WriteLine("########################### LEVEL 3 ###########################\n\n");



                    } while (survive == true);

                    if (counter == level3.Count)
                    {
                        survive = true;
                        myHero.Health = health;
                        tester = health;
                        userInput = "no";
                        counter = 0;
                        Console.WriteLine("Your survived your fifth battle!!!");
                        Console.WriteLine("Your heros health has been restored --> " + myHero.Health);
                        break;
                    }
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Would you like to enter level 3 stage 1? Type 'yes' or 'no'");
                    userInput = Console.ReadLine();
                }
            } // while loop for answers ends here 

            level3.Clear();



            // level 2 statge 2 
            foreach (var item in level3_stage2)
            {
                level3.Add(item);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Level two created");
            Console.WriteLine("Would you like to enter level 2 stage 2? Type 'yes' or 'no'");
            userInput = Console.ReadLine();

            while (userInput != "yes" || userInput != "no") // works but now cant escape 
            {

                if (userInput == "yes")
                {
                    do
                    {
                        Console.WriteLine("########################### LEVEL 3 ###########################");
                        Console.WriteLine(" ");
                        Console.WriteLine("There are " + level3.Count + " enimies in this level\n");
                        Console.WriteLine("Your heros current health is --> " + myHero.Health);

                        for (int i = 0; i < level3.Count; i++)
                        {
                            counter++;
                            Console.WriteLine("An enemy has been queued up with " + level3[i].Health + " health");
                            Console.WriteLine("Enemy type: " + level3[i].Type);
                            tester = Battle(myHero, level3[i]);
                            Console.WriteLine("Number of enimies fought --> " + counter);
                            Console.WriteLine("Your heros current health is --> " + tester);
                            Console.WriteLine("");
                            myHero.Health = tester;
                            deadBodies.Push(level3[i]);
                            if (tester <= 0)
                            {
                                survive = false;
                                Console.WriteLine("Your hero has perished :(");
                                Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                                Environment.Exit(0);
                                break;
                            }
                            if (counter == level3.Count)
                            {
                                Console.WriteLine("You defeated the stage!");
                                survive = false;
                                break;
                            }
                            Console.WriteLine("Current hero health " + myHero.Health);
                        }
                        Console.WriteLine("########################### LEVEL 3 ###########################\n\n");



                    } while (survive == true);

                    if (counter == level3.Count)
                    {
                        survive = true;
                        myHero.Health = health;
                        tester = health;
                        userInput = "no";
                        counter = 0;
                        Console.WriteLine("Your survived your sixth battle!!!");
                        Console.WriteLine("Your heros health has been restored --> " + myHero.Health);
                        break;
                    }
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine("You have killed " + deadBodies.Count + " enemies");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Would you like to enter level 3 stage 2" +
                        "? Type 'yes' or 'no'");
                    userInput = Console.ReadLine();
                }
            } // while loop for answers ends here 



            Console.WriteLine("Play again soon!");
        }

        private static int Battle(Hero myHero, Enemy enemy)
        {
            //load the pack
            Item pack = new Item();
            //Battle battle = new Battle();
            double hhp = myHero.Health;
            double ehp = enemy.Health;
            int i = (myHero.Speed >= enemy.Speed) ? 0 : 1; //test who will attack first

            Random rd = new Random();
            string choice; // declared outside loops 
            int itemChoice;
            //string validChoice;

            double weaponModifier = ElementDamageMuliplier(myHero.HeroType, enemy.Type);

            while(true)
            {
                if (i % 2 == 0) //when i is even, which means the hero's turn
                {
                    while(true)
                    {
                        Console.WriteLine("Your Turn.  Attack-1  Heal-2 item-3");
                        choice = Console.ReadLine();
                        
                        // may want to avoid this and just use string - can still take 1 or 2 kust '1' and '2'
                        if(choice == "1")
                        {
                            double random = (double)rd.Next(3, 7) / 5;
                            int damage = (int)(myHero.Strength * random * weaponModifier);
                            ehp -= damage; // character Strength * (random strenth muliplier from 0.6X to 1.2X) * Weapon type modifier
                            Console.WriteLine("Hero attacked and cause {0} to the enemy {1}/{2}", damage, ehp, enemy.Health);                            
                            i++;
                            break;
                        }
                        else if(choice == "2"){
                            if (hhp<myHero.Health)
                            {
                                hhp += 0.1 * myHero.Health;
                                hhp = (hhp > myHero.Health) ? myHero.Health : hhp;
                                Console.WriteLine("your Healt restore {0} HP {1}/{2}", 0.1*myHero.Health,hhp,myHero.Health);
                                i++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("you are in full health.");
                            }
                        }
                        else if(choice == "3")
                        {
                            Console.Write("List of your item: ");                            
                            pack.OpenItemBox();
                            Console.WriteLine("Chose your item");
                            
                            while (true)
                            {                                
                                if(Int32.TryParse(Console.ReadLine(), out itemChoice))
                                {
                                    if (itemChoice == 0)
                                    {
                                        Console.WriteLine("You can not throw your weapon away");
                                    }
                                    else if ((itemChoice + 1) > pack.getPack().Count)
                                    {
                                        Console.WriteLine("invalid choice");
                                        break;
                                    }
                                    else
                                    {
                                        pack.UseItem(itemChoice);
                                        myHero.Strength += 25;
                                        myHero.Speed += 25;
                                        Console.WriteLine("item used both your speed and strenght increase 25");
                                        break;
                                    }
                                   
                                }
                            }
                                                                             
                            
                            Console.WriteLine("Nothing in your backpack can help you now");
                            break; 
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choice");                         
                        }
                    }
                    
                    
                }
                else //when i is odd, which means the enemy's turn to attack
                {
                    double random = (double)rd.Next(3, 7) / 5;
                    int damage = (int)(enemy.Strength * random * weaponModifier);
                    hhp -= damage;                    
                    Console.WriteLine("The enemy cause {0} to our hero {1}/{2}", damage, hhp, myHero.Health);                    
                    i++;
                }
                

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
        }       

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
