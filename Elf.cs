using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum TElfElementals
    {
        sylph,
        Leshi,
        undina
    }
    internal class Elf : Human
    {
        public override void fSetintellegent(int value)
        {
            if (value > this.level*1.25)
                _intellegent = (int)(level * 1.25);
            else if (value < 0)
                _intellegent = 0;
            else _intellegent = value;
        }
        public override void fSetAgility(int value)
        {

            if (value > this.level*1.25)
                _agility = (int) (level * 1.25);
            else if (value < 0)
                _agility = 0;
            else _agility = value;
        }
        protected TElfElementals elemental;
        public Elf(int hp, int level, string name, int gold, TWeapons weapon, int agility, int intellegent, int strength, TElfElementals element) : base(hp, level, name, gold, weapon, agility, intellegent, strength)
        {
            this.HPinLVL = 15;
            this.elemental = element;
            this.agility = agility;
            this.intellegent = intellegent;
        }
        public override Bitmap DrawitSelf()
        {
            return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//elf.jpg");
        }
        public override string ShowInfo()
        {
            return (base.ShowInfo() + " elemental: " + elemental.ToString());
        }
        public TElfElementals GetElem()
        {
            return elemental;
        }
        public override string Speak()
        {
            return " Hello is ainm dhomh " + name;
        }
    }
}
