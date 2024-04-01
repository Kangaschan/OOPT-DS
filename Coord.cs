using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Coord
    {
        public LivingCreature self;
        public int X, Y;
        public const int width = 200;
        public const int height = 400;
        public Coord (LivingCreature inp, int inpX, int inpY)
        {
            self = inp;
            X=inpX;
            Y=inpY;
        }
    }
}
