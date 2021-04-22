using System;

namespace DataStrFinalProject
{
    internal class Sword : Weapon
    {
        private Hero myHero;

        public Sword(Hero myHero)
        {
            this.myHero = myHero;
            myHero.Strength = 140;
            myHero.Speed = 120;
            myHero.Health = 150;
            myHero.HeroType = "Sword Man";
            myHero.HeroName = myHero.getHeroName(); // testing 
        }              

        public override int getHeroHth()
        {
            return myHero.Health + hthBuff.Hth;
        }

        public override int getHeroSpd()
        {
            return myHero.Speed + spdBuff.Spd;
        }

        public override void getHeroStats(int strength, int speed, int health)
        {
            myHero.Strength = strength;
            myHero.Speed = speed;
            myHero.Health = health;           
            
            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + myHero.Strength.ToString() +
                " Speed:" + myHero.Speed.ToString() + " Health:" + myHero.Health.ToString());
            
        }      

        public override int getHeroStr()
        {            
            return myHero.Strength + strBuff.Stren; 
        }

        public override string getHeroType()
        {
            return  myHero.HeroType; 
        }

        public override string getHeroName()
        {
            return myHero.HeroName;
        }

        public override double setHealth(double damage)
        {
            return myHero.Health - damage;
        }

        public override string HeroType { get => getHeroType(); set => getHeroType(); }
        public override int Strength { get => getHeroStr(); set => getHeroStr(); }
        public override int Speed { get => getHeroSpd(); set => getHeroSpd(); }
        public override int Health { get => getHeroHth(); set => getHeroHth(); }
        public override string HeroName { get => getHeroName(); set => getHeroName(); }
    }
}