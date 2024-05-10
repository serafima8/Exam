using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class MyClass
    {
        public static int Sum(int m, int n)
        {
            int sum = 0;
            for(int i=m;i<=n;i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
