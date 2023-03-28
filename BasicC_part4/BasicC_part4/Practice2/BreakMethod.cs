using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class BreakMethod
    {
        public List<int> Numbers { get; set; }

        public int SumNumbers()
        {
            int sum = Numbers.Sum();            
            return sum;
        }
        
        public void PrintNumbers()
        {
            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
