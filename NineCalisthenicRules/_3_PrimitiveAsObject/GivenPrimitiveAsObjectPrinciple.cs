namespace NineCalisthenicRules._3_PrimitiveAsObject;

public class GivenPrimitiveAsObjectPrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
  {
    // Arrange
    var customer = new Customer("anthony.coudene@gmail.com");
    var customer2 = new Customer(new EmailType("anthony.coudene@technidata-web.com"));
    Action badAction = () => { new Customer("anthony"); };

    // Act

    // Assert
    Assert.Throws<ArgumentException>(() => badAction());
  }
}