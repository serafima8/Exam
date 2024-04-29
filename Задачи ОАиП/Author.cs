using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_ОАиП
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
            Console.WriteLine($"Имя автора книги: {Authorbook}");
        }
    }
}
