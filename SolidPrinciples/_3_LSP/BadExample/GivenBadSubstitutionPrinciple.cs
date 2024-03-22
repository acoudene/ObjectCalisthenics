namespace SolidPrinciples._3_LSP.BadExample;

public class GivenBadSubstitutionPrinciple
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var premiumCustomer = new PremiumCustomer();
    var fidelityService = new FidelityService();

    // Act
    string bonusPoints = fidelityService.IncrementPoint(premiumCustomer);
    
    // Assert
    Assert.Equal(FidelityService.AccountIncremented, bonusPoints);
  }
}