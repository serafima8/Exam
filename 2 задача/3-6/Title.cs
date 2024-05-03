using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Title : Book
    {
        private string name;
        public string Name { get; set; }
        public Title(string name)
        {
            this.Name = name;
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Название книги: {Name}");
        }
    }
}
