using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrFinalProject
{
    class Battle : Hero
    {
        Hero myhero;
        string Hero.HeroName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Hero.HeroType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Hero.Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Hero.Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Hero.Health { get => throw new NotImplementedException(); set => setHeroHth(); }

        int Hero.getHeroHth()
        {
            throw new NotImplementedException();
        }

        string Hero.getHeroName()
        {
            throw new NotImplementedException();
        }

        int Hero.getHeroSpd()
        {
            throw new NotImplementedException();
        }

        void Hero.getHeroStats(int strength, int speed, int health)
        {
            throw new NotImplementedException();
        }

        int Hero.getHeroStr()
        {
            throw new NotImplementedException();
        }

        string Hero.getHeroType()
        {
            throw new NotImplementedException();
        }

        int setHeroHth()
        {
            return 0;
        }

    }
}
