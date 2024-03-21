namespace SolidPrinciples._4_ISP;

public class TechLeadActivity : IDeveloperActivity, IManagerActivity
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
