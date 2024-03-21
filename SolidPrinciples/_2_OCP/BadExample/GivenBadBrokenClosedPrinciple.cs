namespace SolidPrinciples._2_OCP.BadExample;

public class GivenBadBrokenClosedPrinciple
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var showRoom = new ShowRoom();
    var customers = new List<object>() { new StandardCustomer(), new PremiumCustomer() };

    // Act
    var seats = customers.Select(customer => showRoom.AllocateSeat(customer));

    // Assert
    Assert.NotNull(seats);
    Assert.Contains(ShowRoom.AllocateStandardPlace, seats.ElementAt(0));
    Assert.Contains(ShowRoom.AllocatePremiumPlace, seats.ElementAt(1));
  }
}