using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzabestellung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pizza pizza1 = new Pizza("Margherita", 7.9);
            Pizza pizza2 = new Pizza("Salami", 8.9);
            Pizza pizza3 = new Pizza("Funghi", 8.9);

            Pizzeria pizzeria = new Pizzeria("DaFranco", 3);

            pizzeria.Speisekarte[0] = pizza1;
            pizzeria.Speisekarte[1] = pizza2;
            pizzeria.Speisekarte[2] = pizza3;

            Kunde kunde = new Kunde(4711);

            Bestellung bestellung = new Bestellung(pizzeria, kunde, new List<int>() {0,0,1,1,1,2,2,2,2});

            textBox1.Text = bestellung.DruckeBestellung();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
