using CompositionOverInheritance.Activities.Devs;
using CompositionOverInheritance.Activities.Tests;
using CompositionOverInheritance.Activities.Ticketings;
using CompositionOverInheritance.Persona;
using CompositionOverInheritance.Workflows;

namespace CompositionOverInheritance;

public class GivenCompositionOverInheritance
{
  [Fact]
  public void WhenUsingItThenItsAGoodPractice_Day1()
  {
    /// Context: 
    /// - developer is a junior and can only dev, 
    /// - architect can manage tickets as standard user but dev as senior
    /// - manager can manage tickets as premium user and do integration tests

    /// Arrange
    // Persona
    var manager = new Manager();
    var architect = new Architect();
    var juniorDevelopper = new Developer();
    // Activities
    // (imagine that is usually instanciated automatically by IoC/DI through a dedicated engine)
    var juniorDevelopmentActivity = new JuniorDevelopmentActivity();
    var seniorDevelopmentActivity = new SeniorDevelopmentActivity();
    var standardTicketingActivity = new StandardTicketingActivity();
    var premiumTicketingActivity = new PremiumTicketingActivity();
    var integrationTestActivity = new IntegrationTestActivity();
    // Workflows
    // (imagine that is usually instanciated automatically by IoC/DI through a dedicated engine)
    var devWithoutTestWorkflow = new DevWithoutTestWorkflow(juniorDevelopmentActivity);
    var manageAndDevWithoutTestWorkflow = new ManageAndDevWithoutTestWorkflow(standardTicketingActivity, seniorDevelopmentActivity);
    var manageWithTestWorkflow = new ManageWithTestWorkflow(premiumTicketingActivity, integrationTestActivity);


    /// Act
    devWithoutTestWorkflow.ProcessActivities(juniorDevelopper);
    manageAndDevWithoutTestWorkflow.ProcessActivities(architect);
    manageWithTestWorkflow.ProcessActivities(manager);


    /// Assert

  }

  [Fact]
  public void WhenUsingItThenItsAGoodPractice_Day2()
  {
    /// Context: 
    /// - senior dev can dev as a senior and do unit tests 
    /// - architect can manage tickets as standard user but dev as senior
    /// - manager can manage tickets as premium user and do integration tests
    /// - tester can manage tickets as premium user and user tests

    /// Arrange
    // Persona
    var manager = new Manager();
    var architect = new Architect();
    var seniorDevelopper = new Developer();
    var tester = new Tester();
    // Activities
    // (imagine that is usually instanciated automatically by IoC/DI through a dedicated engine)
    var seniorDevelopmentActivity = new SeniorDevelopmentActivity();
    var standardTicketingActivity = new StandardTicketingActivity();
    var premiumTicketingActivity = new PremiumTicketingActivity();
    var unitTestActivity = new UnitTestActivity();
    var integrationTestActivity = new IntegrationTestActivity();
    var userTestActivity = new UserTestActivity();
    // Workflows
    // (imagine that is usually instanciated automatically by IoC/DI through a dedicated engine)
    var devAndTestWorkflow = new DevAndTestWorkflow(seniorDevelopmentActivity, unitTestActivity);
    var manageAndDevWithoutTestWorkflow = new ManageAndDevWithoutTestWorkflow(standardTicketingActivity, seniorDevelopmentActivity);
    var manageWithTestWorkflow = new ManageWithTestWorkflow(premiumTicketingActivity, integrationTestActivity);
    var qualityWorkflow = new ManageWithTestWorkflow(premiumTicketingActivity, userTestActivity);


    /// Act
    devAndTestWorkflow.ProcessActivities(seniorDevelopper);
    manageAndDevWithoutTestWorkflow.ProcessActivities(architect);
    manageWithTestWorkflow.ProcessActivities(manager);
    qualityWorkflow.ProcessActivities(tester);


    /// Assert

  }
}