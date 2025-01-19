using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Codes
{
    public class Readonly_vs_Const
    {
        //Constant / Const
        //It's a compile time constant.
        //The value can not be changed once after declaration.
        //It can be declared inside the method.

        //Readonly
        //It's a runtime constant.
        //We can update the value after initial declaration.
        //It cannot be declared inside the method.

        public const int num1 = 10;
        public readonly int num2 = 100;

        public Readonly_vs_Const()
        {
            //num1 = 20;
            num2 = 200;
        }

        public void Display()
        {
            Console.WriteLine("Const is :{0}", num1);
            Console.WriteLine("ReadOnly is :{0}", num2);

        }
    }
}
