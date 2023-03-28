using Clarfications;

internal class Program
{
    private static void Main(string[] args)
    {
        //here we create a MenuItem object or a variable MenuItem
        var menuItemObject = new MenuItem("Carbonara", "Spaghetti", new List<string>() { "spaghetti", "pancetta", "eggs" }, 28);
        menuItemObject.Price= 100;



        //OBJECT class

        int i = 123;
        object o = i; //boxing

        o = 124;
        i = (int)o;  // unboxing
        decimal d = (decimal)o;
    }
}