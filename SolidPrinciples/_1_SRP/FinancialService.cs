namespace SolidPrinciples._1_SRP;

public class FinancialService
{
  private long _capital;

  public FinancialService(long capital)
  {
    _capital = capital;
  }

  public void EarnMoney(uint money) => _capital += money;
  public void SpendMoney(uint money) => _capital -= money;
  public bool CanBuy(int price) => price <= _capital;
}
