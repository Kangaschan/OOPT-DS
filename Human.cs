using OOTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

    [Serializable]
    [DataContract]
    public class Human : LivingCreature
    {
        const int MAXGOLD = 99999;
        [DataMember]
        public string name;
        [DataMember]
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
        [DataMember]
        public TWeapons weapon;
        [DataMember]
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
       
        [DataMember] 
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
      
        [DataMember] 
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
        public Human() : base() 
        {
            this.name = "Default Name";
            this.gold = 1;
            this.weapon = TWeapons.sword;
            this.agility = 1;
            this.intellegent = 1;
            this.strength = 1;
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
        }
    }
}
