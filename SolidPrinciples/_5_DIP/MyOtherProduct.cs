namespace SolidPrinciples._5_DIP;

public class MyOtherProduct
{
  private readonly ILogger _logger;
  public MyOtherProduct(ILogger logger)
  {
    _logger = logger ?? throw new ArgumentNullException(nameof(logger));
  }

  public void DoOtherThing()
  {
    _logger.Info("Do other thing");
  }
}
