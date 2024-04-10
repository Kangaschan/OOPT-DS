using OOTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

    [Serializable]
    [DataContract]
    public class Elf : Human
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
        [DataMember]
        public TElfElementals elemental { get; set; }
        public Elf(int hp, int level, string name, int gold, TWeapons weapon, int agility, int intellegent, int strength, TElfElementals element) : base(hp, level, name, gold, weapon, agility, intellegent, strength)
        {
            this.HPinLVL = 15;
            this.elemental = element;
            this.agility = agility;
            this.intellegent = intellegent;
        }
        public Elf() : base()
        {
            this.HPinLVL = 15;
            this.elemental = TElfElementals.undina;
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
            tmp.type = typeof(TElfElementals);
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
            elemental = (TElfElementals)Params[8].value;
        }
    }
}
