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
            //Fib 1
            int x = fibNumberSum(1, 2, 3);
            Console.WriteLine(x);
            Console.Read();
            //Fib 1
        }

        //Fib 1
        //Checks whether number passeed is even and returns "true" if statement is true
        public static bool isEven(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }

            return false;
        }//Fib 1

        //Fib 1
        //Sums all even fib numbers less than 4 000 000
        public static int fibNumberSum(int n1, int n2, int n3)
        {

            n3 = n1 + n2;
            int sum = 0;

            if (isEven(n1))
            {
                sum += n1;
            }

            if (isEven(n2))
            {
                sum += n2;
            }

            for (int i = 0; n3 < 4000000; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                if (isEven(n3))
                {
                    sum += n3;
                }
            }
            return sum;
        }//Fib 1
    }
}
