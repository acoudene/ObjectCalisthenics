namespace SolidPrinciples._3_LSP;

public class GivenLiskovSubstitutionPrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
  {
    // Arrange
    var standardCustomer = new StandardCustomer();
    var premiumCustomer = new PremiumCustomer();
    var fidelityService = new FidelityService();

    // Act
    string bonusPoints = fidelityService.IncrementPoint(premiumCustomer);
    string proposal = fidelityService.ProposePremiumAccount(standardCustomer);

    // Assert
    Assert.Equal(FidelityService.AccountIncremented, bonusPoints);
    Assert.Equal(FidelityService.TakeAPremiumAccount, proposal);
  }
}