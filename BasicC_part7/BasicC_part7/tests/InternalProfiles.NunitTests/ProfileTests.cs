using InternalProfiles.Model;

namespace InternalProfiles.NunitTests
{
  //[TestFixture]
  public class ProfileTests
  {
    [Test]
    public void CanBeRemovedBy_UserIsAdmin_ReturnsTrue()
    {
      // arrange
      var profile = new Profile();

      // act
      var result = profile.CanBeRemovedBy(new User() { IsAdmin = true });

      // assert
      Assert.That(result, Is.True);
    }
  }
}