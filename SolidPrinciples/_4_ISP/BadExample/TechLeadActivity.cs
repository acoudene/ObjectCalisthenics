namespace SolidPrinciples._4_ISP.BadExample;

public class TechLeadActivity : IActivity
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
    // Ok
  }
}
