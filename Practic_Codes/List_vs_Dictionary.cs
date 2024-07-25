using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//List - strogly type, not fixed length
// - Lists are dynamic arrays that store a collection of objects.
// - They allow duplicate items and provide fast access by index.
// - Accessed using indices (starting from 0).
// - Created using List<T> where T represents the type of elements.

//Dictionary - key-value pairs, Keys must be unique
// - Dictionaries store data as key-value pairs (unordered).
// - Keys must be unique, and each key maps to a specific value.
// - Created using Dictionary<TKey, TValue>.

//Key Differences:
// - Lists are better for sequential data and allow duplicates.
// - Dictionaries are optimized for quick data retrieval by specific keys.
// - Use a list when order matters, and a dictionary when you need efficient lookups based on keys.

namespace Practic_Codes
{

    public class List_vs_Dictionary
    {
        public void list_and_Dictionary()
        {
            //list 
            List<int> numList = new List<int>();
            numList.Add(10);
            numList.Add(20);
             Console.WriteLine(numList[0]);  // Accessing by index

            //Dictionary

            Dictionary<int,char> dict = new Dictionary<int,char>();
            dict.Add(1, 'a');
            dict.Add(2, 'b');
            // dict.Add(2, 'b'); // Duplicate keys not allowed

            Console.WriteLine(dict[1]); // Accessing by key


        }

    }
}
