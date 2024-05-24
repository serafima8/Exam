using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace от_10_задачи
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while(true)
            {
                Console.WriteLine("Введите транспорт: ");
                string name = Console.ReadLine();
                switch(name)
                {
                    case "Машина":
                        vehicles.Add(Саг.Show());
                        break;
                    case "Самолет":
                        vehicles.Add(Plane.Show());
                        break;
                    case "Корабль":
                        vehicles.Add(Ship.Show());
                        break;
                    default:
                        Console.WriteLine("Транспорт введен некорректно");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
