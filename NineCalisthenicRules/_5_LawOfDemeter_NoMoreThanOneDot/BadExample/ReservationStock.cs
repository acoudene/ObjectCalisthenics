namespace NineCalisthenicRules._5_LawOfDemeter_NoMoreThanOneDot.BadExample;

public class ReservationStock
{
  public const int MaxReservation = 4;
  private readonly List<string> _bookedSpectacles = new List<string>();

  public List<string> BookedSpectacles { get => _bookedSpectacles; }
}
