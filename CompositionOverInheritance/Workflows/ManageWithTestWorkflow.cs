using CompositionOverInheritance.Activities;
using CompositionOverInheritance.Persona;

namespace CompositionOverInheritance.Workflows;

public class ManageWithTestWorkflow : IWorkflow
{
    private readonly ITicketingActivity _ticketingActivity;
    private readonly ITestActivity _testActivity;
    public ManageWithTestWorkflow(
      ITicketingActivity ticketingActivity, 
      ITestActivity testActivity)
    {
        _ticketingActivity = ticketingActivity ?? throw new ArgumentNullException(nameof(ticketingActivity));
        _testActivity = testActivity ?? throw new ArgumentNullException(nameof(testActivity));
    }

    public void ProcessActivities(TeamMemberBase member)
    {
        _ticketingActivity.CreateTicket(member);
        _ticketingActivity.AssignTicket(member);
        _testActivity.Test(member);
    }
}
