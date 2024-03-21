namespace NineCalisthenicRules._4_FirstClassCollections;

public class GivenFirstClassCollectionsPrinciple
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