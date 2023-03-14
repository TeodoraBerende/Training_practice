
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Problem 1");
        Problem1();

        Console.WriteLine("Problem 2");
        Problem2();

        Console.WriteLine("Problem 3");
        Problem3(17);

        Console.WriteLine("Problem 4");
        Problem4();       
    }

    //
    // Find sum of natural numbers from 1 to 10.
    // It should have been the sum but if I let it like this you can play with the difference between while and do-while. (Problem 1 and 2)
    //
    public static void Problem1()
    {
        int sum = 0;
        int n = 1;
        while (n < 0)
        {
            sum = sum + n;
            n++;
        }

        Console.WriteLine(sum);
    }

    //
    // Find sum of natural numbers from 1 to 10 using do-while.
    //
    public static void Problem2()
    {
        int sum = 0;
        int n = 1;
        do
        {
            sum = sum + n;
            n++;

        } while (n < 0);
    }


    //
    // Convert Decimal to Binary number system
    //
    public static void Problem3(int number)
    {
        int binary =  0;
        int temp = 1;    

        while (number > 0)
        {
            int r = number % 2;

            temp = temp *10 + r;

            number /= 2;
        }
        while(temp > 0)
        {
            binary = binary*10 + temp%10;

            temp = temp/10;
        }
        binary = binary / 10;

        Console.WriteLine(binary);
    }

    
    //
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
    // The sum of these multiples is 23.
    //
    //
    public static void Problem4()
    {
        int sum = 0, i = 0;

        while (i < 10)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i; 
            }
            i++;
        }

        Console.WriteLine(sum);
        
    }

    /*
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
    */

}