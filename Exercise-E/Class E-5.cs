using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_E
{
    class Class_E5
    {
        public void E5()
        {
            int n=10000;
            int s=5;
            Console.WriteLine("Output all the Prime Number(5~10000) : ");
            do
            {
                int i;
                for (i = 2; i < s; i++)
                {
                    if (s % i == 0)
                    {
                        //Console.WriteLine(i);  //test
                        break;
                    }
                }
                if (i == s)
                {
                    Console.Write("{0}\t",s);
                }
                s++;
            } while (s < n + 1);
                
        }
    }
}
