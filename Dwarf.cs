using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum TDwarfElementals
    {
        slamandra,
        terra
    }
    public class Dwarf : Human
    {
        public override void fSetstrength(int value)
        {
            if (value > this.level * 1.5)
                _strength = (int)(level * 1.5);
            else if (value < 0)
                _strength = 0;
            else _strength = value;
        }
        private TDwarfElementals elemental;
        public Dwarf(int hp, int level, string name,int gold, TWeapons weapon, int agility, int intellegent, int strength, TDwarfElementals elemental) : base(hp, level, name, gold, weapon, agility, intellegent, strength)
        {
            this.HPinLVL = 25;
            this.elemental = elemental;
            this.strength = strength;
        }
        public override Bitmap DrawitSelf()
        {
            return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//dwarf.jpg");
        }
        public override string ShowInfo()
        {
            return (base.ShowInfo() + " elemental: " + elemental.ToString());
        }
        public TDwarfElementals GetElem()
        {
            return elemental;
        }
        public override string Speak()
        {
            return " Atrast 'vala " + name;
        }
    }
}
