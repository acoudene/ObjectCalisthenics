namespace SolidPrinciples._1_SRP;

public class GivenSingleResponsibilityPrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
  {
    // Arrange
    const long capital = 10000;
    var financialService = new FinancialService(capital);
    const string customerName = "Luffy";
    var customer = new Customer(customerName, financialService);
    const int priceOfKatana = 2000;
    
    // Act
    bool canBuyKatana = customer.CanBuy(priceOfKatana);

    // Assert
    Assert.True(canBuyKatana);
  }
}