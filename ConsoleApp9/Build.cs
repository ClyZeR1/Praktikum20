using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Build
    {
        public string name;

        public double area;

        public int kvo;

        public int floor;

        public Build() { }

        public Build(string name)
        {
            this.name = name;
        }
        public Build(string name, double area) : this(name)
        {
            this.area = area;
        }
        public Build(string name, double area, int kvo) : this(name, area) 
        {
            this.kvo = kvo;
        }
        public Build(string name, double area, int kvo, int floor) : this(name, area, kvo)
        {
            this.floor = floor;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"В доме: {name}\t Площадью: {area}\t Квадратных метров живет: {kvo} чел," +
                $"на человека - {area/ kvo:f2} кв. метров");
               
        }
        public override string ToString()
        {
            return $"В доме {name} площадью {area} кв. метров живёт {kvo} чел, " +
                $"на человека - {area / kvo:f2} кв. метров";
        }

    }
}
