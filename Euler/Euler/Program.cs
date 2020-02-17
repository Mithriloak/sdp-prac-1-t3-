using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int sum = 0;

            for (int i = 0; i < 1001; i++)
            {
                list.Add(i);

                if (i % 3 == 0)
                {
                    sum = sum + i;
                }

                if (i % 5 == 0)
                {
                    sum = sum + i;
                }
                
            }

            Console.WriteLine("The sum of all the multiples of 3 and 5 below 1000 is = " + sum.ToString());

            Console.ReadLine();
        }
    }
}
