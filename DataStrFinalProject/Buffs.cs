namespace DataStrFinalProject
{
    internal abstract class Buffs : Hero
    {
        public abstract string HeroType { get; set; }
        public abstract int Strength { get; set; }
        public abstract int Speed { get; set; }
        public abstract int Health { get; set; }
        public abstract string HeroName { get; set; }

        //public abstract int getHeroHth();
        //public abstract string getHeroName();
        //public abstract int getHeroSpd();
        public abstract void getHeroStats();        
        //public abstract int getHeroStr();
        //public abstract string getHeroType();        
        //public abstract void setHealth(int hp);
    }
}