using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class ComplexNumber
    {
        public int RealPart { get; set; }
        public int ImaginaryPart { get; set; }

        public ComplexNumber(int realpart, int imaginaryPart)
        {
            RealPart = realpart;
            ImaginaryPart = imaginaryPart;
        }
    }
}
