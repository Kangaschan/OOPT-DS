using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Treant : LivingCreature
    {
        private int height;
        public Treant(int hp, int level, int height) : base(hp, level)
        {
            this.height = height;
        }
        private void grow()
        {
            this.HPinLVL += 2;
            this.level++;
            this.height += 2;
        }
        public override Bitmap DrawitSelf()
        {
            return (Bitmap)Bitmap.FromFile("C://MYSTUFF//OOTP//lab 1//imgs//treant.jpg");
        }
        public override string ShowInfo()
        {
            return (base.ShowInfo() + " height : " + height.ToString());
        }
    }
}
