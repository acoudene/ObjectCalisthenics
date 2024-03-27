namespace SolidPrinciples._4_ISP.BadExample;

public class ManagerActivity : IActivity
{
  public void AssignTicket()
  {
    // Ok
  }

  public void CreateTicket()
  {
    // Ok
  }

  public void Develop()
  {
    // Not ok!!!
    throw new NotImplementedException();
  }
}
