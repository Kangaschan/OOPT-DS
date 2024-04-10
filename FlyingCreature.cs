using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable]
    [DataContract]
    public class FlyingCreature : LivingCreature
    {
        [DataMember]
        public int range;
 
        
        public FlyingCreature(int hp, int level, int range) : base(hp, level)
        {
            this.range = range;
        }
        public FlyingCreature():base() 
        {
            this.range=1;
        }
        public Point fly()
        {
            Random rnd = new Random();
            return new Point(rnd.Next(range), rnd.Next(range));
        }
        public override Bitmap DrawitSelf()
        {
            return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//wings.jpg");
        }
        public override string ShowInfo()
        {
            return (base.ShowInfo() + " range : " + range.ToString());
        }
    }
}
