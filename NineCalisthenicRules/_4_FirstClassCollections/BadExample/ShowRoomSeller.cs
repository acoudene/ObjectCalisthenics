namespace NineCalisthenicRules._4_FirstClassCollections.BadExample;

public class ShowRoomSeller
{
  public const int MaxReservation = 4;
  private readonly List<string> _bookedSpectacles = new List<string>();

  public const string OpenReservation = "OpenReservation";
  public const string ClosedReservation = "ClosedReservation";

  private int _capital = 0;
  public int Capital { get => _capital; }

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

  public bool IsFull() => _bookedSpectacles.Count >= MaxReservation;
}
