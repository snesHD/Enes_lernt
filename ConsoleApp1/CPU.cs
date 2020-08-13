using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CPU
    {
        private string cpu_bezeichnung;

        public string Cpu_bezeichnung
        {
            get { return cpu_bezeichnung; }
            set { cpu_bezeichnung = value; }
        }

        private string cpu_chipbezeichnung;

        public string Cpu_chipbezeichung
        {
            get { return cpu_chipbezeichnung; }
            set { cpu_chipbezeichnung = value; }
        }

        private string cpu_hersteller;

        public string Cpu_hersteller
        {
            get { return cpu_hersteller; }
            set { cpu_hersteller = value; }
        }

        private double cpu_preis;

        public double Cpu_preis
        {
            get { return cpu_preis; }
            set { cpu_preis = value; }
        }
        
        public CPU(string cpu_bezeichnung, string cpu_chipbezeichnung, string cpu_hersteller, double cpu_preis)
        {
            this.cpu_bezeichnung = cpu_bezeichnung;
            this.cpu_chipbezeichnung = cpu_chipbezeichnung;
            this.cpu_hersteller = cpu_hersteller;
            this.cpu_preis = cpu_preis;
        }

    }
}
