namespace NineCalisthenicRules._5_LawOfDemeter_NoMoreThanOneDot;

public class ShowRoomSeller
{
  private readonly ReservationStock _reservationStock = new ReservationStock();

  public int Capital { get; private set; } = 0;

  public void BookASpectacle(string bookingName)
  {    
    _reservationStock.BookASpectacle(bookingName);
    Capital += 10000;
  }

  public bool IsFull() => _reservationStock.IsFull();
}
