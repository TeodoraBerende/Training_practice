using BasicC_part4;

internal class Program
{
    private static void Main(string[] args)
    {
        //Practice 3
        Practice3 practice3 = new Practice3();

        Console.WriteLine("Using string");
        practice3.ConcatString();

        Console.WriteLine();

        Console.WriteLine("Using StringBuilder");
        practice3.ConcatStringBuilder();
    }
}