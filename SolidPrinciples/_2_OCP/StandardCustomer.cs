namespace SolidPrinciples._2_OCP;

public class StandardCustomer : CustomerBase
{
  public const string Standard = "standard";

  public override string GetAccess() => Standard;
}
