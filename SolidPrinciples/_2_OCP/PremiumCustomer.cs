namespace SolidPrinciples._2_OCP;

public class PremiumCustomer : CustomerBase
{
  public const string Premium = "premium";

  public override string GetAccess() => Premium;  
}
