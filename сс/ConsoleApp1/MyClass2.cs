using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class MyClass2
    {
        public static double Average(int m1, int n1)
        {
            int count = 0;
            int sum = 0;
            for(int i=m1;i<=n1;i++)
            {
                sum += i;
                count++;
            }
            return (double)sum / count;
        }
    }
}
