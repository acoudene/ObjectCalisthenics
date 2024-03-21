namespace SolidPrinciples._5_DIP.BadExample;

public class MyOtherProduct
{
  public void DoOtherThing()
  {
    new TraceManager().TraceToDatabase("Do other thing");

    // If we introduce a new logger we will add to break Open/Closed principle for SOLID.
  }
}
