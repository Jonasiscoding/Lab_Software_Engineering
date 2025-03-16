using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    internal class Schnecke : Kriechtier
    {
        //Constructor using constructor of base class
        public Schnecke (Random random) : base(random)
        {
            symbol = "@";
        }

        //Implementation of Method Krieche()
        public override void Krieche()
        {
            trav_dist += rand.Next(2, 5);
        }
    }
}
