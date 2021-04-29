namespace DataStrFinalProject
{
    internal class Axe : Weapon
    {

        private Hero myHero;
        private int strength = 150, speed = 110, health = 150;
        private string type = "Axe Man";

        public Axe(Hero myHero)
        {
            this.myHero = myHero;
            Strength = strength;
            Speed = speed;
            Health = health;
            HeroType = type;
            HeroName = myHero.HeroName;
            WeaponType = "Axe";

        }
        public override string WeaponType { get; set; }
        public override string HeroType { get; set; } //valid
        public override int Strength { get; set; } //valid
        public override int Speed { get; set; } //valid
        public override int Health { get; set; } //valid
        public override string HeroName { get; set; } //valid       

        public override void getHeroStats()
        {

            System.Console.WriteLine("Hero Name: " + myHero.HeroName + " Hero Type: " + myHero.HeroType + " Strength:" + Strength.ToString() +
                " Speed:" + Speed.ToString() + " Health:" + Health.ToString());

        }
    }
}