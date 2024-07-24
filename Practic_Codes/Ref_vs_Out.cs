using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Codes
{
    public class Ref_vs_Out
    {
        // In C#, the ref and out keywords serve similar purposes but have distinct differences.
        public static int AddNumOut(int x, int y, out int diff)
        {
            //The out keyword indicates that the parameter will be initialized inside the function.
            //The function must assign a value to the out parameter before returning.
            //It’s not allowed to leave the out parameter unassigned.
            //Useful when a method needs to return multiple values.
            diff = x - y;
            return x + y;

        }

        //The ref keyword indicates that the parameter is initialized before entering the function.
        public static int MultiplyRef(int x, int y, ref int div)
        {
            //The called function can read and modify the value of the ref parameter.
            //The parameter goes into the function and comes out with potential modifications.
            //Useful for two-way communication between the caller and the function.
            div = x / y;
            return x * y;
        }

        public void RefvsOut()
        {
            Console.WriteLine("Test Out Parameter");
            int diff;
            int sum = AddNumOut(10, 20,out diff);
            Console.WriteLine("The sum is : " + sum);
            Console.WriteLine("The diff is : " + diff);

            Console.WriteLine("*************************************");

            Console.WriteLine("Test Ref Parameter");
            int div=0;
            int mul = MultiplyRef(10, 2, ref div);
            Console.WriteLine("The sum is : " + mul);
            Console.WriteLine("The div is : " + div);

            Console.ReadLine();
        }
    }
}
