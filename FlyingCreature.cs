using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class FlyingcCreature : LivingCreature
    {
        protected int range;
        public FlyingcCreature(int hp, int level, int range) : base(hp, level)
        {
            this.range = range;
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
