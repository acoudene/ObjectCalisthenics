using CompositionOverInheritance.Persona;

namespace CompositionOverInheritance.Activities;

public interface IDevelopmentActivity : IActivity
{
    void Develop(TeamMemberBase member);
}
