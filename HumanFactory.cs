using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class HumanFactory : Factory
    {
        public override LivingCreature Create(int hp, int level)
        {
            return new Human(hp, level,"DefaultName",0,TWeapons.sword,1,1,1);
        }
    }
}
