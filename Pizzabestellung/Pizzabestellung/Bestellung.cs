using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzabestellung
{
    public class Bestellung
    {
        Pizzeria _pizzeria;
        Kunde _kunde;
        List<int> _positionen;
        public Bestellung(Pizzeria pizzeria, Kunde kunde, List<int> positionen)
        {
            _pizzeria = pizzeria;
            _kunde = kunde;
            _positionen = positionen;
        }

        double BerechnePreis()
        {
            double summe = 0;
            for (int i = 0; i < _positionen.Count; i++)
            {
                summe += _pizzeria.Speisekarte[_positionen[i]].Preis;
            }
            return summe;
        }

        public string DruckeBestellung()
        {
            string ausgabe = "";
            for (int i = 0; i < _positionen.Count; i++)
            {
                ausgabe += Environment.NewLine;
                ausgabe += _pizzeria.Speisekarte[_positionen[i]].Name;
            }
            return "Der Kunde mit Nr. " + _kunde.Kundennr + "hat für " + BerechnePreis() + "Euro bestellt bei Pizzeria " + _pizzeria.Pizzerianame + "\n" + ausgabe;
        }
    }
}
