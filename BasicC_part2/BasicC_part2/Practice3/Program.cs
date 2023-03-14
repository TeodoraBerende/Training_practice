internal class Program
{
    private static void Main(string[] args)
    {/*
        int number = 190;
        var stringNumber = number.ToString();
        Console.WriteLine(stringNumber + " is my number.");

        int[] array = new int[] { 8, 15, 7, 10, 33, 4, 9 };
        Console.WriteLine("Length " + array.Length);
        Console.WriteLine("Max " + array.Max());
        Console.WriteLine("Min " + array.Min()); 
        Console.WriteLine();*

        string hello = "hello world!";
        string myString;

        hello[0] = hello[0].ToString().ToUpper();


        Console.WriteLine(myString);
        Console.WriteLine(hello.ToLower());
        Console.WriteLine();

        Console.WriteLine("ConvertNumberToString");
        ConvertNumberToString();
        Console.WriteLine();*/

        Console.WriteLine("ConvertStringToNumber");
        ConvertStringToNumber();
    }

    public static void ConvertNumberToString()
    {
        int number1 = 2090;
        decimal number2 = (decimal)10.56;

        Console.Write("Number 1 " + number1.ToString());
        Console.WriteLine("Number 2 " + number2.ToString());
    }

    public static void ConvertStringToNumber()
    {
        string number1 = "12";
        string number2 = "10.56";
        /*
        try
        {
            int numVal1 = int.Parse(number1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try { 
        decimal numVal2 = Decimal.Parse(number2);
           // bool.tr

            Console.WriteLine("Int " + numVal1);
            Console.WriteLine("Decimal " + numVal2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine();*/



        Console.WriteLine("TryParse");

        int myInt;
        decimal myDecimal;
        bool result = int.TryParse(number1, out myInt);
        bool result2 = Decimal.TryParse(number2, out myDecimal);

        if (result && result2)
        {
            Console.WriteLine("Int " + myInt + " MyDecimal "+ myDecimal);
        }
        else
        {
            Console.WriteLine("String could not be parsed.");
        }

       
    }
}