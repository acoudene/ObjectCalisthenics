namespace SolidPrinciples._3_LSP.BadExample;

public class FidelityAccount
{
  public string IncrementPoint(CustomerBase customer)
  {
    /// Break Liksov substitution because we have to modify this method each time we have a specific use case

    if (customer is StandardCustomer)
      return "No increment";

    return "Account incremented";
  }
}
