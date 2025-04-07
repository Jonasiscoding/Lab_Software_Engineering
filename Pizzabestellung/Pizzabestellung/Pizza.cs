using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzabestellung
{
    public class Pizza
    {
        string _name;
        double _preis;
        public Pizza(string name, double preis)
        {
            _name = name;
            _preis = preis;
        }

        public double Preis
        {
            get { return _preis; }
        }

        public string Name
        { get { return _name; } }
    }
}
