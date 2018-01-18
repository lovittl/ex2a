using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Ex2A
{
    class Program
    {
        static void Main(string[] args)
        {
          
        int i,n,sum=0;
	    	
	    Console.Write("\n\n");
        Console.Write("Read 10 numbers and calculate sum and average:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");
	
	    Console.Write("Input the 10 numbers : \n");

            for (i=1;i<=10;i++)
	        {
            Console.Write("Number-{0} :",i);
            n= Convert.ToInt32(Console.ReadLine());		
		    sum +=n;
	        }

        Console.WriteLine((sum));

        }
    }
}

