namespace DataStrFinalProject
{
    internal class strBuff : Buffs
    {
        private Hero myHero;
        private int str = 25;

        public strBuff(Hero myHero)
        {
            this.myHero = myHero;
            Strength = myHero.Strength+str;
            Speed = myHero.Speed;
            HeroType = myHero.HeroType;
            HeroName = myHero.HeroName;
            Health = myHero.Health;
            //Stren = 25;
        }

        public override string HeroType { get; set; }
        public override int Strength { get; set; }
        public override int Speed { get; set; }
        public override int Health { get; set; }
        public override string HeroName { get; set; }
        public override void getHeroStats()
        {
            //myHero.Strength = strength;
            //myHero.Speed = speed;
            //myHero.Health = health;
            //testfunc();

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + Strength.ToString() +
                " Speed:" + myHero.Speed.ToString() + " Health:" + myHero.Health.ToString());
        }

        //public override int getHeroStr()
        //{
        //    return myHero.getHeroStr();
        //}
        //public override int getHeroSpd()
        //{
        //    return myHero.getHeroSpd();
        //}
        //public override int getHeroHth()
        //{
        //    return myHero.getHeroHth();
        //}

        //public override string getHeroType()
        //{
        //    return myHero.HeroType;
        //}
        //public override string getHeroName()
        //{
        //    return myHero.getHeroName();
        //}

        //public override double setHealth(double damage)
        //{
        //    return myHero.Health;
        //}


    }
}