namespace BasicC_part6.Interface
{
    public class FileReader : IDataReader, IDataWriter
    {
        private string _fileName;
        private string _path;

        public FileReader(string fileName, string path)
        {
            _fileName = fileName;
            _path = path;
        }

        public string ReadData()
        {
            Console.WriteLine("Read data with FileReader");
            return "file";
        }

        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}
