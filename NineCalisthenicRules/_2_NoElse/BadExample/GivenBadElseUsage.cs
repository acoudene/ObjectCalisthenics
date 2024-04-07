namespace NineCalisthenicRules._2_NoElse.BadExample;

public class GivenBadElseUsage
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var showRoom = new ShowRoom();
    var customer = new Customer("Nami");
    var customer2 = new Customer("Luffi");
    var customer3 = new Customer("TheRock");

    // Act
    string seat = showRoom.AllocateSeat(customer);
    string seat2 = showRoom.AllocateSeat(customer2);
    string seat3 = showRoom.AllocateSeat(customer3);

    // Assert
    Assert.NotNull(seat);
    Assert.Equal(ShowRoom.BestSeat, seat);
    Assert.Equal(ShowRoom.NoAllocatedSeat, seat2);
    Assert.Equal(ShowRoom.StandardSeat, seat3);
  }
}