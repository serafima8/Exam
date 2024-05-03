using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Author : Book
    {
        private string authorbook;
        public string Authorbook { get; set; }
        public Author(string authorbook)
        {
            this.Authorbook = authorbook;
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Имя автора книги: {Authorbook}");
        }
    }
}
