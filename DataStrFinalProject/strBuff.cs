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
            return HeroType;
        }
        public override string HeroType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public override int Strength { get => getHeroStr(); set => getHeroStr(); }
        public override int Speed { get => getHeroSpd(); set => getHeroSpd(); }
        public override int Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}