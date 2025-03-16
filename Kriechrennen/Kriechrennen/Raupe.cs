using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    internal class Raupe : Kriechtier
    {
        //Constructor using constructor of base class
        public Raupe (Random random) : base (random)
        {
            symbol = "ooo<";
        }

        //Implementation of Method Krieche()
        public override void Krieche()
        {
            int val = rand.Next(0, 2);
            if (val == 1)
            {
                trav_dist += 4;
            }
        }
    }
}
