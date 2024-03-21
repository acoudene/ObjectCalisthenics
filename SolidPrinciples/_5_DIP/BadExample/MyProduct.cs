namespace SolidPrinciples._5_DIP.BadExample;

public class MyProduct
{
  public void DoSomething()
  {
    new TraceManager().TraceToFile("Do something");

    // If we introduce a new logger we will add to break Open/Closed principle for SOLID.
  }
}
