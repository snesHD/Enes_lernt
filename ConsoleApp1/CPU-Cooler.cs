using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CPU_Cooler
    {
        private string kühlerbezeichnung;

        public string Kühlerbezeichnung
        {
            get { return kühlerbezeichnung; }
            set { kühlerbezeichnung = value; }
        }

        private string kühler_hersteller;

        public string Kühler_hersteller
        {
            get { return kühler_hersteller; }
            set { kühler_hersteller = value; }
        }

        private bool kühler_wasser;

        public bool Kühler_wasser
        {
            get { return kühler_wasser; }
            set { kühler_wasser = value; }
        }

        private double kühler_preis;

        public double Kühler_preis
        {
            get { return kühler_preis; }
            set { kühler_preis = value; }
        }

        public CPU_Cooler(string kühlerbezeichnung, string kühler_hersteller, bool kühler_wasser, double kühler_preis)
        {
            this.kühlerbezeichnung = kühlerbezeichnung;
            this.kühler_hersteller = Kühler_hersteller;
            this.kühler_wasser = kühler_wasser;
            this.kühler_preis = kühler_preis;
        }
    }
}