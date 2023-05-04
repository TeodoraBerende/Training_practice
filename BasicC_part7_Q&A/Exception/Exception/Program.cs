using Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try
        {
            //something
        }
        catch (MyException ex) { }
        catch (Exception ex) { }

    }
}