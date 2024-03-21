namespace NineCalisthenicRules._4_FirstClassCollections.BadExample;

public class ShowRoomSeller
{
  private const int maxReservation = 4;
  private readonly List<string> _bookedSpectacles = new List<string>();

  public const string OpenReservation = "OpenReservation";
  public const string ClosedReservation = "ClosedReservation";

  public int _capital = 0;

  public string PromoteASpectacle()
  {
    if (IsFull())
      return ClosedReservation;

    return OpenReservation;
  }

  public void BookASpectacle(string bookingName)
  {
    if (IsFull())
      return;

    _bookedSpectacles.Add(bookingName);
    _capital += 10000;
  }

  public bool IsFull() => _bookedSpectacles.Count >= maxReservation;
}
