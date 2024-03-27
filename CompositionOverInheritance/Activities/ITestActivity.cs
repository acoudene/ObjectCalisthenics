using CompositionOverInheritance.Persona;

namespace CompositionOverInheritance.Activities;

public interface ITestActivity : IActivity
{
    void Test(TeamMemberBase member);
}
