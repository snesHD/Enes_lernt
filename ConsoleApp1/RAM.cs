using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RAM
    {
        private string ram_bezeichnung;

        public string Ram_bezeichnung
        {
            get { return ram_bezeichnung; }
            set { ram_bezeichnung = value; }
        }

        private string ram_hersteller;

        public string Ram_hersteller
        {
            get { return ram_hersteller; }
            set { ram_hersteller = value; }
        }
        
        private int ram_freq;

        public int Ram_freq
        {
            get { return ram_freq; }
            set { ram_freq = value; }
        }

        private double ram_preis;

        public double Ram_preis
        {
            get { return ram_preis; }
            set { ram_preis = value; }
        }

        public RAM(string ram_bezeichnung, string ram_hersteller, int ram_freq, double ram_preis)
        {
            this.ram_bezeichnung = ram_bezeichnung;
            this.ram_hersteller = ram_hersteller;
            this.ram_freq = ram_freq;
            this.ram_preis = ram_freq;
        }
    }
}