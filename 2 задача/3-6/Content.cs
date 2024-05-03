using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Content : Book
    {
        private string contents;
        public string Contents { get; set; }
        public Content(string contents)
        {
            this.Contents = contents;
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Содержание книги: {Contents}");
        }
    }
}
