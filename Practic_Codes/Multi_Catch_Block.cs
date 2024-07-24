using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Codes
{
    //Q.Can we use multiple catch blocks in c# ?

    //Ans ==> Yes, in C#, We can use multiple catch blocks for a given try block.
    //However, at any given point, only one catch block will be executed, and the others will be ignored.
    //In this example, we have three catch blocks: one for DivideByZeroException, FormatException and another for others Exceptions .
    //Depending on the exception thrown, the appropriate catch block will handle it.

    public class Multi_Catch_Block
    {
        public void Multi_Catch_Block_Emp()
        {
            try
            {
                Console.WriteLine("Enter number1:");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number2:");
                int number2 = int.Parse(Console.ReadLine());

                int result = number1 / number2;

                Console.WriteLine("result: "+result);
                 

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }
    }
}
