using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_E
{
    class Class_E2
    {
        public void E2()   //在做for循环时注意边界值，0，1！！！！
        {
            double n=1.0;
            Console.WriteLine("NO\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("------------------------------------------------");
            for (int i=0; i<10;i++ )
            {
                Console.WriteLine("{0:#0.0}\t{1}\t\t{2}\t\t{3:#0.0}", n, Math.Round((1.0 / n), 3), Math.Round(Math.Sqrt(n), 3), Math.Pow(n, 2));
                n++;
            }
        }
    }
}
