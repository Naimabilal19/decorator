using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class MainHero
    {
       public int Power;
        public int Speed;
        public int HP;
        public int Def;

        public MainHero() { }
        public abstract int GetPower();
        public abstract int GetSpeed();
        public abstract int GetHP();
        public abstract int GetDef();
    }
    class Human : MainHero
    {
        public Human()
        {
            Power = 10; Speed = 20;  HP = 10; Def = 20;
        }
        public override int GetPower()
        {
            return Power;
        }
        public override int GetSpeed()
        {
            return Speed;
        }
        public override int GetHP()
        {
            return HP;
        }
        public override int GetDef()
        {
            return Def;
        }
    }
    class Elf : MainHero
    {
        public Elf()
        {
            Power = 20;
            Speed = 10;
            HP = 20;
            Def = 10;
        }
        public override int GetPower()
        {
            return Power;
        }
        public override int GetSpeed()
        {
            return Speed;
        }
        public override int GetHP()
        {
            return HP;
        }
        public override int GetDef()
        {
            return Def;
        }
    }


    abstract class SetMainHero : MainHero
    {
        protected MainHero Hero;

        public SetMainHero(MainHero Hero)
        {
            this.Hero = Hero;
        }
        public override int GetPower()
        {
            return Hero.GetPower();
        }
        public override int GetSpeed()
        {
            return Hero.GetSpeed();
        }
        public override int GetHP()
        {
            return Hero.GetHP();
        }
        public override int GetDef()
        {
            return Hero.GetDef();
        }
    }
    class HumanWarrion : SetMainHero
    {
        public HumanWarrion(MainHero Hero) : base(Hero) { }
        public override int GetPower()
        {
            return base.GetPower() + 0;
        }
        public override int GetSpeed()
        {
            return base.GetSpeed() + 5;
        }
        public override int GetHP()
        {
            return base.GetHP() + 10;
        }
        public override int GetDef()
        {
            return base.GetDef() + 15;
        }
    }
    class HumanWizard : SetMainHero
    {
        public HumanWizard(MainHero Hero) : base(Hero) { }
        public override int GetPower()
        {
            return base.GetPower() + 15;
        }
        public override int GetSpeed()
        {
            return base.GetSpeed() + 10;
        }
        public override int GetHP()
        {
            return base.GetHP() + 5;
        }
        public override int GetDef()
        {
            return base.GetDef() + 0;
        }
    }
    class ElfWarrion : SetMainHero
    {
        public ElfWarrion(MainHero Hero) : base(Hero) { }
        public override int GetPower()
        {
            return base.GetPower() + 5;
        }
        public override int GetSpeed()
        {
            return base.GetSpeed() + 10;
        }
        public override int GetHP()
        {
            return base.GetHP() + 5;
        }
        public override int GetDef()
        {
            return base.GetDef() + 10;
        }
    }
    class ElfWizard : SetMainHero
    {
        public ElfWizard(MainHero Hero) : base(Hero) { }
        public override int GetPower()
        {
            return base.GetPower() + 15;
        }
        public override int GetSpeed()
        {
            return base.GetSpeed() + 10;
        }
        public override int GetHP()
        {
            return base.GetHP() + 5;
        }
        public override int GetDef()
        {
            return base.GetDef() + 0;
        }
    }


    public class Player
    {
        public void PlayerCode(MainHero Hero)
        {
            Console.WriteLine("Power: " + Hero.GetPower());
            Console.WriteLine("Speed: " + Hero.GetSpeed());
            Console.WriteLine("HP: " + Hero.GetHP());
            Console.WriteLine("Def: " + Hero.GetDef());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();

            Human h = new Human();
            h.GetPower(); h.GetSpeed(); h.GetHP(); h.GetType();
        }
    }
}
