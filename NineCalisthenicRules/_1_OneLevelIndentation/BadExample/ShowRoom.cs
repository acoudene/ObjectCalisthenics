using System.Text;

namespace NineCalisthenicRules._1_OneLevelIndentation.BadExample;

public class ShowRoom
{
  public const int NbRanks = 2;
  public const int NbSeatsByRank = 2;

  public string AllocateSeats(List<Customer> customers)
  {
    if (customers.Count != NbRanks * NbSeatsByRank)
      return "Show room not adapted";

    var buffer = new StringBuilder();

    // 0
    for (int rankIndex = 0; rankIndex < NbRanks; rankIndex++)
    {
      // 1
      for (int seatIndexByRank = 0; seatIndexByRank < NbSeatsByRank; seatIndexByRank++)
      {
        // 2
        buffer.AppendLine($"{customers[rankIndex * NbSeatsByRank + seatIndexByRank].Name} is sitted at this rank {rankIndex} for seat {seatIndexByRank}");
      }
    }

    return buffer.ToString();
  }
}
