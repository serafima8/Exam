using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_ОАиП
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }
        public void Print()
        {
            Console.WriteLine($"Сторона 1: {Side1}\nСторона 2: {Side2}");
        }
        public double AreaCalculator()
        {
            return Side1 * Side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (Side1 + Side2);
        }
        public double Area { get; }
        public double Perimeter { get; }
    }
}
