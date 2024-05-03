using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(5, 5, "A"), new Point(10, 10, "B"), new Point(15, 15, "C"));
            Console.Write(figure.Perimeter());
            Figure figure1 = new Figure(new Point(5, 5, "A"), new Point(10, 10, "B"), new Point(15, 15, "C"),new Point(20,20,"D"));
            Console.Write(figure1.Perimeter());
            Figure figure2 = new Figure(new Point(5, 5, "A"), new Point(10, 10, "B"), new Point(15, 15, "C"), new Point(20, 20, "D"),new Point(25,25,"E"));
            Console.Write(figure2.Perimeter());

            Console.ReadKey();
        }
    }
}
