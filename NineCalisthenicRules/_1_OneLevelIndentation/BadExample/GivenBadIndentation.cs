namespace NineCalisthenicRules._1_OneLevelIndentation.BadExample;

public class GivenBadIndentation
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    const string expectedSeats = "Luffy is sitted at this rank 0 for seat 0\r\nNami is sitted at this rank 0 for seat 1\r\nBoa is sitted at this rank 1 for seat 0\r\nKaido is sitted at this rank 1 for seat 1\r\n";
    var showRoom = new ShowRoom();
    var customers = new List<Customer>()
    {
      new Customer("Luffy"),
      new Customer("Nami"),
      new Customer("Boa"),
      new Customer("Kaido"),
    };

    // Act
    string seats = showRoom.AllocateSeats(customers);

    // Assert
    Assert.NotNull(seats);
    Assert.Equal(expectedSeats, seats);
  }
}