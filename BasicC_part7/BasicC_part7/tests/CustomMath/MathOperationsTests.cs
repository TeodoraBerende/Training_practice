using CustomMath.Abstractions;
using Moq;

namespace CustomMath
{
  public class MathOperationsTests
  {
    private MathOperations _mathOperations;
    private Mock<IFileService> _mockFileService;

    [SetUp]
    public void Setup()
    {
      _mockFileService = new Mock<IFileService>();
      _mockFileService.Setup(s => s.ReadMaxMessage()).Returns("");

      _mathOperations = new MathOperations(_mockFileService.Object);
    }

    [Test]
    public void Add_WhenCalled_ReturnTheSumOfArguments()
    {
      var result = _mathOperations.Add(5, 6);

      Assert.That(result, Is.EqualTo(11));
    }

    [Test]
    [TestCase(6, 5, 6)]
    [TestCase(4, 8, 8)]
    [TestCase(3, 3, 3)]
    public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
    {
      var result = _mathOperations.Max(a, b);
      _mockFileService.Verify(s => s.AppendLine(It.IsAny<string>(), It.IsAny<string>()));

      Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
    {
      var result = _mathOperations.Max(7, 5);

      Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
    {
      var result = _mathOperations.Max(5, 7);

      Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void Max_ArgumentsAreTheSame_ReturnSameArgument()
    {
      var result = _mathOperations.Max(7, 7);

      Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void GetEvenNumbers_LimitIsGreaterThanZero_ReturnEvenNumbersUpToLimit()
    {
      var result = _mathOperations.GetEvenNumbers(5);

      Assert.That(result, Is.Not.Empty);
      Assert.That(result.Count(), Is.EqualTo(3));

      Assert.That(result, Does.Contain(0));
      Assert.That(result, Does.Contain(2));
      Assert.That(result, Does.Contain(4));

      Assert.That(result, Is.EquivalentTo(new[] { 0, 2, 4 }));
    }
  }
}