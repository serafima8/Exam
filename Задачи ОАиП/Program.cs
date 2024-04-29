using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_ОАиП
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Rectangle rectangle = new Rectangle(5,8);
            //rectangle.Print();
            //Console.WriteLine($"Площадь прямоугольника: {rectangle.AreaCalculator()}");
            //Console.WriteLine($"Периметр прямоугольника: {rectangle.PerimeterCalculator()}");

            //Задача 2
            //Title title = new Title("Отцы и дети");
            //title.Show();
            //Author author = new Author("Иван Тургенев");
            //author.Show();
            //Content content = new Content("Тут будет содержание книги");
            //content.Show();

            //Задача 3
            Address address = new Address();
            Console.WriteLine($"Индекс: {address.Index = 56}");
            Console.WriteLine($"Страна: {address.Country = "Приднестровье"}");
            Console.WriteLine($"Город: {address.City = "Тирасполь"}");
            Console.WriteLine($"Улица: {address.Street = "Юности"}");
            Console.WriteLine($"Дом: {address.House = 3}");
            Console.WriteLine($"Квартира: {address.Apartment = 24}");
            
            
            
            Console.ReadKey();
        }
    }
}
