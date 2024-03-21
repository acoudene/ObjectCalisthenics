namespace SolidPrinciples._4_ISP.BadExample;

public class DeveloperActivity : IActivity
{
  public void AssignJiraTicket()
  {
    // Not ok!!!
    throw new NotImplementedException();
  }

  public void CreateJiraTicket()
  {
    // Not ok!!!
    throw new NotImplementedException();
  }

  public void Develop()
  {
    // Ok
  }
}
