using CustomMath.Abstractions;

namespace CustomMath.Services
{
  public class FileService : IFileService
  {
    public void AppendLine(string path, string content)
    {
      File.AppendAllLines(path, new string[] { content });
    }

    public string ReadMaxMessage()
    {
      var message = File.ReadAllText(@"C:\temp\inputs\MaxMessage.txt");

      return message;
    }
  }
}
