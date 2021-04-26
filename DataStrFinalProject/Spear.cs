﻿namespace DataStrFinalProject
{
    internal class Spear : Weapon
    {
        private Hero myHero;
        private int strength = 140, speed = 120, health = 150;
        private string type = "Spear Man";

        public Spear(Hero myHero)
        {
            this.myHero = myHero;
            Strength = strength;
            Speed = speed;
            Health = health;
            HeroType = type;
            HeroName = myHero.HeroName;
            WeaponType = "Spear";
        }

        public override string WeaponType { get; set; }

        public override string HeroType { get; set; } //valid
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

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + Strength.ToString() +
                " Speed:" + Speed.ToString() + " Health:" + Health.ToString());

        }
    }
}