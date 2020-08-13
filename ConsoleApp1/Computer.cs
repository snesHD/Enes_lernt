using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
    class Computer
    {
        public GPU gpu { get; set; }
        public CPU cpu { get; set; }
        public PSU psu { get; set; }
        public CPU_Cooler cooler { get; set; }
        public Motherboard mobo { get; set; }
        public List<RAM> ramList { get; set; }
        public List<Speicher> speicherList { get; set; }

        public Computer()
        {
            ramList = new List<RAM>();
            speicherList = new List<Speicher>();
        }
        public Computer(CPU cpu, PSU psu, GPU gpu, CPU_Cooler cooler, Motherboard mobo)
        {
            this.cpu = cpu;
            this.psu = psu;
            this.gpu = gpu;
            this.mobo = mobo;
            this.cooler = cooler;
            ramList = new List<RAM>();
            speicherList = new List<Speicher>();
        }



        public void printComp()
        {
            Console.WriteLine("CPU: " + cpu.Cpu_bezeichnung);
        }

    }
}
