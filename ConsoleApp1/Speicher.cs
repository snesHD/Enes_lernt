using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Speicher
    {
        private string speicher_bezeichnung;

        public string Speicher_bezeichnung
        {
            get { return speicher_bezeichnung; }
            set { speicher_bezeichnung = value; }
        }

        private int speicher_groesse;

        public int Speicher_groesse
        {
            get { return speicher_groesse; }
            set { speicher_groesse = value; }
        }

        private string speicher_art;

        public string Speicher_art
        {
            get { return speicher_art; }
            set { speicher_art = value; }
        }

        private double speicher_preis;

        public double Speicher_preis
        {
            get { return speicher_preis; }
            set { speicher_preis = value; }
        }
    }
}
