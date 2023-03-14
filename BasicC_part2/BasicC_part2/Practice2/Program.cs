
public class Program
{
    private static void Main(string[] args)
    {
       

        Console.WriteLine("Problem 4");
        Problem4();
    }

    //
    // Find sum of natural numbers from 1 to 10.
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
    // Convert Decimal to Binary number system
    //
    public static void Problem2(int number)
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
    // Find sum of natural numbers from 1 to 10 using do-while.
    //
    public static void Problem3()
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
                sum += i; /// sum = sum+ i;
                //i++  // i= i+1
            }
            i++;
        }

        Console.WriteLine(sum);
        


    }

    /*
     * public static void Problem5()
    {
        var sum = 0;
        for (int i = 0; ; i++)
        {
           
        }
        Console.WriteLine(sum);
    }
    */

}