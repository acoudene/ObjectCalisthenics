namespace NineCalisthenicRules._9_TellDontAsk_NoGetterSetter;

public class ShowRoomSeller
{
  private readonly ReservationStock _reservationStock = new ReservationStock();

  // Here we can tolerate get as public and always ask ourselves for set instead of more business method
  // See also disassembly here: https://sharplab.io/
  public int Capital { get; private set; } = 0;

  public void BookASpectacle(string bookingName)
  {
    _reservationStock.BookASpectacle(bookingName);
    Capital += 10000;
  }

  public bool IsFull() => _reservationStock.IsFull();
}
