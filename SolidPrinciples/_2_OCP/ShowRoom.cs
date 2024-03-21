namespace SolidPrinciples._2_OCP;

public class ShowRoom
{
  /// Even if we add new kind of customer then this code could stay Closed.

  public string AllocateSeat(CustomerBase customer) => $"Allocate a {customer.GetAccess()} place";      

}
