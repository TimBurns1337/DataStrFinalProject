namespace DataStrFinalProject
{
    internal class strBuff : Buffs
    {
        private Hero myHero;
        private int str = 25;

        public strBuff(Hero myHero)
        {
            this.myHero = myHero;
            Strength = myHero.Strength + str; // increase str
            Speed = myHero.Speed;
            HeroType = myHero.HeroType;
            HeroName = myHero.HeroName;
            Health = myHero.Health;
            WeaponType = myHero.WeaponType;            
        }
        public override string WeaponType { get; set; }
        public override string HeroType { get; set; }
        public override int Strength { get; set; }
        public override int Speed { get; set; }
        public override int Health { get; set; }
        public override string HeroName { get; set; }
        public override void getHeroStats()
        {           

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + Strength.ToString() +
                " Speed:" + myHero.Speed.ToString() + " Health:" + myHero.Health.ToString() + "Weapon: " + WeaponType);
        }
    }
}