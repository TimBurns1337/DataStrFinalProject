namespace DataStrFinalProject
{
    internal interface Hero
    {
        public string HeroName { get; set; }
        public string HeroType { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        //string getHeroName();
        void getHeroStats();
        //string getHeroType();
        //int getHeroStr();
        //int getHeroSpd();
        //int getHeroHth();
        //void setHealth(int hp);
        //void setHealth();
    }
}