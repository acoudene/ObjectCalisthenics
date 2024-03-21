namespace NineCalisthenicRules._2_NoElse;

public class ShowRoom
{
  public const string NoAllocatedSeat = "No allocated seat";
  public const string BestSeat = "Best seat";
  public const string StandardSeat = "Standard seat";
  public string AllocateSeat(Customer customer)
  {
    string allocatedSeat;

    if (customer is null)
    {
      allocatedSeat = NoAllocatedSeat;
    }
    else
    {
      if (customer.Name.Equals("Nami"))
      {
        allocatedSeat = BestSeat;
      }
      else
      {
        allocatedSeat = StandardSeat;
      }
    }

    return allocatedSeat;
  }
}
