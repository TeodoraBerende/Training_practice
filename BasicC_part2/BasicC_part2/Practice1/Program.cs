
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Problem 1");
        Problem1(2, 2);

        Console.WriteLine("Problem 2");
        Problem2();

        Console.WriteLine("Problem 3");
        Problem3();

        Console.WriteLine("Problem 4");
        Problem4();

        Console.WriteLine("Problem 5");
        Problem5();


        // the diference between division and modulus(modulus = finding the rest of a division)
        int number = 5;
        Console.WriteLine(number / 3);//division
        Console.WriteLine(number % 3);//modulus

    }

    //
    // Find the maximum between 2 numbers
    //
    public static void Problem1(int number1, int number2)
    {
        if (number1 > number2)
        {
            Console.WriteLine("The maximum is " + number1);
        }
        else if(number1 == number2)
        {
            Console.WriteLine("The numbers are equal "+ number1);
        }
        else
        {
            Console.WriteLine("The maximum is " + number2);
        }
    }

    //
    // Print all even numbers from 1 to 20
    //
    public static void Problem2()
    {
        for(int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    //
    // Find largest number in array.
    //
    public static void Problem3()
    {
        int[] array = new int[] { 8, 15, 7, 10, 33, 4, 9 };
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                max = array[i];
            }
        }
        Console.WriteLine(max);
    }

    //
    // Print all odd numbers from 20 to 1
    //
    public static void Problem4()
    {
        for(int i=20; i >= 1; i--)
        {
            if(i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }
    }


    //
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
    // The sum should be multiples is 23.
    //
    public static void Problem5()
    {
        var sum = 0;
        for (int i = 0; i < 10; i++) // i++ is equivalent i= i+1
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i; //is equivalent to  sum = sum+ i;                
            }
        }
        Console.WriteLine(sum);
    }
}