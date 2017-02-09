using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_E
{
    class Class_E6
    {
        public void E6()
        {
            int n=1000, num=1;
            Console.WriteLine("Output all the Perfect Numbers(1~1000) : ");
            do
            {
                int sum = 0;         //需要注意变量定义的起始地方，
                if (num > 1)         //因为之前将sum定义在最开始，导致其不断增加，无法找到完美数。
                {
                    for (int i = 1; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            sum += i;
                        }
                    }
                    if (sum == num)
                    {

                        Console.WriteLine("{0}\t", num);
                    }
                    num++;
                }
                else
                { num++; }
            } while (num < n + 1);

        }
    }
}
