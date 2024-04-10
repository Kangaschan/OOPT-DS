using OOTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum TDwarfElementals
    {
        slamandra,
        terra
    }
    [Serializable]
    [DataContract]
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
        [DataMember]
        public TDwarfElementals elemental;
        public Dwarf(int hp, int level, string name,int gold, TWeapons weapon, int agility, int intellegent, int strength, TDwarfElementals elemental) : base(hp, level, name, gold, weapon, agility, intellegent, strength)
        {
            this.HPinLVL = 25;
            this.elemental = elemental;
            this.strength = strength;
        }
        public Dwarf():base()
        {
            this.HPinLVL = 25;
            this.elemental = TDwarfElementals.slamandra;
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
        public override List<TFormBuildInfo> GetParams()
        {
            List<TFormBuildInfo> Params = new List<TFormBuildInfo>();
            TFormBuildInfo tmp;
            tmp.value = hp;
            tmp.type = typeof(int);
            tmp.info = "Здоровье";
            Params.Add(tmp);

            tmp.value = level;
            tmp.type = typeof(int);
            tmp.info = "Уровень";
            Params.Add(tmp);

            tmp.value = name;
            tmp.type = typeof(string);
            tmp.info = "Имя";
            Params.Add(tmp);

            tmp.value = gold;
            tmp.type = typeof(int);
            tmp.info = "Золото";
            Params.Add(tmp);

            tmp.value = strength;
            tmp.type = typeof(int);
            tmp.info = "Сила";
            Params.Add(tmp);

            tmp.value = agility;
            tmp.type = typeof(int);
            tmp.info = "Ловкость";
            Params.Add(tmp);

            tmp.value = intellegent;
            tmp.type = typeof(int);
            tmp.info = "Интеллект";
            Params.Add(tmp);

            tmp.value = weapon;
            tmp.type = typeof(TWeapons);
            tmp.info = "Оружие";
            Params.Add(tmp);

            tmp.value = elemental;
            tmp.type = typeof(TDwarfElementals);
            tmp.info = "Элементаль";
            Params.Add(tmp);

            return Params;
        }
        public override void SetParams(List<TFormBuildInfo> Params)
        {
            hp = (int)Params[0].value;
            level = (int)Params[1].value;
            name = (string)Params[2].value;
            gold = (int)Params[3].value;
            strength = (int)Params[4].value;
            agility = (int)Params[5].value;
            intellegent = (int)Params[6].value;
            weapon = (TWeapons)Params[7].value;
            elemental = (TDwarfElementals)Params[8].value;
        }
    }
}
