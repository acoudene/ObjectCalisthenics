namespace SolidPrinciples._4_ISP.BadExample;

public class ManagerActivity : IActivity
{
  public void AssignJiraTicket()
  {
    // Ok
  }

  public void CreateJiraTicket()
  {
    // Ok
  }

  public void Develop()
  {
    // Not ok!!!
    throw new NotImplementedException();
  }
}
