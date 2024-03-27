using CompositionOverInheritance.Persona;

namespace CompositionOverInheritance.Activities;

public interface ITicketingActivity : IActivity
{
    void CreateTicket(TeamMemberBase member);
    void AssignTicket(TeamMemberBase member);
}
