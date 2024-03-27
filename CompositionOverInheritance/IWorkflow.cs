using CompositionOverInheritance.Persona;

namespace CompositionOverInheritance;

public interface IWorkflow
{
  void ProcessActivities(TeamMemberBase member);
}
