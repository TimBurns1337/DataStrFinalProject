using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrFinalProject
{
    class Reward : Buffs
    {
        public static int weaponLevel=0;
        private static int i = 1;
        Item pack = new Item();
        public Reward(Hero myHero, int reward)
        {
            Random rd = new Random();
            HeroType = myHero.HeroType;
            HeroName = myHero.HeroName;
            Strength = myHero.Strength;
            Speed = myHero.Speed;
            Health = myHero.Health;
            WeaponType = myHero.WeaponType;

            /*int rewardType = rd.Next(1, 5);*/ //all kind of reward, not random
            //while (true)
            //{


                switch (reward)
                {
                    case 1:
                        Console.WriteLine("You loot a fine boots - increases your speed by 25");                                             
                            Speed += 25;
                            //Health -= 10;                                               
                        break;
                    case 2:
                        Strength += 25;
                        Console.WriteLine("You find a precious ore from the loot. Your sword is sharpened(+25 Strength)");
                        weaponLevel++;
                        break;
                    case 3:
                        Console.WriteLine("You find some pills from the enemy body, and take them.");                        
                        int pill = rd.Next(1, 3);
                        if (pill % 2 == 0)
                        {
                            Console.WriteLine("Its chocolote, and your pain is alleviated(HP +50)");
                            Health += 50;
                        }
                        else if (pill % 2 == 1)
                        {
                            Console.WriteLine("It's fish bait, ew~");
                        }
                        break;
                    case 4:
                        Console.WriteLine("It's an honorable fight! you bury the opponent's body and restart you jounery. ");
                        break;
                    case 5:
                        Console.WriteLine("The enemy droped an unidentified item");
                        pack.getPack().Add("unidentified equipment *" + i.ToString());//pack is a hashset, not accepting duplicate values
                        i++;
                        break;
                    default:
                        break;
                }
            //}

        }

        public override void getHeroStats()
        {
            System.Console.WriteLine("Hero Name: " + HeroName +
                " Hero Type: " + HeroType + " Strength:" + Strength.ToString() +
                " Speed:" + Speed.ToString() + " Health:" + Health.ToString() + " Weapon: " + WeaponType +"+"+weaponLevel);
        }
        public override string WeaponType { get; set; }
        public override string HeroType { get; set; }
        public override int Strength { get; set; }
        public override int Speed { get; set; }
        public override int Health { get; set; }
        public override string HeroName { get; set; }

    }
}
