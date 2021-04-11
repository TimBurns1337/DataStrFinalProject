namespace DataStrFinalProject
{
    internal class Bow : Hero
    {
        private Hero myHero;

        public Bow(Hero myHero)
        {
            myHero.Strength = 140;
            myHero.Speed = 120;
            myHero.Health = 150;
            myHero.HeroType = "Bow Man";
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
        public string HeroType { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
    }
}