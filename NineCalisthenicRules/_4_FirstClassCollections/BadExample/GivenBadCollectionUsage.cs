namespace NineCalisthenicRules._4_FirstClassCollections.BadExample;

public class GivenBadCollectionUsage
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var showRoomSeller = new ShowRoomSeller();

    // Act
    showRoomSeller.BookASpectacle("LuffyReservation");
    showRoomSeller.BookASpectacle("NamiReservation");
    showRoomSeller.BookASpectacle("BoaReservation");
    showRoomSeller.BookASpectacle("KaidoReservation");

    // Assert
    Assert.Equal(ShowRoomSeller.ClosedReservation, showRoomSeller.PromoteASpectacle());
  }
}