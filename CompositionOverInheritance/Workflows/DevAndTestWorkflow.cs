using CompositionOverInheritance.Activities;
using CompositionOverInheritance.Persona;

namespace CompositionOverInheritance.Workflows;

public class DevAndTestWorkflow : IWorkflow
{
  private readonly IDevelopmentActivity _developmentActivity;
  private readonly ITestActivity _testActivity;

  public DevAndTestWorkflow(
    IDevelopmentActivity developmentActivity,
    ITestActivity testActivity)
  {    
    _developmentActivity = developmentActivity ?? throw new ArgumentNullException(nameof(developmentActivity));
    _testActivity = testActivity ?? throw new ArgumentNullException(nameof(testActivity));
  }

  public void ProcessActivities(TeamMemberBase member)
  {
    _developmentActivity.Develop(member);
    _testActivity.Test(member);
  }
}
