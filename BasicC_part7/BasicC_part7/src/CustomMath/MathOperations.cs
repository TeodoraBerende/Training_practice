using CustomMath.Abstractions;

namespace CustomMath
{
  public class MathOperations
  {
    private readonly IFileService _fileService;

    public MathOperations(IFileService fileService)
    {
      _fileService = fileService;
    }

    public int Add(int a, int b)
    {
      return a + b;
    }

    public int Max(int a, int b)
    {
      var result = (a > b) ? a : b;

      var maxMessage = _fileService.ReadMaxMessage();

      _fileService.AppendLine(@"C:\temp\max-log.txt", string.Format(maxMessage, result));

      return result;
    }

    public IEnumerable<int> GetEvenNumbers(int limit)
    {
      for (var i = 0; i <= limit; i++)
      {
        if (i % 2 == 0)
        {
          yield return i;
        }
      }
    }
  }
}
