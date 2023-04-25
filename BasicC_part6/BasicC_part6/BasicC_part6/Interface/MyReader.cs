namespace BasicC_part6.Interface
{
    public class MyReader
    {
        public IDataReader DataReader { get; set; }
        public MyReader(IDataReader reader)
        {
            DataReader = reader;
            Console.WriteLine("Calling ReadData from MyReader");
            DataReader.ReadData();
        }
    }
}
