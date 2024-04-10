using OOTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    [Serializable]
    [DataContract]
    [KnownType(typeof(FlyingCreature))]
    [KnownType(typeof(Human))]
    [KnownType(typeof(Elf))]
    [KnownType(typeof(Dwarf))]
    [KnownType(typeof(Dragon))]
    [KnownType(typeof(Treant))]
    //[KnownType(typeof())]
    [XmlInclude(typeof(Human)), XmlInclude(typeof(Treant)), XmlInclude(typeof(FlyingCreature)), XmlInclude(typeof(Elf)), XmlInclude(typeof(Dwarf)), XmlInclude(typeof(Dragon))]

    public abstract class LivingCreature
    {

        protected int _hp;
        [DataMember]
        public int hp { get { return _hp; } set { fSetHP(value); } }

        private void fSetHP(int value)
        {
            if(value < 0)
            _hp = 0;
            else
            {
                if(value > MAXHP) _hp = MAXHP;
                else
                _hp = value;
            }
        }

        protected int _level;
        [DataMember]
        public int level { get { return _level; } set { fSetLVL(value); } }
        virtual public void fSetLVL(int value)
        {
            _level = value;
            if (value > MAXLVL) level = MAXLVL; 
            else
                if(value < 1)
                _level = 1;
            else 
                { 
                _level = value;
                }
            MAXHP = _level * HPinLVL;
        }
        
        protected const int MAXLVL = 100;
        protected int MAXHP;
        protected int HPinLVL;
        public LivingCreature()
        {
            HPinLVL = 20;
            this.level = 1;
            MAXHP = level * HPinLVL;
            this.hp = 1;
        }
        public LivingCreature(int hp, int level)
        {
            //MAXLVL = 100;
            HPinLVL = 20;
            this.level = level;
            MAXHP = level * HPinLVL;
            this.hp = hp;
        }
        public virtual Bitmap DrawitSelf()
        {
            return (Bitmap)Bitmap.FromFile("");
        }
        public virtual string ShowInfo()
        {
            string result = " hp : " + hp.ToString() + " level : " + level.ToString();
            return result;
        }
        public bool incLevel(int increase)
        {
            if (increase > 0)
            {
                level += increase;
                hp = MAXHP;
            }
            else
                return false;
            return true;
        }
        virtual public List<TFormBuildInfo> GetParams()
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
            return Params;
        }

        virtual public void SetParams(List<TFormBuildInfo> Params)
        {
            hp = (int)Params[0].value;
            level = (int)Params[1].value;
        }
    }

}
