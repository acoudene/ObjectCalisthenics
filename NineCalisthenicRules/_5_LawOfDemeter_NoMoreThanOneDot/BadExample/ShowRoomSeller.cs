namespace NineCalisthenicRules._5_LawOfDemeter_NoMoreThanOneDot.BadExample;

public class ShowRoomSeller
{
  public ReservationStock ReservationStock { get; } = new ReservationStock();
  
  public int Capital { get; set; } = 0;
}
