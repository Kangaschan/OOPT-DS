using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public abstract class LivingCreature
    {
        protected int _hp;
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
        
    }

}
