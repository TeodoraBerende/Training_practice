using BasicC_part6;
using BasicC_part6.Abstract;
using BasicC_part6.Challenge;
using BasicC_part6.Inheritance;
using BasicC_part6.Interface;
using BasicC_part6.Static;

internal class Program
{
    private static void Main(string[] args)
    {
      
        #region classInheritance
        //CLASS INHERITANCE
        Console.WriteLine("Class Inheritance" + Environment.NewLine);

        var person = new Person("John", "Smith", 26);

        var student = new Student("Emma", "Solace", 20, "Computer Science", 2);

        var courses = new List<string>() { "Computer science", "AI" };
        var teacher = new Teacher("Sophia", "Levine", 40, courses);

        person.ShowName();
        student.ShowName();
        teacher.ShowName();

        student.ShowFaculty();

        person.ShowAge();
        student.ShowAge();
        teacher.ShowAge();

        student.ChangeAge(21);
        student.Age = 21;

        #endregion
        
        #region abstractClass
        //ABSTRACT CLASS
        Console.WriteLine();
        Console.WriteLine("Abstract class" + Environment.NewLine);

        //Animal animal = new Animal();

        Cat cat = new Cat();
        Animal cat2 = new Cat();

        cat.MakeSound();
        cat.Eat();
        cat.Move();
        cat2.Move();

        var pigeon = new Pigeon();

        pigeon.MakeSound();
        pigeon.Eat();
        pigeon.Move();

        #endregion

        
        #region interface
        // INTERFACE
        Console.WriteLine();
        Console.WriteLine("Interface" + Environment.NewLine);

        DatabaseReader dbReader = new DatabaseReader("connection");
        FileReader fileReader = new FileReader("fileName1", "path1");

        IDataReader reader = new FileReader("fileName2", "path2");

        var data = reader.ReadData();
        data = fileReader.ReadData();

        //change file reader with database reader
        reader = dbReader;
        data = reader.ReadData();

        MyReader myReader = new MyReader(fileReader);
        fileReader.Write("Write Data");
        

        #endregion
        
        #region polymorphism
        //POLYMORPHISM
        Console.WriteLine();
        Console.WriteLine("Polymorphism" + Environment.NewLine);

        //Overriding
        person.ShowAge();
        student.ShowAge();
        teacher.ShowAge();

        //Overloading
        var myCalculator = new Calculator();
        Console.WriteLine(myCalculator.Sum(2, 7));
        Console.WriteLine(myCalculator.Sum(2, 7, 3));

        #endregion

        #region accessModifiers
        //ACCESS MOFIDIERS
        Console.WriteLine();
        Console.WriteLine("Access modifiers" + Environment.NewLine);

        student.Age = 21;
        student.ShowAge();

        #endregion
        
        #region static
        //STATIC CLASS & MEMBERS
        Console.WriteLine();
        Console.WriteLine("Static Class & members" + Environment.NewLine);

        Console.WriteLine(UtilityClass.ConvertStringToInt("45"));
        Console.WriteLine(UtilityClass.ConvertStringToInt("aaa"));
        Console.WriteLine(UtilityClass.Multiply(2,3));
        Console.WriteLine(UtilityClass.Multiply(2,3,10));
        Console.WriteLine(UtilityClass.GetCallTimes());

        Console.WriteLine();
        Console.WriteLine(FileReaderWithStatic.GetPath());
        var fileReaderStatic = new FileReaderWithStatic("test");
        Console.WriteLine(fileReaderStatic.ReadDataFromFile());

        FileReaderWithStatic fileReader1 = new FileReaderWithStatic("filename1");
        FileReaderWithStatic fileReader2 = new FileReaderWithStatic("filename2");

        fileReader1.ReadDataFromFile();
        fileReader2.ReadDataFromFile();

        Console.WriteLine(FileReaderWithStatic.GetCallTimes());

        // fileReaderStatic.GetPath()

        #endregion
        /*
        #region challenge
        //CHALLENGE

        var complexNumber1 = new ComplexNumber(1, 2);
        var complexNumber2 = new ComplexNumber(4, 6);
        var complexNumber3 = new ComplexNumber(7, 9);

        var myList = new MyList();
        myList.AddElement(complexNumber1);
        myList.AddElement(complexNumber2);
        myList.AddElement(complexNumber3);
        myList.AddElement(complexNumber3);
        myList.AddElement(complexNumber3);
        myList.ShowArray();

        Console.WriteLine("Delete");
        myList.DeleteFromPosition(2);
        myList.ShowArray();

        #endregion
        */
    }
}