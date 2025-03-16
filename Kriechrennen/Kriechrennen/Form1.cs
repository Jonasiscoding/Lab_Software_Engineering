using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriechrennen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button "let's go" gets pressed
        private void button1_Click(object sender, EventArgs e)
        {
            //create new Random object
            Random random = new Random();

            //create Array of Kriechtier with Objects Schnecke, Raupe, Wurm as elements
            Kriechtier[] kriechtierArray = new Kriechtier[5];
            kriechtierArray[0] = new Schnecke(random);
            kriechtierArray[1] = new Raupe(random);
            kriechtierArray[2] = new Schnecke(random);
            kriechtierArray[3] = new Wurm(random);
            kriechtierArray[4] = new Wurm(random);

            //While traveled distance is <50 
            while ((kriechtierArray[0].Strecke <= 50)&& (kriechtierArray[1].Strecke <= 50) && (kriechtierArray[2].Strecke <= 50) && (kriechtierArray[3].Strecke <= 50) && (kriechtierArray[4].Strecke <= 50))
            {
                //Method Krieche() increments traveled distance as implemented in the respective class      NOTE: even the name Krieche() is the same, each Method has different implementation
                kriechtierArray[0].Krieche();
                kriechtierArray[1].Krieche();
                kriechtierArray[2].Krieche();
                kriechtierArray[3].Krieche();
                kriechtierArray[4].Krieche();

                //write values to TextBox
                racetrack.Text = kriechtierArray[0].Visualisierung + Environment.NewLine + kriechtierArray[1].Visualisierung + Environment.NewLine + kriechtierArray[2].Visualisierung + Environment.NewLine + kriechtierArray[3].Visualisierung + Environment.NewLine + kriechtierArray[4].Visualisierung;

                //update TextBox and delay thread 500ms
                racetrack.Update();
                Thread.Sleep(500);
            }
        }
    }
}
