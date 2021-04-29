namespace DataStrFinalProject
{
    internal abstract class Buffs : Hero
    {
        public abstract string HeroType { get; set; }
        public abstract int Strength { get; set; }
        public abstract int Speed { get; set; }
        public abstract int Health { get; set; }
        public abstract string HeroName { get; set; }
        public abstract string WeaponType { get; set; }        
        public abstract void getHeroStats();     
    }
}