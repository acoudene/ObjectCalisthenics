namespace SolidPrinciples._2_OCP.BadExample;

public class ShowRoom
{
  /// Here, we will have to change the code each time we get a new kind of customer
  /// We will break Closed principle

  public string AllocateSeat(object customer) => customer switch
    {
      StandardCustomer _ => "Allocate a standard place",
      PremiumCustomer _ => "Allocate a premium place", 

      ///
      /// Add new lines for each kind of customers here (break Closed principle)
      /// 
      
      null => throw new ArgumentNullException(nameof(customer)),
      _ => throw new ArgumentException("Unknown type of customer", nameof(customer))
    };


}
