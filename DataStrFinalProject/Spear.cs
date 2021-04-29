namespace DataStrFinalProject
{
    internal class Spear : Weapon
    {
        private Hero myHero;
        private int strength = 150, speed = 140, health = 120;
        private string type = "Spear Man";

        public Spear(Hero myHero)
        {
            this.myHero = myHero;
            Strength = strength;
            Speed = speed;
            Health = health;
            HeroType = type;
            HeroName = myHero.HeroName;
            WeaponType = "Spear";
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