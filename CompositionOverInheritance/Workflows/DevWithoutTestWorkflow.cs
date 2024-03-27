using CompositionOverInheritance.Activities;
using CompositionOverInheritance.Persona;

namespace CompositionOverInheritance.Workflows;

public class DevWithoutTestWorkflow : IWorkflow
{
  private readonly IDevelopmentActivity _developmentActivity;
  public DevWithoutTestWorkflow(IDevelopmentActivity developmentActivity)
  {    
    _developmentActivity = developmentActivity ?? throw new ArgumentNullException(nameof(developmentActivity));
  }

  public void ProcessActivities(TeamMemberBase member)
  {
    _developmentActivity.Develop(member);
  }
}
