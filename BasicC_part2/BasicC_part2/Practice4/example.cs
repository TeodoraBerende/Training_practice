using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class example
    {
        public void Unboxing()
        {
            int i = 123;
            object o = i; //boxing

            o = 124;
            i = (int)o;  // unboxing



            List<object> mixedList = new List<object>();

            // Add a string element to the list.
            mixedList.Add("First Group:");

            // Add some integers to the list.
            for (int j = 1; j < 5; j++)
            {
                mixedList.Add(j);
            }

            // Add another string and more integers.
            mixedList.Add("Second Group:");
            for (int j = 5; j < 10; j++)
            {
                mixedList.Add(j);
            }

            int sum = 0;
            foreach (var item in mixedList)
            {
                Console.WriteLine(item);
                if (item is int)
                {
                    sum += (int)item;
                }
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
