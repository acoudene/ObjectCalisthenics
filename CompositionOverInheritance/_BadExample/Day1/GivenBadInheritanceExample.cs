namespace CompositionOverInheritance._BadExample.Day1;

public class GivenBadInheritanceExample
{
  [Fact]
  public void WhenUsingItThenItsABadPractice()
  {
    /// Context: 
    /// - developer can only dev in a fixed way, 
    /// - architect can manage tickets and dev in a fixed way 
    /// - manager can manage tickets and tests in a fixed way

    /// Arrange
    var manager = new Manager();
    var architect = new Architect();
    var developper = new Developer();

    /// Act
    manager.ProcessActivities();
    architect.ProcessActivities();
    developper.ProcessActivities();

    /// Assert

  }
}