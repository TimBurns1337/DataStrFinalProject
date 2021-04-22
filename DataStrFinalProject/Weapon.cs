namespace DataStrFinalProject
{
    internal abstract class Weapon : Hero
    {
        public abstract string HeroType { get; set; }
        public abstract int Strength { get; set; }
        public abstract int Speed { get; set; }
        public abstract int Health { get; set; }
        public abstract string HeroName { get; set; }

        public abstract int getHeroHth();
        public abstract string getHeroName();
        public abstract int getHeroSpd();
        public abstract void getHeroStats(int strength, int speed, int health);
        public abstract int getHeroStr();
        public abstract string getHeroType();       
        public abstract double setHealth(double damage);
    }
}