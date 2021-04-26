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
        public string WeaponType { get; set; } //null

        public string HeroType { get; set; } // null
    public int Strength { get; set; } // null
    public int Speed { get; set; } // null
    public int Health { get; set; } // null
    public string HeroName { get; set; }

    public void getHeroStats() // not implement anything
    {
        throw new System.NotImplementedException();
    }
    // string Hero.getHeroType()
    // {
    //     return HeroType;
    // }
    // int Hero.getHeroStr()
    // {
    //     return Strength;
    // }
    // int Hero.getHeroSpd()
    // {
    //     return Speed;
    // }
    // int Hero.getHeroHth()
    // {
    //     return Health;
    // }

    // string Hero.getHeroName()
    // {
    //     return HeroName;
    // }

    //void Hero.setHealth(int hp)
    // {

    // }
}
}