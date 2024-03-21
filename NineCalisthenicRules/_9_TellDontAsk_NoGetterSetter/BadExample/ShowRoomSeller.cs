namespace NineCalisthenicRules._9_TellDontAsk_NoGetterSetter.BadExample;

public class ShowRoomSeller
{
  public ReservationStock ReservationStock { get; } = new ReservationStock();
  
  public int Capital { get; set; } = 0;
}
