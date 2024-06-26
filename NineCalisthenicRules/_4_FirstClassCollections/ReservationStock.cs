﻿namespace NineCalisthenicRules._4_FirstClassCollections;

public class ReservationStock
{
  public const int MaxReservation = 4;
  private readonly List<string> _bookedSpectacles = new List<string>();

  public void BookASpectacle(string bookingName)
  {
    if (IsFull())
      return;

    _bookedSpectacles.Add(bookingName);
  }

  public bool IsFull() => _bookedSpectacles.Count >= MaxReservation;
}
