namespace NineCalisthenicRules._5_LawOfDemeter_NoMoreThanOneDot.BadExample;

public class GivenBadMoreThanOneDotUsage
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var showRoomSeller = new ShowRoomSeller();
    List<string> bookedSpectacles = showRoomSeller.ReservationStock.BookedSpectacles;

    // Act    
    bookedSpectacles.Add("LuffyReservation");
    showRoomSeller.Capital += 10000;
    bookedSpectacles.Add("NamiReservation");
    showRoomSeller.Capital += 10000;
    bookedSpectacles.Add("BoaReservation");
    showRoomSeller.Capital += 10000;
    bookedSpectacles.Add("KaidoReservation");
    showRoomSeller.Capital += 10000;

    // Assert
    Assert.True(bookedSpectacles.Count >= ReservationStock.MaxReservation);
    Assert.True(showRoomSeller.Capital == 40000);
  }
}