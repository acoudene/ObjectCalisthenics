namespace SolidPrinciples._2_OCP;

public class GivenOpenClosedPrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
  {
    // Arrange
    var showRoom = new ShowRoom();
    var customers = new List<CustomerBase>() { new StandardCustomer(), new PremiumCustomer() };

    // Act
    var seats = customers.Select(customer => showRoom.AllocateSeat(customer));

    // Assert
    Assert.NotNull(seats);
    Assert.Contains(StandardCustomer.Standard, seats.ElementAt(0));
    Assert.Contains(PremiumCustomer.Premium, seats.ElementAt(1));
  }
}