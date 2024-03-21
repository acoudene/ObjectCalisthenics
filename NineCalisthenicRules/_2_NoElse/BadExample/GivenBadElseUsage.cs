namespace NineCalisthenicRules._2_NoElse.BadExample;

public class GivenBadElseUsage
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var showRoom = new ShowRoom();
    var customer = new Customer("Nami");

    // Act
    string seat = showRoom.AllocateSeat(customer);

    // Assert
    Assert.NotNull(seat);
    Assert.Equal(ShowRoom.BestSeat, seat);
  }
}