using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PSU
    {
        private string psu_bezeichnung;

        public string Psu_bezeichnung
        {
            get { return psu_bezeichnung; }
            set { psu_bezeichnung = value; }
        }

        private string psu_hersteller;

        public string Psu_hersteller
        {
            get { return psu_hersteller; }
            set { psu_hersteller = value; }
        }
        
        private int psu_leistung;

        public int Psu_leistung
        {
            get { return psu_leistung; }
            set { psu_leistung = value; }
        }
        
        private double psu_preis;

        public double Psu_preis
        {
            get { return psu_preis; }
            set { psu_preis = value; }
        }
    }
}


