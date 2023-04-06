using Practice2;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var myList = new ComplexNumberList();
        int menuItem = -1;

        while (menuItem != 0)
        {
            PrintMenu();
            Console.WriteLine("Please enter a value:");
            int.TryParse(Console.ReadLine(), out menuItem);
            switch (menuItem)
            {
                case 1:
                    myList.AddNewComplexNumber(new ComplexNumber(0, 1));
                    break;
                case 2:
                    Console.WriteLine("Delete");
                    myList.DeleteFromPosition(1);
                    break;
                case 0:
                    return;
                default: 
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
    public static void PrintMenu()
    {
        Console.WriteLine("1 - Add a new number ");
        Console.WriteLine("2 - Delete from position ");
        Console.WriteLine("0 - Exit ");

    }
}