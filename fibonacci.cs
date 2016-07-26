//http://www.softwareandfinance.com/CSharp/Fibonacci_Series.html
using System;
using System.Collections.Generic;
using System.Text;
 
namespace Fibonacci
{
 
   class FibonacciSeries
   {
      static bool ReadInteger(out int n)
      {
         string input = System.Console.ReadLine();
         n = 0;
         try
         {
            n = Convert.ToInt32(input);
            return true;
         }
         catch (System.Exception ex)
         {
            System.Console.WriteLine("Error in the input format\n\n");
            return false;
         }
      }
      static void Main(string[] args)
      {
         int f1 = 0, f2 = 1, f3, n = 0;
         System.Console.WriteLine("Program for Fibonacci Series");
         System.Console.Write("Enter the maximum number for Fibonacci Series: ");
         ReadInteger(out n);
 
         System.Console.Write("\n\nPrinting Fibonacci Series from 0 - {0}\n\n", n);
         System.Console.Write("{0}\t{1}\t", f1, f2);
         while (true)
         {
            f3 = f1 + f2;
            if (f3 > n)
               break;
            System.Console.Write("{0}\t", f3);
            f1 = f2;
            f2 = f3;
         }
         System.Console.WriteLine("\n");
      }
   }
}
