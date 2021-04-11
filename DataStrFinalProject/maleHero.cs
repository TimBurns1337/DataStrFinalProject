namespace DataStrFinalProject
{
    internal class maleHero : Hero
    {
        
        public maleHero(string name)
        {
            Name = name;
        }

        public string HeroType { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public static string Name;

        public void getHeroStats()
        {
            
        }
        string Hero.getHeroType()
        {
            return Name + " " + HeroType;
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