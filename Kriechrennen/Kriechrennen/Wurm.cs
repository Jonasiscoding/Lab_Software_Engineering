using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    internal class Wurm : Kriechtier
    {
        //Constructor using constructor of base class
        public Wurm (Random random) : base(random)
        {
            symbol = "~";
        }

        //Implementation of Method Krieche()
        public override void Krieche()
        {
            trav_dist += rand.Next(0, 7);
        }
    }
}
