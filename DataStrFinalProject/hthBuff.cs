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

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + myHero.Strength.ToString() +
                " Speed:" + myHero.Speed.ToString() + " Health:" + Health.ToString());
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
        //    return myHero.getHeroType();
        //}

        //public override string getHeroName()
        //{
        //    return myHero.getHeroName();
        //}       

        //public void setHealth(int hp)
        //{
        //    myHero.Health = hp;
        //}

        //public override int Health { get; set; }
        //public override int Strength { get; set; }
        //public override int Speed { get; set; }


    }
}