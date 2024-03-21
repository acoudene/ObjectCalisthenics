namespace NineCalisthenicRules._9_TellDontAsk_NoGetterSetter;

public class GivenTellDontAskPrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
  {
    // Arrange
    var showRoomSeller = new ShowRoomSeller();

    // Act    
    showRoomSeller.BookASpectacle("LuffyReservation");
    showRoomSeller.BookASpectacle("NamiReservation");
    showRoomSeller.BookASpectacle("BoaReservation");
    showRoomSeller.BookASpectacle("KaidoReservation");

    // Assert
    Assert.True(showRoomSeller.IsFull());
    Assert.True(showRoomSeller.Capital == 40000);
  }
}