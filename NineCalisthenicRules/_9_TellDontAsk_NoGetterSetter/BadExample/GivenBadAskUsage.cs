namespace NineCalisthenicRules._9_TellDontAsk_NoGetterSetter.BadExample;

public class GivenBadAskUsage
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var showRoomSeller = new ShowRoomSeller();
    var stock = showRoomSeller.ReservationStock;

    // Act    
    stock.BookASpectacle("LuffyReservation");
    showRoomSeller.Capital += 10000;
    stock.BookASpectacle("NamiReservation");
    showRoomSeller.Capital += 10000;
    stock.BookASpectacle("BoaReservation");
    showRoomSeller.Capital += 10000;
    stock.BookASpectacle("KaidoReservation");
    showRoomSeller.Capital += 10000;

    // Assert
    Assert.True(stock.IsFull());
    Assert.True(showRoomSeller.Capital == 40000);
  }
}