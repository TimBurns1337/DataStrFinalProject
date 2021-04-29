namespace DataStrFinalProject
{
    internal class spdBuff : Buffs
    {
        private Hero myHero;        

        public spdBuff(Hero myHero)
        {
            this.myHero = myHero;
            Strength = myHero.Strength;
            Speed = myHero.Speed+25;
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

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + myHero.Strength.ToString() +
                " Speed:" + Speed.ToString() + " Health:" + myHero.Health.ToString());
        }
    }
}