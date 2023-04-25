namespace BasicC_part6.Challenge
{
    public class MyList
    {
        private ComplexNumber[] myArray { get; set; }

        private int myArraySize;
        private int myElementsNumber;

        public MyList()
        {
            //initialize the length of the array
            myArraySize = 4;

            //initialize array with the corresponfing size
            myArray = new ComplexNumber[myArraySize];          
        }

        public void AddElement(ComplexNumber complexNumber)
        {
            //Check if the number of elements is less than the assigned length of the array. If yes, add the element
            if (myElementsNumber < myArraySize)
            {
                myArray[myElementsNumber] = complexNumber;
                myElementsNumber++;
            }
            else
            {
                //double the size of the array
                myArraySize = myArraySize * 2;

                //create a new array with the new size
                ComplexNumber[] myNewArray = new ComplexNumber[myArraySize];

                //copy elements from the old array to the new one
                for (int i = 0; i < myArray.Length; i++)
                {
                    myNewArray[i] = myArray[i];
                }

                //add the new element
                myNewArray[myElementsNumber] = complexNumber;
                myElementsNumber++;

                //Initialize the old array with the new one
                myArray = myNewArray;
            }
        }

        public void DeleteFromPosition(int position)
        {
            if (position > myElementsNumber)
            {
                Console.WriteLine("The lenght of my list is smaller that your given position.");
                return;
            }
            for (int i = position - 1; i< myElementsNumber; i++)
            {
                myArray[i] = myArray[i+1];
            }

            myArray[myElementsNumber] = null;
            myElementsNumber --;            
        }  
        
        public void ShowArray()
        {
            for(int i = 0; i< myElementsNumber; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }
        }
    }
}
