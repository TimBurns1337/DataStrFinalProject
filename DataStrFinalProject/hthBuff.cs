namespace DataStrFinalProject
{
    internal class hthBuff : Buffs
    {
        private Hero myHero;
        public static int Hth = 0;

        public hthBuff(Hero myHero)
        {
            this.myHero = myHero;
            Strength = myHero.Strength;
            Speed = myHero.Speed;
            HeroType = myHero.HeroType;
            HeroName = myHero.HeroName;
            Health = myHero.Health+25;
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

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + myHero.Strength.ToString() +
                " Speed:" + myHero.Speed.ToString() + " Health:" + Health.ToString() + "Weapon: " + WeaponType);
        }  
    }
}