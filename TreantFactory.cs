using System;

namespace WinFormsApp1
{
    internal class TreantFactory:Factory
    {
        public override LivingCreature Create(int hp, int level)
        {
            return new Treant(hp, level,1);
        }
    }
}
