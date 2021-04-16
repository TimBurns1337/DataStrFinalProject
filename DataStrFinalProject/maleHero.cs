namespace DataStrFinalProject
{
    internal class maleHero : Hero
    {
        
        public maleHero(string name)
        {
            HeroName = name;
        }

        public string HeroType { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public string HeroName { get; set; }

        public void getHeroStats()
        {
            
        }
        string Hero.getHeroType()
        {
            return HeroName + " " + HeroType;
        }
        int Hero.getHeroStr()
        {
            return Strength;
        }
        int Hero.getHeroSpd()
        {
            return Speed;
        }
        int Hero.getHeroHth()
        {
            return Health;
        }

        string Hero.getHeroName()
        {
            return HeroName;
        }
    }
}