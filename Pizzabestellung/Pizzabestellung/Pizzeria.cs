using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzabestellung
{
    public class Pizzeria
    {
        string _name;
        Pizza[] _speisekarte;
        public Pizzeria(string name, int anzahl)
        {
            _name = name;
            _speisekarte = new Pizza[anzahl];
        }

        public Pizza[] Speisekarte
        {
            get { return _speisekarte;}
            set { _speisekarte = value;}
        }

        public string Pizzerianame
        { get { return _name; } }
    }
}
