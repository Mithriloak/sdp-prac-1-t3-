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
            //Sum
            int y = FindSum();
            Console.WriteLine("The sum of all the multiples of 3 and 5 below 1000 is = " + y.ToString());
            
            
            //Fib 1
            int x = fibNumberSum(1, 2, 3);
            Console.WriteLine("The number sum of all the fib numbers below 4000000 =" + x.ToString());
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
      
      public static int FindSum()
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
             return sum;
      }
    }
}
