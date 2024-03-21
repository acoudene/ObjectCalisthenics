namespace SolidPrinciples._5_DIP;

public class MyProduct
{
  private readonly ILogger _logger;
  public MyProduct(ILogger logger)
  {
    _logger = logger ?? throw new ArgumentNullException(nameof(logger));
  }

  public void DoSomething()
  {
    _logger.Info("Do something");
  }
}
