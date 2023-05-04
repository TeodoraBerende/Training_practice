using InternalProfiles.Model;

namespace InternalProfiles
{
  /// <summary>
  /// Somewhat similar to a CV ( Curriculum Vitae )
  /// </summary>
  public class Profile
  {
    public User CreatedBy { get; set; } = default!;

    public bool CanBeRemovedBy(User user)
    {
      return (user.IsAdmin || CreatedBy == user);

      //if (user.IsAdmin)
      //  return true;

      //if (CreatedBy == user)
      //  return true;

      //return false;
    }
  }
}
