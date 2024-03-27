using CompositionOverInheritance.Activities;
using CompositionOverInheritance.Persona;

namespace CompositionOverInheritance.Workflows;

public class ManageAndDevWithoutTestWorkflow : IWorkflow
{
    private readonly ITicketingActivity _ticketingActivity;
    private readonly IDevelopmentActivity _developmentActivity;
    public ManageAndDevWithoutTestWorkflow(
      ITicketingActivity ticketingActivity, 
      IDevelopmentActivity developmentActivity)
    {
        _ticketingActivity = ticketingActivity ?? throw new ArgumentNullException(nameof(ticketingActivity));
        _developmentActivity = developmentActivity ?? throw new ArgumentNullException(nameof(developmentActivity));
    }

    public void ProcessActivities(TeamMemberBase member)
    {
        _ticketingActivity.CreateTicket(member);
        _ticketingActivity.AssignTicket(member);
        _developmentActivity.Develop(member);
    }
}
