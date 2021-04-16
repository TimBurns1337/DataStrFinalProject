namespace DataStrFinalProject
{
    internal class Bow : Weapon
    {
        private Hero myHero;

        public Bow(Hero myHero)
        {
            this.myHero = myHero;
            myHero.Strength = 140;
            myHero.Speed = 120;
            myHero.Health = 150;
            myHero.HeroType = "Bow Man";
        }

        public override int getHeroHth()
        {
            throw new System.NotImplementedException();
        }

        public override int getHeroSpd()
        {
            return myHero.Speed + spdBuff.Spd;
        }

        public override void getHeroStats()
        {
            System.Console.WriteLine("print 1 test" + myHero.HeroType + " Strength:" + myHero.Strength.ToString() +
                " Speed:" + myHero.Speed.ToString() + " Health:" + myHero.Health.ToString());
        }

        public override int getHeroStr()
        {
            return myHero.Strength + strBuff.Stren;
        }

        public override string getHeroType()
        {
            return myHero.HeroName + " a " + myHero.HeroType; // need to fix for women 
        }
        public override string getHeroName()
        {
            return myHero.HeroName;
        }

        public override string HeroType { get => getHeroType(); set => getHeroType(); }
        public override int Strength { get => getHeroStr(); set => getHeroStr(); }
        public override int Speed { get => getHeroSpd(); set => getHeroSpd(); }
        public override int Health { get => getHeroHth(); set => getHeroHth(); }
        public override string HeroName { get => getHeroName(); set => getHeroName(); }
    }
}