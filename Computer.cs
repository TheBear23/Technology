using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer
    {
        public double Ram { get; set; }
        public readonly double Screensize;
        public string OS { get; set; }
        public Computer(double ram, double screensize, string oS)
        {
            Ram = ram;
            Screensize = screensize;
            OS = OS;
        }
        public void PrintStatus()
        {
            Console.WriteLine($"RAM: {Ram}{Environment.NewLine}" + $"Screensize: {Screensize}{Environment.NewLine}" + $"OS: {OS}");
        }
        public void UpgradeRam(double Uram) 
        {
            Ram += Uram;
        }
    }
}
