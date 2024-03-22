namespace SolidPrinciples._5_DIP;

public class GivenDependencyInversionPrinciple
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice()
  {
    // Arrange
    var databaseLogger = new DatabaseLogger();
    var fileLogger = new FileLogger();
    var aggregateLogger = new AggregateLogger(fileLogger, databaseLogger);
    var myProduct = new MyProduct(fileLogger);
    var myProduct2 = new MyProduct(databaseLogger);
    var myProduct3 = new MyProduct(aggregateLogger);
    var myOtherProduct = new MyOtherProduct(databaseLogger);
    var myOtherProduct2= new MyOtherProduct(fileLogger);

    // Act
    myProduct.DoSomething();
    myProduct2.DoSomething();
    myProduct3.DoSomething();
    myOtherProduct.DoOtherThing();
    myOtherProduct2.DoOtherThing();
    
    // Assert
    
  }
}