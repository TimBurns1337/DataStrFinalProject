namespace DataStrFinalProject
{
    internal class Sword : Weapon
    {
        private Hero myHero;

        public Sword(Hero myHero)
        {
            this.myHero = myHero;
            myHero.Strength = 140;
            myHero.Speed = 120;
            myHero.Health = 150;
            myHero.HeroType = "Sword Man";
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
            throw new System.NotImplementedException();
        }
       
        public override string HeroType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public override int Strength { get => getHeroStr(); set => getHeroStr(); }
        public override int Speed { get => getHeroSpd(); set => getHeroSpd(); }
        public override int Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}