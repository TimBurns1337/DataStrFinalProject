using System;

namespace DataStrFinalProject
{
    internal class femaleHero : Hero
    {
        public femaleHero(string name)
        {
            HeroName = name;
            HeroType = "";
            Strength = 0;
            Speed = 0;
            Health = 0;
        }
        public string WeaponType { get; set; } 
        public string HeroType { get; set; } 
        public int Strength { get; set; } 
        public int Speed { get; set; } 
        public int Health { get; set; } 
        public string HeroName { get; set; }

        public void getHeroStats() 
        {
            throw new System.NotImplementedException();
        }   
    }
}