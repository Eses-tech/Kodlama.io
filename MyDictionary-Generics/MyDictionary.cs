using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary_Generics
{
    class MyDictionary<K, L>
    {
        K[] keys;
        L[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new L[0];
        }

        public void Add(K item1, L item2)
        {
            K[] tempArray_keys = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < tempArray_keys.Length; i++)
            {
                keys[i] = tempArray_keys[i];

            }
            keys[keys.Length - 1] = item1;

            L[] tempArray_values = values;
            values = new L[values.Length + 1];
            for (int j = 0; j < tempArray_values.Length; j++)
            {
                values[j] = tempArray_values[j];
            }
            values[values.Length - 1] = item2;
        }

        public int Count
        {
            get
            {
                return keys.Length;

            }
        }

        public void List()
        {
            for (int k = 0; k < keys.Length; k++)
            {
                Console.WriteLine(keys[k] + ":" + values[k]);

            }
        }
    }


}
