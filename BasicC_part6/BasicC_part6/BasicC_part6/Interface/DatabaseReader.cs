namespace BasicC_part6.Interface
{
    public class DatabaseReader : IDataReader
    {
        private string _connectionString;

        public DatabaseReader(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public string ReadData()
        {
            Console.WriteLine("Read data with DatabaseReader");
            return "DB";
        }
    }
}

