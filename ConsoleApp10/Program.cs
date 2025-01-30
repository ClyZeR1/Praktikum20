using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC pc = new PC();
            pc.model = "AMD";
            pc.MGz = 2;
            pc.OZY = 8;
            pc.memory = 256;
            
            Console.WriteLine();
           //
            Console.WriteLine("Модель: ");
            string modeli = Console.ReadLine();
            Console.WriteLine("Тактовая частота: ");
            int mgz = int.Parse(Console.ReadLine());
            Console.WriteLine("Оперативная память: ");
            int ozy = int.Parse(Console.ReadLine());
            Console.WriteLine("Объем памяти: ");
            int memory = int.Parse(Console.ReadLine());
            pc.Info();
            PC pc2 = new PC(modeli, mgz,ozy,memory);
            Console.WriteLine($"{pc2.ToString()}");
            //
            PC pc3 = new PC("Intel", 3,32,512);
            Console.WriteLine($"{pc3.ToString()}");
            Console.ReadKey();


        }
    }
}
