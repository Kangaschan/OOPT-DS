using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class FlyingCreatureFactory:Factory
    {
        public override LivingCreature Create(int hp, int level)
        {
            return new FlyingCreature(hp, level, 0);
        }
    }
}
