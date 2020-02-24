using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class IronBonesDefense : SpecialDefense
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }


    }
}
