using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    ///// <summary>
    ///// 1.Объявление делегата
    ///// </summary>
    ///// <param name="a"></param>
    ///// <param name="b"></param>
    ///// <param name="c"></param>
    ///// <returns>Возвращает площадь треугольника abc</returns>
    //public delegate double Message(double a, double b, double c); //(37 задача)
    ///// <summary>
    ///// Объявление делегата
    ///// </summary>
    ///// <param name="m"></param>
    ///// <param name="n"></param>
    ///// <returns></returns>
    //public delegate int Message2(int m, int n); //(44 задача)
    ///// <summary>
    ///// Объявление делегата
    ///// </summary>
    ///// <param name="m"></param>
    ///// <param name="n"></param>
    ///// <returns></returns>
    //public delegate double Message3(int m1, int n1); //(40 задача)
    class Program
    {
        static void Main(string[] args)
        {
            ////2. Создание объекта делегата (37 заадча)
            //Message message;
            ////3. Присвоение указателя на метод
            //message = Triangle.S;
            //Console.Write("Введите а: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите b: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите c: ");
            //double c = Convert.ToDouble(Console.ReadLine());
            //Console.Write($"Площадь треугольника: {message(a, b, c)}");

            ////Создание объекта делегата (44 задача)
            //Message2 message2;
            //message2 = MyClass.Sum;
            //Console.Write("\nВведите начало диапазона: ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите конец диапазона: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"Сумма чисел: {message2(m, n)}");

            ////Создание объекта делегата (40 задача)
            //Message3 message3;
            //message3 = MyClass2.Average;
            //Console.Write("\nВведите начало диапазона: ");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите конец диапазона: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"Среднее арифметическое: {message3(m1, n1)}");


            //ЗАДАЧА 47
            List<Zakaz> zakazs = new List<Zakaz>();
            //  bool x = true;
            while(true)
            {
                Console.Write("Введите фамилию: ");
                string fam = Console.ReadLine();
                if (fam.ToUpper() == "Q")
                    break;
                Console.Write("Введите кол-во мест: ");
                int size = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите комфортность: ");
                string comfort = Console.ReadLine();

            }

            Console.ReadKey();
        }
    }
}
