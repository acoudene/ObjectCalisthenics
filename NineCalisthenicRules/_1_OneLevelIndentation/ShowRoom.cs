using System;
using System.Text;

namespace NineCalisthenicRules._1_OneLevelIndentation;

public class ShowRoom
{
  public const int NbRanks = 2;
  public const int NbSeatsByRank = 2;

  public string AllocateSeats(List<Customer> customers)
  {
    // 0

    if (customers.Count != NbRanks * NbSeatsByRank)
      return "Show room not adapted";

    var buffer = new StringBuilder();

    AllocateSeatsRanks(buffer, customers);

    return buffer.ToString();
  }

  protected void AllocateSeatsRanks(StringBuilder buffer, List<Customer> customers)
  {
    if (customers.Count != NbRanks * NbSeatsByRank)
      return;

    // 0
    for (int rankIndex = 0; rankIndex < NbRanks; rankIndex++)
    {
      // 1
      AllocateSeat(buffer, customers, rankIndex);
    }
  }

  protected void AllocateSeat(StringBuilder buffer, List<Customer> customers, int rankIndex)
  {
    if (customers.Count != NbRanks * NbSeatsByRank)
      return;

    if (rankIndex < 0)
      return;

    // 0
    for (int seatIndexByRank = 0; seatIndexByRank < NbSeatsByRank; seatIndexByRank++)
    {
      // 1
      buffer.AppendLine($"{customers[rankIndex * NbSeatsByRank + seatIndexByRank].Name} is sitted at this rank {rankIndex} for seat {seatIndexByRank}");
    }
  }
}
