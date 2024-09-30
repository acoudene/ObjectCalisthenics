namespace NineCalisthenicRules._3_PrimitiveAsObject;

public class GivenPrimitiveAsObjectPrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
  {
    // Arrange
    string email1 = "anthony.coudene@gmail.com";
    string email2 = "anthony.coudene@technidata-web.com";
    var customer1 = new Customer(email1);
    var customer2 = new Customer(new EmailType(email2));
    Action badAction = () => { new Customer("anthony"); };

    // Act
    customer1.Deconstruct(out EmailType emailType1);
    customer2.Deconstruct(out EmailType emailType2);

    // Assert
    Assert.Throws<ArgumentException>(() => badAction());
    Assert.Equal(email1, emailType1);
    Assert.Equal(email2, emailType2);
  }
}