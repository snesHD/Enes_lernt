using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GPU
    {
        private string gpu_name;

        public string Gpu_name
        {
            get { return gpu_name; }
            set { gpu_name = value; }
        }

        private string gpu_chipbezeichnung;

        public string Gpu_chipbezeichnung
        {
            get { return gpu_chipbezeichnung; }
            set { gpu_chipbezeichnung = value; }
        }

        private string gpu_hersteller;

        public string Gpu_hersteller
        {
            get { return gpu_hersteller; }
            set { gpu_hersteller = value; }
        }

        private double gpu_preis;

        public double Gpu_preis
        {
            get { return gpu_preis; }
            set { gpu_preis = value; }
        }

        public GPU(string gpu_name, string gpu_chipbezeichnung, string gpu_hersteller, double gpu_preis)
        {
            this.gpu_name = gpu_name;
            this.gpu_chipbezeichnung = gpu_chipbezeichnung;
            this.gpu_hersteller = gpu_hersteller;
            this.gpu_preis = gpu_preis;
        }

    }
}
