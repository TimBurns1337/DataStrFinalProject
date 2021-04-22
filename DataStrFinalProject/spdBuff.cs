namespace DataStrFinalProject
{
    internal class spdBuff : Buffs
    {
        private Hero myHero;
        public static int Spd = 0;

        public spdBuff(Hero myHero)
        {
            this.myHero = myHero;
            Spd = 25;
        }     
        public override void getHeroStats(int strength, int speed, int health)
        {
            myHero.Strength = strength;
            myHero.Speed = speed;
            myHero.Health = health;
            //testfunc();

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + myHero.Strength.ToString() +
                " Speed:" + myHero.Speed.ToString() + " Health:" + myHero.Health.ToString());
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
            return myHero.getHeroType();
        }

        public override string getHeroName()
        {
            return myHero.getHeroName();
        }

        public override double setHealth(double damage)
        {
            return myHero.Health;
        }

        public override string HeroType { get => getHeroType(); set => getHeroType(); }
        public override int Strength { get => getHeroStr(); set => getHeroStr(); }
        public override int Speed { get => getHeroSpd(); set => getHeroSpd(); }
        public override int Health { get => getHeroHth(); set => getHeroHth(); }
        public override string HeroName { get => getHeroName(); set => getHeroName(); }
    }
}