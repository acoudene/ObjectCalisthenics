namespace SolidPrinciples._1_SRP.BadExample;

public class GivenBadResponsibility
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    const long capital = 10000;
    const string customerName = "Luffy";
    var customer = new Customer(customerName, capital);
    const int priceOfKatana = 2000;
    
    // Act
    bool canBuyKatana = customer.CanBuy(priceOfKatana);
    customer.TraceConsoleDebug("Do something");

    // Assert
    Assert.True(canBuyKatana);
  }
}