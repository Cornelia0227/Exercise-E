using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_E
{
    class Class_E3
    {
        public void E3()   //在做for循环时注意边界值，0，1！！！！   
        {
            int n;
            int i;
            Console.WriteLine("Please input an integer Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 1)
            {
                for (i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        //Console.WriteLine(i);  //test
                        Console.WriteLine("{0} is NOT Prime", n);
                        break;
                    }
                }
                if (i == n)
                {
                    Console.WriteLine("{0} is Prime", n);
                }
            }
            else
            {
                Console.WriteLine("{0} is NOT Prime", n);
            }
        }
    }
}
