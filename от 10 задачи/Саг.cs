using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace от_10_задачи
{
    class Саг : Vehicle
    {
        public Саг(double price, double speed, int years) : base(price, speed, years) { }
        public override void Transport()
        {
            Console.WriteLine($"Цена транспорта: {Price}\nСкорость: {Speed}\nГод выпуска: {Years}");
        }
        static public Саг Show()
        {
            Console.WriteLine("Введите цену машины: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость машины: ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите год выпуска машины: ");
            int years = Convert.ToInt32(Console.ReadLine());
            return new Саг(price, speed, years);
        }

    }
}
