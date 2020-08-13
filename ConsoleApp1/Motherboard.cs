using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Motherboard
    {
        private int mobo_bezeichnung;

        public int Mobo_bezeichnung
        {
            get { return mobo_bezeichnung; }
            set { mobo_bezeichnung = value; }
        }

        private int ram_slots;

        public int Ram_slots
        {
            get { return ram_slots; }
            set { ram_slots = value; }
        }

        private bool dualchannel_sup;

        public bool Dualchannel_sup
        {
            get { return dualchannel_sup; }
            set { dualchannel_sup = value; }
        }

        private bool m2_slots;

        public bool M2_slots
        {
            get { return m2_slots; }
            set { m2_slots = value; }
        }

        private double mobo_preis;

        public double Mobo_preis
        {
            get { return mobo_preis; }
            set { mobo_preis = value; }
        }
    }
}
