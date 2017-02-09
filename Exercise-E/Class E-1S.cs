using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_E
{
    class Class_E1S
    {
        public void E1S()   //在做for循环时注意边界值，0，1！！！！
        {
            int n,N;
            Console.WriteLine("Please input a ramdon integer Number : ");
            N = n = Convert.ToInt32(Console.ReadLine());
            int[] f = new int[N];
            int x = 0;
            if(N>1)
            {
                for (int i = 1; i < N; i++)
                {
                    if (n % i == 0 && n > 1)
                    {
                        f[x] = i;
                        x++;
                        /* n = n / i;
                         while (n % i == 0 && n > 1 && i > 1)    //find prime factors
                         {
                             n = n / i;
                             //Console.WriteLine(n);   //test
                         } */
                    }
                    else { continue; }
                }
                Console.WriteLine("The factors of {0} is: ", N);
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(" {0}>:  {1}", i, f[i]);
                }
            }
            else
            {
                Console.WriteLine("The factors of {0} is: 1. ", N);
            } 
        }
    }
}
