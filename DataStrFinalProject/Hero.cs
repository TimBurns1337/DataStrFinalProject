namespace DataStrFinalProject
{
    internal interface Hero
    {
        public string HeroType { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        void getHeroStats();
        string getHeroType();
        int getHeroStr();
        int getHeroSpd();
        int getHeroHth();
    }
}