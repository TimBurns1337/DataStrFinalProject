namespace DataStrFinalProject
{
    internal class hthBuff : Hero
    {
        private Hero myHero;

        public hthBuff(Hero myHero)
        {
            this.myHero = myHero;
        }
        public void getHeroStats()
        {
            System.Console.WriteLine(myHero.HeroType + " Strength:" + myHero.Health.ToString() +
                " Speed:" + myHero.Speed.ToString() + " Health:" + myHero.Health.ToString());
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

        string Hero.getHeroName()
        {
            return HeroName;
        }

        public string HeroType { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public string HeroName { get; set; }
    }
}