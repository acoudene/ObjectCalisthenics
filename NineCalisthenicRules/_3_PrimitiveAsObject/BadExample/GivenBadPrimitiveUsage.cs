using System.Text.RegularExpressions;

namespace NineCalisthenicRules._3_PrimitiveAsObject.BadExample;

public class GivenBadPrimitiveUsage
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    // Arrange
    string email = "anthony.coudene@gmail.com";

    // Act
    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    Match match = regex.Match(email);

    // Assert
    Assert.True(match.Success);
  }
}