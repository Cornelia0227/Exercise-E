using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_E
{
    class Class_E1L
    {
        public void E1L()   //在做for循环时注意边界值，0，1！！！！
        {
            int n, N;
            Console.WriteLine("Please input a ramdon integer Number : ");
            N = n = Convert.ToInt32(Console.ReadLine());
            int[] f = new int[N];
            int x = 0;
            if (N > 1)
            {
                for (int i = N - 1; i > 0; i--)
                {
                    if (n % i == 0 && n > 1)
                    {
                        f[x] = i;
                        /* n = i;                                         //find prime factors
                         while (n % f[x] == 0 && n > 1 && f[x] > 1)   
                          {
                              n = n / f[x];
                              //Console.WriteLine(n);   //test
                          }  */
                        x++;
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
                Console.WriteLine("The factors of {0} is: 1. ",N);
            }
            
        }
    }
}
