using System;

namespace DataStrFinalProject
{
    internal class Sword : Weapon
    {
        private Hero myHero;
        private int strength = 150, speed = 130, health = 130;
        private string type = "Sword Man";

        public Sword(Hero myHero)
        {
            this.myHero = myHero;
            Strength = strength;
            Speed = speed;
            Health = health;
            HeroType = type;
            HeroName = myHero.HeroName;
            WeaponType = "Sword";
        }
        public override string WeaponType { get; set; }
        public override string HeroType{ get; set; } //valid
        public override int Strength { get; set; } //valid
        public override int Speed { get; set; } //valid
        public override int Health { get; set; } //valid
        public override string HeroName { get; set; } //valid        

        public override void getHeroStats()
        {     
            
            System.Console.WriteLine("Hero Name: " + HeroName + " Hero Type: " + HeroType + " Strength:" + Strength.ToString() +
                " Speed:" + Speed.ToString() + " Health:" + Health.ToString());
            
        }  
    }
}