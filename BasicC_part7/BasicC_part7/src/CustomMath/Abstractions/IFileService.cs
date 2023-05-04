namespace CustomMath.Abstractions
{
  public interface IFileService
  {
    void AppendLine(string path, string content);

    string ReadMaxMessage();
  }
}
