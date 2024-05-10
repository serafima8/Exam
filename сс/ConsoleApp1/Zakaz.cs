using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zakaz
    {
        private string fam;
        private int size;
        private string comfort;

        public string Fam { get { return fam; } set { fam = value; } }

        public int Size { get { return size; } set { size = value; } }
        public string Comfort { get { return comfort; } set { comfort = value; } }

        public void Show()
        {
            Console.WriteLine($"Фамилия: {Fam}\nКол-во мест в номере: {Size}\nКомфортность: {Comfort}");
        }

        public Zakaz() { }
        public Zakaz(string fam)
        {
            this.Fam = fam;
        }
        public Zakaz(string fam,int size):this(fam)
        {
            this.Size = size;
        }
        public Zakaz(string fam, int size,string comfort) : this(fam,size)
        {
            this.Comfort = comfort;
        }
    }
}
