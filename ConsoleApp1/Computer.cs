using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
    class Computer
    {
        public List<GPU> gpuList { get; set; }
        public List<CPU> cpuList { get; set; }
        public List<PSU> psuList { get; set; }
        public List<RAM> ramList { get; set; }
        public List<CPU_Cooler> coolerList { get; set; }
        public List<Motherboard> moboList { get; set; }
        public List<Speicher> speicherList { get; set; }

        public Computer()
        {
            gpuList = new List<GPU>();
            cpuList = new List<CPU>();
            psuList = new List<PSU>();
            ramList = new List<RAM>();
            coolerList = new List<CPU_Cooler>();
            moboList = new List<Motherboard>();
            speicherList = new List<Speicher>();
        }
    }
}
