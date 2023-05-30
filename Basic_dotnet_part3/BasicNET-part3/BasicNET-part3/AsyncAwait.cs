namespace BasicNET_part3
{
    public class AsyncAwait
    {
        public async Task<int> SumAsync(int a, int b)
        {
            await Task.Delay(100);
            return a + b;
        }

        public async Task SomeMethodAsync()
        {
            await Task.Delay(100);
            Console.WriteLine("Async void method");
            throw new Exception("This method does nothing!");
        }
    }
}
