namespace SolidPrinciples._1_SRP.BadExample;

public class Customer
{
    public string Name { get; init; }

    // This attribute should not be managed internally by a customer   
    private long _capital;

    public Customer(string name, long capital)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        _capital = capital;
    }

    public void EarnMoney(uint money) => _capital += money;
    public void SpendMoney(uint money) => _capital -= money;
    public bool CanBuy(int price) => price <= _capital;

}
