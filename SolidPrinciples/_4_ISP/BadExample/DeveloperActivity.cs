namespace SolidPrinciples._4_ISP.BadExample;

public class DeveloperActivity : IActivity
{
  public void AssignTicket()
  {
    // Not ok!!!
    throw new NotImplementedException();
  }

  public void CreateTicket()
  {
    // Not ok!!!
    throw new NotImplementedException();
  }

  public void Develop()
  {
    // Ok
  }
}
