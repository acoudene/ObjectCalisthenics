namespace SolidPrinciples._1_SRP;

public class Customer
{
  public string Name { get; init; }

  private readonly FinancialService _financialService;

  public Customer(string name, FinancialService financialService)
  {
    Name = name ?? throw new ArgumentNullException(nameof(name));
    _financialService = financialService ?? throw new ArgumentNullException(nameof(financialService));
  }

  public void EarnMoney(uint money) => _financialService.EarnMoney(money);
  public void SpendMoney(uint money) => _financialService.SpendMoney(money);
  public bool CanBuy(int price) => _financialService.CanBuy(price);
}


