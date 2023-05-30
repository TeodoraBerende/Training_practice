using BasicNET_part3;
using BasicNET_part3.FileManager;

internal class Program
{
    private static void Main(string[] args)
    {/*
        #region LINQ
        Console.WriteLine("LINQ");
        var linq = new Linq();

        linq.UsingAdoNet();
        linq.UsingEntityFramework();
        linq.UsingList();
        #endregion
        
        #region FILES
        FileManager fileManager= new FileManager();
       // fileManager.ReadFile();
       // fileManager.WriteFile();

        var linq2 = new Linq();
        linq2.UsingEntityFramework();
        #endregion
        */
        
        #region SERIALIZATION
        var serializer = new Serialization();
        serializer.JsonSerialization();
        serializer.JsonDeserialization();

        serializer.BinarySerialization();
        serializer.BinaryDeserialization();
        #endregion
        
    }
}