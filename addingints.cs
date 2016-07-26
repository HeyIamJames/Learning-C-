//adds two ints
using System;
using System.Collections.Generic;
using System.Text;
 
namespace NP
{
   class AddTwoNumbers
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
         int a, b;
         System.Console.WriteLine("Program for Adding Two Numbers");
        
         System.Console.Write("Enter First Number: ");
         ReadInteger(out a);
         System.Console.Write("Enter Second Number: ");
         ReadInteger(out b);
 
         int result = a + b;
 
         System.Console.Write("Result {0} + {1} = {2}\n", a, b, result);
        
      }
   }
}
