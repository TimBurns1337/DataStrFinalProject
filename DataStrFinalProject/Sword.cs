using System;

namespace DataStrFinalProject
{
    internal class Sword : Weapon
    {
        private Hero myHero;
        private int strength = 140, speed = 120, health = 150;
        private string type = "Sword Man";

        public Sword(Hero myHero)
        {
            this.myHero = myHero;
            Strength = strength;
            Speed = speed;
            Health = health;
            HeroType = type;
            HeroName = myHero.HeroName; 
        }

        public override string HeroType{ get; set; } //valid
        public override int Strength { get; set; } //valid
        public override int Speed { get; set; } //valid
        public override int Health { get; set; } //valid
        public override string HeroName { get; set; } //valid

        //public override int getHeroHth()
        //{
        //    return myHero.Health + hthBuff.Hth;
        //}

        //public override int getHeroSpd()
        //{
        //    return myHero.Speed + spdBuff.Spd;
        //}

        public override void getHeroStats()
        {     
            
            System.Console.WriteLine("Hero Name: " + HeroName + " Hero Type: " + HeroType + " Strength:" + Strength.ToString() +
                " Speed:" + Speed.ToString() + " Health:" + Health.ToString());
            
        }      

        //public override int getHeroStr()
        //{            
        //    return myHero.Strength + strBuff.Stren; 
        //}

        //public override string getHeroType()
        //{
        //    return  myHero.HeroType; 
        //}

        //public override string getHeroName()
        //{
        //    return myHero.HeroName;
        //}

        //public override double setHealth(double damage)
        //{
        //    return myHero.Health - damage;
        //}


    }
}