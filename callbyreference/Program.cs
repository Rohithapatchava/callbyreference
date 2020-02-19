using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callbyreference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            a = 10;
            b = 20;
            ShowData(ref a,ref  b);
            Console.ReadKey();
        }
        static void ShowData(ref int m, ref int n)
        {
         
            double sum = m + n;
            Console.WriteLine("sum={0}", sum);
            m = m + 2;
            n = n + 2;
        }
    }
}
