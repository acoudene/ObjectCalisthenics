using System.Text.RegularExpressions;

namespace NineCalisthenicRules._3_PrimitiveAsObject.BadExample;

public class GivenBadPrimitiveUsage
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    var customer = new Customer("anthony.coudene@gmail.com");
    var customer2 = new Customer("anthony.coudene@technidata-web.com");
    var customer3 = new Customer("anthony");

    // Act
    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    Match match = regex.Match(customer.Email);
    Match match2 = regex.Match(customer2.Email);
    Match match3 = regex.Match(customer3.Email);

    // Assert
    Assert.True(match.Success);
    Assert.True(match2.Success);
    Assert.False(match3.Success);
  }
}