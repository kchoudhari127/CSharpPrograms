using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Codes
{
    public class ArrayvsArrayList
    {
        //Array -- strongly typed, fixed size, 
        //An array is strongly typed. This means that an array can store only specific types of items\elements.
        // In arrays, we can store only one datatype, either int, string, char, etc…
        //Array can not accept null
        //	Arrays belong to System.Array namespace using System;

        //ArrayList -- Not strongly typed, Not fixed size
        // ArrayList can store any items\elements.
        //In ArrayList we can store all the datatype values.
        //ArrayList collection accepts null.
        //ArrayList belongs to System.Collection namespaces using System.Collections;

            public void ArrayAndArrayList()
           {
            //Array
            int[] arrayNum = new int[5];
            arrayNum[0] = 10;
            arrayNum[1] = 20;
            arrayNum[2] = 30;
            arrayNum[3] = 40;
            arrayNum[4] = 50;

            int[] arrayNum2 = new int[5] { 1, 2, 3, 4, 5 };

            //ArrayList
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Rohit");
            arrList.Add(true);
            arrList.Add(null);
            }

        }
}
