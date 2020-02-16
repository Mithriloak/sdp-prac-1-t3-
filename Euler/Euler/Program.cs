using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args) //G18H2558 - Julian Herr
        {
            int fterm = 1; //first term 
            int sterm = 2; //second term
            int nterm;     //next term
            int sum = 0;

            List<int> flist = new List<int>(); //initialization
            flist.Add(fterm);
            flist.Add(sterm);
            
            for (int i = 0; i < 30; i++) //adding the values to the fib list
            {
                nterm = flist[i] + flist[i + 1];
                flist.Add(nterm);            }

            for (int i = 0; i < flist.Count(); i++) //print out all values of the fib list
            {
                Console.WriteLine(flist[i]);
            }

            foreach (int i in flist) //finding all the even numbers
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Total sum: " + sum.ToString()); //print the total sum
            Console.ReadLine();


        }
    }
}
