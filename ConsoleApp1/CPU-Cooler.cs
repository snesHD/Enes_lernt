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

        private bool kühler_L_W;

        public bool Kühler_L_W
        {
            get { return kühler_L_W; }
            set { kühler_L_W = value; }
        }

        private int kühler_preis;

        public int Kühler_preis
        {
            get { return kühler_preis; }
            set { kühler_preis = value; }
        }
    }
}