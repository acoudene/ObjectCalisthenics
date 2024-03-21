namespace SolidPrinciples._3_LSP;

public class FidelityService
{
  public const string AccountIncremented = "Account incremented";
  public const string TakeAPremiumAccount = "Take a premium account";

  public string IncrementPoint(IBonusEligibleAccount account) => AccountIncremented;

  public string ProposePremiumAccount(IStandardAccount account) => TakeAPremiumAccount;

}
