using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2

            Title title = new Title("Отцы и дети");
            title.Show();
            Author author = new Author("Иван Тургенев");
            author.Show();
            Content content = new Content("Тут будет содержание книги");
            content.Show();

            Console.ReadKey();

        }
    }
}
