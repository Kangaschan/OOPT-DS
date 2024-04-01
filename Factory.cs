using System;
namespace WinFormsApp1
{
    public abstract class Factory
    {
        public abstract LivingCreature Create(int hp, int level);    
    }
}
