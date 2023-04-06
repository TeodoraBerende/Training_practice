using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class ComplexNumberList
    {
        public ComplexNumber[] MyComplexNumberArray { get; set; }
        public List<ComplexNumber> MyComplexNumberList { get; set;}

        private int myArraySize;
        private int myElementsNumber;

        public ComplexNumberList()
        {
            var complexNumber1 = new ComplexNumber(1, 2);
            var complexNumber2 = new ComplexNumber(4, 6);
            var complexNumber3 = new ComplexNumber(7, 9);

            //initialize the length of the array
            myArraySize = 4;

            //initialize array with the corresponfing size
            MyComplexNumberArray = new ComplexNumber[myArraySize];

            //initialize array with elements
            MyComplexNumberArray[0] = complexNumber1;
            MyComplexNumberArray[1] = complexNumber2;
            MyComplexNumberArray[2] = complexNumber3;

            myElementsNumber = 3;

            MyComplexNumberList = new List<ComplexNumber> { complexNumber1, complexNumber2, complexNumber3 };
        }

        public void AddNewComplexNumber(ComplexNumber complexNumber)
        {
            MyComplexNumberList.Add(complexNumber);

            //Check if the number of elements is less than the assigned length of the array. If yes, add the element
            if (myElementsNumber < myArraySize)
            {
                MyComplexNumberArray[myElementsNumber] = complexNumber;
                myElementsNumber++;
            }
            else
            {
                //double the size of the array
                myArraySize = myArraySize * 2;

                //create a new array with the new size
                ComplexNumber[] myNewArray = new ComplexNumber[myArraySize];

                //copy elements from the old array to the new one
                for (int i = 0; i < MyComplexNumberArray.Length; i++)
                {
                    myNewArray[i] = MyComplexNumberArray[i];
                }

                //add the new element
                myNewArray[myElementsNumber] = complexNumber;
                myElementsNumber++;

                //Initialize the old array with the new one
                MyComplexNumberArray = myNewArray;
            }
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
