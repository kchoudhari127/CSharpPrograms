using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ (Language Integrated Query) is a powerful feature in C# that allows you to query and manipulate data from various sources using a uniform syntax.

namespace Practic_Codes
{
    public class LinqDemo
    {
        public void LinqDemo1()
        {
            //char
    
            // Specify the data source.
            char[] arr = new char[5] { 'a', 'b', 'c','d','e' };

            // Define the query expression.
            var resultChar = from x in arr
                             where x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u'
                             select x;

            // Execute the query.
           foreach( var x in resultChar)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("******************************************************************************************");
            //int - select values is divided by 2
            int[] intNums = new int[6] { 2, 7, 13, 18, 33, 48 };

            var resultInt = from x in intNums
                            where x % 2 == 0
                            select x;

            foreach(var y in resultInt)
            {
                Console.WriteLine(y);
            }

            Console.WriteLine("******************************************************************************************");

            //string 
            string[] strarr = new string[4] { "Goa", "Pune", "Mumbai", "Solapur" };

            var resultString = from x in strarr
                               where x.Length > 5
                               select x;
            foreach( var z in resultString)
            {
                Console.WriteLine(z);
            }
          
            Console.ReadLine();
        }
    }
}
