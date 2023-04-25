namespace BasicC_part6.Static
{
    public class FileReaderWithStatic
    {
        //show the warning for initializing in the constructor
        static string path = "C:\\Documents";

        static int callTimes = 0;

        public string Filename { get; set; }
            
        public FileReaderWithStatic(string filename) {
            Filename = filename;
        }
        
        public static string GetPath()
        {
            //try accessing filename
            callTimes++;
            return path;          
        }

        public string ReadDataFromFile()
        {
            callTimes++;
            Console.WriteLine("Filename " + Filename);
            return "Data";
        }
        public static int GetCallTimes()
        {
            return callTimes;
        }

    }
}
