namespace DataStrFinalProject
{
    internal interface Hero
    {
        public string WeaponType { get; set; }
        public string HeroName { get; set; }
        public string HeroType { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }        
        void getHeroStats();        
    }
}