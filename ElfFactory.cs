using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ElfFactory:Factory
    {
        public override LivingCreature Create(int hp, int level)
        {
            return new Elf(hp, level, "Default name", 0, TWeapons.axe, 1, 1, 1, TElfElementals.sylph);

        }
    }
}
