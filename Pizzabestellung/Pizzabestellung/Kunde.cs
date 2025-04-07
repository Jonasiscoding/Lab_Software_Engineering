using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzabestellung
{
    public class Kunde
    {
        int _kundennr;
        public Kunde (int kundennr)
        {
            _kundennr = kundennr;
        }

        public int Kundennr
        { get { return _kundennr; } }
    }
}
