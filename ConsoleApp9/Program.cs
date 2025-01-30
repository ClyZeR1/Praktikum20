using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Build dom1 = new Build();
            dom1.name = "Квартира";
            dom1.area = 80;
            dom1.kvo = 2;
            dom1.ShowInfo();
            Console.WriteLine();
            // второй дом
            Build dom2 = new Build("Отель", 6000, 1500);
            Console.WriteLine($"{dom2.ToString()}");
            Console.WriteLine();
            Console.Write("Название строения: ");
            string name = Console.ReadLine();
            Console.Write("Площадь строения: ");
            double area = double.Parse(Console.ReadLine());
            Console.Write("Количество жильцов: ");
            int kvo = int.Parse(Console.ReadLine());
            Console.Write("Количество этажей: ");
            int floor = int.Parse(Console.ReadLine());
            Build dom3 = new Build(name, area, kvo, floor);
            Console.WriteLine($"{dom3.ToString()}");
            Console.ReadKey();




        }
    }
}
