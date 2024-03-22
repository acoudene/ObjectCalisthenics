namespace NineCalisthenicRules._2_NoElse;

public class ShowRoom
{
  public const string NoAllocatedSeat = "No allocated seat";
  public const string BestSeat = "Best seat";
  public const string StandardSeat = "Standard seat";
  public string AllocateSeat(Customer customer)
  {    
    if (customer is null)      
    { 
      return NoAllocatedSeat;
    }

    if (customer.Name.Equals("Nami"))
    {
      return BestSeat;
    }
      
    return StandardSeat;      
  }
}
