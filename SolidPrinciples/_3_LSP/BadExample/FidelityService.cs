namespace SolidPrinciples._3_LSP.BadExample;

public class FidelityService
{
  public const string NoIncrement = "No increment";
  public const string AccountIncremented = "Account incremented";
  public const string TakeAPremiumAccount = "Take a premium account";

  public string IncrementPoint(CustomerBase customer)
  {
    /// Break Liksov substitution because we have to modify this method each time we have a specific use case

    if (customer is StandardCustomer)
      return NoIncrement;

    return AccountIncremented;
  }
}
