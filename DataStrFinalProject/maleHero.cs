namespace DataStrFinalProject
{
    internal class maleHero : Hero
    {
        public string HeroType { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }

        public void getHeroStats()
        {
            
        }
        string Hero.getHeroType()
        {
            return HeroType;
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
    }
}