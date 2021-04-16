namespace DataStrFinalProject
{
    internal class strBuff : Buffs
    {
        private Hero myHero;
        public static int Stren = 0;

        public strBuff(Hero myHero)
        {
            this.myHero = myHero;
            Stren = 25;
        }
        public override void getHeroStats()
        {
            System.Console.WriteLine("Hero type: " + myHero.getHeroType() + " Strength:" + myHero.Health.ToString() +
               " Speed:" + myHero.getHeroSpd() + " Health:" + myHero.Health.ToString());
        }

        public override int getHeroStr()
        {
            return myHero.getHeroStr();
        }
        public override int getHeroSpd()
        {
            return myHero.getHeroSpd();
        }
        public override int getHeroHth()
        {
            return myHero.getHeroHth();
        }

        public override string getHeroType()
        {
            return myHero.HeroType;
        }
        public override string getHeroName()
        {
            return myHero.getHeroType();
        }
        public override string HeroType { get => getHeroType(); set => getHeroType(); }
        public override int Strength { get => getHeroStr(); set => getHeroStr(); }
        public override int Speed { get => getHeroSpd(); set => getHeroSpd(); }
        public override int Health { get => getHeroHth(); set => getHeroHth(); }
        public override string HeroName { get => getHeroName(); set => getHeroName(); }
    }
}