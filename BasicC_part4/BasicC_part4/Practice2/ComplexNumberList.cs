using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class ComplexNumberList
    {
        public ComplexNumber[] MyComplexNumberArray { get; set; }
        public List<ComplexNumber> MyComplexNumberList { get; set;}

        public ComplexNumberList()
        {
            var complexNumber1 = new ComplexNumber(1, 2);
            var complexNumber2 = new ComplexNumber(4, 6);
            var complexNumber3 = new ComplexNumber(7, 9);

            MyComplexNumberArray = new ComplexNumber[] {complexNumber1, complexNumber2 , complexNumber3 };
            MyComplexNumberList = new List<ComplexNumber> { complexNumber1, complexNumber2, complexNumber3 };
        }

        public void AddNewComplexNumber(ComplexNumber complexNumber)
        {
            MyComplexNumberList.Add(complexNumber);

            var size = MyComplexNumberArray.Length;
            size = size + 1;

            ComplexNumber[] myNewArray = new ComplexNumber[size];
            for(int i = 0; i< MyComplexNumberArray.Length; i++)
            {
                myNewArray[i] = MyComplexNumberArray[i];
            }
            myNewArray[size - 1] = complexNumber;
            MyComplexNumberArray = myNewArray;
        }

        public void DeleteFromPosition(int position)
        {
            if (position > MyComplexNumberList.Count)
            {
                Console.WriteLine("The lenght of my list is smaller that your given position.");
                return;
            }
            MyComplexNumberList.RemoveAt(position);
        }

        public void PrintImaginaryParts()
        {
            foreach(var complexNumber in MyComplexNumberList)
            {
                Console.WriteLine(complexNumber.ImaginaryPart);
            }
        }
    }
}
