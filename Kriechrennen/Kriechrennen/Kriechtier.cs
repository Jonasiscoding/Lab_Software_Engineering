using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    internal abstract class Kriechtier
    {
        //Attributes
        public int trav_dist;
        protected string symbol;
        protected Random rand;

        //Constructor
        public Kriechtier (Random random)
        {
            rand = random;
            trav_dist = 0;
        }

        //Property for getting traveled distance
        public int Strecke
        { get { return trav_dist; }}

        //Property for visualizing traveled distance as string
        public string Visualisierung
        {
            get
            {
                string visualization = "";
                for (int i = 0; i <= trav_dist; i++)
                {
                    visualization += "_";
                }
                return visualization += symbol;
            }
        }

        //Method Krieche
        public abstract void Krieche();
    }
}
