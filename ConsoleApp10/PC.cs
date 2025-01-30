using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10
{
    internal class PC
    {
        public string model;
        public int MGz;
        public int OZY;
        public int memory;
        public PC() { }
        public PC(string model)
        {
            this.model = model;
        }
        public PC(string model, int MGz) :this(model)
            {
            this.MGz = MGz;
            }
        public PC(string model, int MGz, int OZY) :this(model,MGz)
        {
            this.OZY = OZY;
        }
        public PC(string model, int MGz, int OZY, int memory) :this(model,MGz,OZY)
        {
            this.memory = memory;
        }
        public void Info()
        {
            Console.WriteLine($"Модель: {model}\t тактовая частота: {MGz}\t объем оперативной памяти: {OZY}\t Объем жесткого диска: {memory}");
        }
        public override string ToString()
        {
            return $"Модель: {model}\t тактовая частота: {MGz}\t объем оперативной памяти: {OZY}\t Объем жесткого диска: {memory}";
        }


    }
}
