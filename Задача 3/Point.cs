using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Point
    {
        private int x;
        private int y;
        private string name;
        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        public Point(int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }

    }
}
