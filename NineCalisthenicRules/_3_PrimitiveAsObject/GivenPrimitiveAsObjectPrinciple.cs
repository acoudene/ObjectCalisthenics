namespace NineCalisthenicRules._3_PrimitiveAsObject;

public class GivenPrimitiveAsObjectPrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
  {
    // Arrange
    EmailType email = "anthony.coudene@gmail.com";
    Action badAction = () => { EmailType email = "anthony"; };

    // Act

    // Assert
    Assert.Throws<ArgumentException>(() => badAction());
  }
}