namespace DataStrFinalProject
{
    internal class Axe : Weapon
    {

        private Hero myHero;
        private int strength = 140, speed = 120, health = 150;
        private string type = "Axe Man";

        public Axe(Hero myHero)
        {
            this.myHero = myHero;
            Strength = strength;
            Speed = speed;
            Health = health;
            HeroType = type;
            HeroName = myHero.HeroName;
        }

        public override string HeroType { get; set; } //valid
        public override int Strength { get; set; } //valid
        public override int Speed { get; set; } //valid
        public override int Health { get; set; } //valid
        public override string HeroName { get; set; } //valid

        //public override int getHeroHth()
        //{
        //    return myHero.Health + hthBuff.Hth;
        //}

        //public override int getHeroSpd()
        //{
        //    return myHero.Speed + spdBuff.Spd;
        //}

        public override void getHeroStats()
        {

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + Strength.ToString() +
                " Speed:" + Speed.ToString() + " Health:" + Health.ToString());

        }




        //private Hero myHero;

        //public Axe(Hero myHero)
        //{
        //    this.myHero = myHero;
        //    myHero.Strength = 160;
        //    myHero.Speed = 100;
        //    myHero.Health = 150;
        //    myHero.HeroType = "Axe Man";
        //}

        //public override int getHeroHth()
        //{
        //    return myHero.Health + hthBuff.Hth;
        //}

        //public override int getHeroSpd()
        //{
        //    return myHero.Speed + spdBuff.Spd;
        //}

        //public override void getHeroStats(int strength, int speed, int health)
        //{
        //    System.Console.WriteLine("print 1 test" + myHero.HeroType + " Strength:" + myHero.Strength.ToString() +
        //        " Speed:" + myHero.Speed.ToString() + " Health:" + myHero.Health.ToString());
        //}

        //public override int getHeroStr()
        //{
        //    return myHero.Strength + strBuff.Stren;
        //}

        //public override string getHeroType()
        //{
        //    return myHero.HeroName + " a " + myHero.HeroType; // need to fix for women 
        //}

        //public override string getHeroName()
        //{
        //    return myHero.HeroName;
        //}

        //public override double setHealth(double damage)
        //{
        //    return myHero.Health;
        //}

        //public override string HeroType { get => getHeroType(); set => getHeroType(); }
        //public override int Strength { get => getHeroStr(); set => getHeroStr(); }
        //public override int Speed { get => getHeroSpd(); set => getHeroSpd(); }
        //public override int Health { get => getHeroHth(); set => getHeroHth(); }
        //public override string HeroName { get => getHeroName(); set => getHeroName(); }
    }
}