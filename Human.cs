using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum TWeapons
    {
        sword,
        bow,
        axe,
        stuff
    }


    public class Human : LivingCreature
    {
        const int MAXGOLD = 99999;
        public string name;
        private int _gold;
        public int gold { get { return _gold; } set { fSetGold(value); } }
        private int fSetGold(int value)
        {
            if (value < 0)
            {
                gold = 0;
                return 0;
            }
            else if (_gold + value > MAXGOLD)
            {
                _gold = MAXGOLD;
                return value + _gold - MAXGOLD;
            }
            else
            {
                _gold += value;
                return 0;
            }
        }
        public TWeapons weapon;
        protected int _agility;
        public int agility{ get { return _agility; } set { fSetAgility(value); } }
        virtual public void fSetAgility(int value)
        {
            if (value > this.level)
                _agility = level;
            else if (value < 0)
                _agility = 0;
            else _agility = value;

        }
        protected int _intellegent;
        public int intellegent { get { return _intellegent; } set { fSetintellegent(value); } }
        virtual public void fSetintellegent(int value)
        {
            if (value > this.level)
                _intellegent = level;
            else if (value < 0)
                _intellegent = 0;
            else _intellegent = value;

        }
        protected int _strength;
        public int strength { get { return _strength; } set { fSetstrength(value); } }
        virtual public void fSetstrength(int value)
        {
            if (value > this.level)
                _strength = level;
            else if (value < 0)
                _strength = 0;
            else _strength = value;

        }
        public Human(int hp, int level, string name, int gold, TWeapons weapon, int agility, int intellegent, int strength) : base(hp, level)
        {
            this.name = name;
            this.gold = gold;
            this.weapon = weapon;
            this.agility = agility;
            this.intellegent = intellegent;
            this.strength = strength;
        }

        public override string ShowInfo()
        {
            return (Speak() + base.ShowInfo() + " gold: " + gold.ToString() + " weapon: " + weapon.ToString() + " agility " + agility.ToString() + " srength: " + strength.ToString() + " intellegent: " + intellegent.ToString());
        }
        public override Bitmap DrawitSelf()
        {
            return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//human.jpg");
        }
        public virtual string Speak()
        {
            return " Hi, i'm " + name;
        }
    }
}
