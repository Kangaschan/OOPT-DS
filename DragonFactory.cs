using System;

namespace WinFormsApp1
{
    public class DragonFactory : Factory
    {
        public override LivingCreature Create(int hp, int level)
        {
            return new Dragon(hp, level,2);
        }
    }
}
