using BasicNET_part3.Models;

namespace BasicNET_part3.FileManager
{
    public class FileManager
    {
        static readonly string path = "C:\\Users\\tberende\\OneDrive - ENDAVA\\Course testing\\BasicNET-part3\\BasicNET-part3\\FileManager\\";
        static readonly string filename = "myFile.txt";

        public void ReadFile()
        {
            string textFile = path + filename;
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string
                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);
            }

            if (File.Exists(textFile))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }

            if (File.Exists(textFile))
            {
                List<Department> departments = new List<Department>();
                // Read file using StreamReader. Reads file line by line
                using (StreamReader file = new StreamReader(textFile))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        if (ln.Contains("|"))
                        {
                            var properties = ln.Split('|');
                            int.TryParse(properties[0], out var id);
                            var department = new Department(id, properties[1]);
                            departments.Add(department);
                        }
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                }
                Console.WriteLine($"There are {departments.Count} departments.");
            }

        }

        public void WriteFile()
        {
            string textFile = path + "myNewFile.txt";

            string[] fruits = { "apple", "strawberry", "banana", "pear" };
            // Creates a new file, writes the specified string to the file, and then closes the file.
            // If the target file already exists, it is overwritten.
            File.WriteAllLines(textFile, fruits);
            
            // Creates a new file, writes the specified string to the file, and then closes the file.
            // If the target file already exists, it is overwritten.
            string someText = "This is the last course of C# training: By Developers, For Testers";
            File.WriteAllText(textFile, someText);

            // Creates a new file, writes the specified string to the file, and then closes the file.
            // If the target file already exists, it is overwritten.
            using (StreamWriter writer = new StreamWriter(textFile))
            {
                writer.WriteLine("David Smith");
                writer.WriteLine("Samantha Cooper");
                writer.WriteLine("Amelia Lee");
                writer.WriteLine("John Simpson");
                writer.WriteLine("Emma Trivedi");
                writer.Close();
            }

            // Append text to an existing file named "myFile.txt".
            string myFile = path + filename;

            //Opens a file, appends the specified string to the file, and then closes the file.
            //If the file does not exist, this method creates a file, writes the specified string to the file, then closes the file.
            File.AppendAllText(myFile, "5 | Project managing");

            //If the file exists, it will append the text to the end of it.
            //If the file does not exist, this constructor creates a new file.
            using (StreamWriter writer = new StreamWriter(myFile, true))
            {
                writer.WriteLine();
                writer.WriteLine("6 | Project managing2");
                writer.Close();
            }

        }
    }
}
   
