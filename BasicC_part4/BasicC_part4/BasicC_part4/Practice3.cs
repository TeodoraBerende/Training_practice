using System.Text;

namespace BasicC_part4
{
    public class Practice3
    {
        // Concatenates to String
        public void ConcatString()
        {
            string myString = "Hello";

            // strings which will be concataned
            List<string> stringToConcat = new List<string>() { " ", "World", "!", " ", "Nice", " ", "to", " ", "see", " ", "you", " ", "again", "." };

            foreach(string str in stringToConcat)
            {
                myString+= str;
            }

            Console.WriteLine(myString);
        }

        // Concatenates to StringBuilder
        public void ConcatStringBuilder()
        {
            StringBuilder myStringBuilder= new StringBuilder("Hello");

            // strings which will be concataned
            List<string> stringToConcat = new List<string>() { " ", "World", "!", " ", "Nice", " ", "to", " ", "see", " ", "you", " ", "again", "." };


            foreach (string str in stringToConcat)
            {
                myStringBuilder.Append(str);
            }

            Console.WriteLine(myStringBuilder);
        }
    }
}

