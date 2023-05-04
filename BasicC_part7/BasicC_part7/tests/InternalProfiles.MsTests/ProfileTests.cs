namespace InternalProfiles.MsTests
{
  [TestClass]
  public class ProfileTests
  {
    [TestMethod]
    public void CanBeRemovedBy_UserIsAdmin_ReturnsTrue()
    {
      // arrange
      var profile = new Profile();

      // act
      var result = profile.CanBeRemovedBy(new User() { IsAdmin = true });

      // assert
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeRemovedBy_UserIsTheSame_ReturnsTrue()
    {
      // arrange
      var user = new User();
      var profile = new Profile() { CreatedBy = user };

      // act
      var result = profile.CanBeRemovedBy(user);

      // assert
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeRemovedBy_UserIsDifferent_ReturnsFalse()
    {
      // arrange
      var user = new User();
      var profile = new Profile() { CreatedBy = user };

      // act
      var result = profile.CanBeRemovedBy(new User());

      // assert
      Assert.IsFalse(result);
    }
  }
}