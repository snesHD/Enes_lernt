using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Motherboard
    {
        private string mobo_bezeichnung;

        public string Mobo_bezeichnung
        {
            get { return mobo_bezeichnung; }
            set { mobo_bezeichnung = value; }
        }

        private string mobo_hersteller;

        public string Mobo_hersteller
        {
            get { return mobo_hersteller; }
            set { mobo_hersteller = value; }
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

        public Motherboard(string mobo_bezeichnung, string mobo_hersteller, bool m2_slots, int ram_slots, bool dualchannel_sup, double mobo_preis)
        {
            this.mobo_bezeichnung = mobo_bezeichnung;
            this.mobo_hersteller = mobo_hersteller;
            this.m2_slots = m2_slots;
            this.ram_slots = ram_slots;
            this.dualchannel_sup = dualchannel_sup;
            this.mobo_preis = mobo_preis;
        }
    }
}
