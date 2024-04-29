using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_ОАиП
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
            Console.WriteLine($"Название книги: {Name}");
        }
    }
}
