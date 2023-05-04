namespace InternalProfiles
{
  public class ProfileController
  {
    public ActionResult GetProfile(int id)
    {
      if (id < 0)
      {
        throw new ArgumentOutOfRangeException("id");
      }

      if (id == 0)
      {
        return new NotFound();
      }

      return new Ok();
    }
  }

  public class ActionResult { }
  public class NotFound : ActionResult { }
  public class Ok : ActionResult { }
}
