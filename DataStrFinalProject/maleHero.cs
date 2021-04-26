namespace DataStrFinalProject
{
    internal class maleHero : Hero
    {
        
        public maleHero(string name)
        {
            HeroName = name;
            HeroType = "";
            Strength = 0;
            Speed = 0;
            Health = 0;
            WeaponType = "";

        }
        public string WeaponType { get; set; }
        public string HeroType { get; set; } // null
        public int Strength { get; set; } // null
        public int Speed { get; set; } // null
        public int Health { get; set; } // null
        public string HeroName { get; set; }

        public void getHeroStats() // not implement anything
        {
            throw new System.NotImplementedException();
        }
        //string Hero.getHeroType()
        //{
        //    return HeroName + " " + HeroType;
        //}
        //int Hero.getHeroStr()
        //{
        //    return Strength;
        //}
        //int Hero.getHeroSpd()
        //{
        //    return Speed;
        //}
        //int Hero.getHeroHth()
        //{
        //    return Health;
        //}

        //string Hero.getHeroName()
        //{
        //    return HeroName;
        //}

        //public void setHealth(int hp)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}