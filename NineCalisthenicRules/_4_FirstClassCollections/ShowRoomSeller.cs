namespace NineCalisthenicRules._4_FirstClassCollections;

public class ShowRoomSeller
{
  private readonly ReservationStock _reservationStock = new ReservationStock();

  public const string OpenReservation = "OpenReservation";
  public const string ClosedReservation = "ClosedReservation";

  private int _capital = 0;
  public int Capital { get => _capital; }

  public string PromoteASpectacle()
  {
    if (_reservationStock.IsFull())
      return ClosedReservation;

    return OpenReservation;
  }

  public void BookASpectacle(string bookingName)
  {    
    _reservationStock.BookASpectacle(bookingName);
    _capital += 10000;
  }
}
