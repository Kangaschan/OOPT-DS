using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum TElement
    {
        fire,
        earth,
        water,
        lightning,
        air
    }
    [Serializable]
    [DataContract]
    public class Dragon : FlyingCreature
    {
        [DataMember]
        private TElement element;
        public override void fSetLVL(int value)
        {
            if (value > MAXLVL) _level = MAXLVL;
            else
                if (value < 1)
                _level = 1;
            else { 
                _level = value;
            MAXHP = level * HPinLVL;
                if(_level < 15 && _level > 0)
                {
                    this.element = TElement.fire;
                }
                if(_level > 15 && _level < 30)
                {
                    this.element = TElement.lightning;
                }
                if (_level > 30 && _level < 45)
                {
                    this.element = TElement.earth;
                }

                if (_level > 45 && _level < 60)
                {
                    this.element = TElement.air;
                }
                if (_level > 60)
                {
                    this.element = TElement.water;
                }
            }
        }
        public Dragon(int hp, int level, int range) : base(hp, level, range)
        {
            this.HPinLVL = 100;
            this.level = level;
            this.hp = hp;
        }
        public Dragon()  : base()
        {

        }
        public override Bitmap DrawitSelf()
        {
            switch (this.element)
            {
                case TElement.fire:
                    return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//dragons//fire.jpg");
                    break;
                case TElement.earth:
                    return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//dragons//earth.jpg");
                    break;
                case TElement.lightning:
                    return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//dragons//lightning.jpg");
                    break;
                case TElement.air:
                    return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//dragons//air.jpg"); 
                    break;
                case TElement.water:
                    return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//dragons//water.jpg");
                    break;
            }
            return null;
        }
        public override string ShowInfo()
        {
            return (base.ShowInfo() + " element : " + element.ToString());
        }
    }
}
