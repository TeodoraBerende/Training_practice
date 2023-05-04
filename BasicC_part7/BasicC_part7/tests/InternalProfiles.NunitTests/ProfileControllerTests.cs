namespace InternalProfiles.NUnitTests
{
  public class ProfileControllerTests
  {
    [Test]
    public void GetProfile_IdIsZero_ReturnNotFound()
    {
      var controller = new ProfileController();

      var result = controller.GetProfile(0);

      Assert.That(result, Is.TypeOf<NotFound>());

      Assert.That(result, Is.InstanceOf<NotFound>());
    }

    [Test]
    public void GetProfile_IdIsNotZero_ReturnOk()
    {
      var controller = new ProfileController();

      var result = controller.GetProfile(1);

      Assert.That(result, Is.TypeOf<Ok>());
    }

    [Test]
    public void GetProfile_IdIsLessThanZero_ThrowArgumentOutOfRangeException()
    {
      var controller = new ProfileController();

      var result = () => controller.GetProfile(-1);

      Assert.That(result, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
    }
  }
}
