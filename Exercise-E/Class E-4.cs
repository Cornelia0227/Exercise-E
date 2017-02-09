using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_E
{
    class Class_E4
    {
        public void E4()   //在做for循环时注意边界值，0，1！！！！
        {
            int n, num, sum=0;
            Console.WriteLine("Please input an integer Number : ");
            num = n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    sum += i;
                }
            }
            if(sum==num && num!=0)
            {
                Console.WriteLine("Number {0} is a Perfect Number ! ",num);
            }
            else
            {
                Console.WriteLine("Number {0} is not a Perfect Number ! ", num);
            }
        }
    }
}
