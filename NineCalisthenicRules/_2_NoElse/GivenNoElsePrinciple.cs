namespace NineCalisthenicRules._2_NoElse;

public class GivenNoElsePrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
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