using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class DiamondSkinDefense : SpecialDefense
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}
