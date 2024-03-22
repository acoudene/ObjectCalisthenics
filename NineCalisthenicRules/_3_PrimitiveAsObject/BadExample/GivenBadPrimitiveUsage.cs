using System.Text.RegularExpressions;

namespace NineCalisthenicRules._3_PrimitiveAsObject.BadExample;

public class GivenBadPrimitiveUsage
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var customer = new Customer("anthony.coudene@gmail.com");

    // Act
    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    Match match = regex.Match(customer.Email);

    // Assert
    Assert.True(match.Success);
  }
}