using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Codes
{
    public class Reverse_String
    {
        public Reverse_String()
        {
            string originalString = "Welcome 2025";
            string reverseString = string.Empty;
            char[] charArray = originalString.ToCharArray();

            for (int i = charArray.Length-1; i >= 0; i--)
            {
                reverseString += charArray[i];
            }

            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Reversed String: " + reverseString);
            Console.ReadKey();
        }
        
    }
}
