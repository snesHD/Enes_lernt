using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GPU gpu1 = new GPU("Asus RTX 2080ti", "Nvidia RTX 2080ti", "Asus", 1399.99);
            GPU gpu2 = new GPU("Asus Dual Rx580 8Gb", "AMD Radeon RX 580", "Asus", 199.99);

            CPU cpu1 = new CPU("Intel Core I9-9900k", "Intel Skylake 9", "INTEL", 499.99);
            CPU cpu2 = new CPU("AMD Ryzen 5 3600X", "Zen3 Ryzen 5", "AMD", 219.99);

            PSU psu1 = new PSU("Corsair CX550M", "Corsair", 550, 59.99);
            PSU psu2 = new PSU("Cooler Master 650", "Cooler Master", 650, 79.99);

            RAM ram1 = new RAM("Corsair Vengance 2x8", "Corsair", 3200, 69.99);
            RAM ram2 = new RAM("Corsair Vengance RGB Pro 2x16", "Corsair", 3600, 119.99);

            CPU_Cooler cooler1 = new CPU_Cooler("Be quit Pure Rock 2", "Be quit", false, 29.99);
            CPU_Cooler cooler2 = new CPU_Cooler("NZXT Kraken X63", "NZXT", true, 138.99);

            Motherboard mobo1 = new Motherboard("MSi B450 Tomahawk", "MSI", true, 4, true, 103.99);
            Motherboard mobo2 = new Motherboard("ASRock B550M pro4", "ASROck", true, 4, true, 209.99);

            Speicher speicher1 = new Speicher("500GB Samsung 970 evo Plus", 500, "M.2", 99.99);
            Speicher speicher2 = new Speicher("1000GB Samsung 860 Qvo", 1000, "SSD", 94.99);

            Computer pc1 = new Computer();

            pc1.gpuList.Add(gpu1);
            pc1.cpuList.Add(cpu1);
            pc1.psuList.Add(psu1);
            pc1.ramList.Add(ram1);
            pc1.coolerList.Add(cooler1);
            pc1.moboList.Add(mobo1);
            pc1.speicherList.Add(speicher1);
        }
    }
}