namespace BasicC_part6.Static
{
    public static class UtilityClass
    {
        public static int callTimes = 0;
        public static string directoryPath = "my folder";

        public static int ConvertStringToInt(string number)
        {
            callTimes++;
            var response = int.TryParse(number, out var result);
            if (!response)
            {
                Console.WriteLine($"The string {number} is not a number.");
                return 0;
            }
            return result;
        }

        public static int Multiply(int x, int y)
        {
            callTimes++;
            return x * y;
        }
        public static int Multiply(int x, int y, int z)
        {
            callTimes++;
            return x * y * z;
        }

        public static int GetCallTimes()
        {
            return callTimes;
        }
    }
}
